using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ScotWaterV1.Forms
{
    public partial class DisplayBill : Form
    {
        private readonly int _billId;

        public DisplayBill()
        {
            InitializeComponent();
            _billId = 0;
        }

        public DisplayBill(int billId)
        {
            InitializeComponent();
            _billId = billId;
        }

        // ================= LOAD =================
        private void DisplayBill_Load(object sender, EventArgs e)
        {
            StyleGrid();

            if (_billId > 0)
                LoadBill(_billId);
            else
                ClearBillLabels();
        }

        private void LoadBill(int billId)
        {
            using (var context = new BusinessDataContext())
            {
                var bill = context.BusinessBills
                    .Where(b => b.BusinessBillID == billId)
                    .Select(b => new
                    {
                        b.BusinessBillID,
                        b.BillDate,
                        b.TotalCharges,
                        b.TotalDiscount,
                        b.SubTotal,
                        b.VAT,
                        b.BusinessFinalCost,
                        b.BusinessUser.BusinessID,
                        b.BusinessUser.CompanyName,
                        b.BusinessUser.ContactName,
                        b.BusinessUser.ContactEmail,
                        b.BusinessUser.Postcode
                    })
                    .FirstOrDefault();

                if (bill == null)
                {
                    MessageBox.Show("Bill not found.");
                    ClearBillLabels();
                    return;
                }

                lblBusinessName.Text = bill.CompanyName;
                lblBillDate.Text = bill.BillDate.ToString("dd/MM/yyyy");
                lblTotalCharges.Text = $"£{bill.TotalCharges:F2}";
                lblDiscount.Text = $"£{bill.TotalDiscount:F2}";
                lblSubTotal.Text = $"£{bill.SubTotal:F2}";
                lblVAT.Text = $"£{bill.VAT:F2}";
                lblFinalCost.Text = $"£{bill.BusinessFinalCost:F2}";

                txtBillSearch.Text = bill.BusinessBillID.ToString();

                dgvBillBreakdown.DataSource = new[]
                {
                    new { Item = "Water Charges", Amount = bill.TotalCharges },
                    new { Item = "Discount", Amount = -bill.TotalDiscount },
                    new { Item = "Subtotal", Amount = bill.SubTotal },
                    new { Item = "VAT", Amount = bill.VAT },
                    new { Item = "FINAL TOTAL", Amount = bill.BusinessFinalCost }
                };
            }
        }

        private void ClearBillLabels()
        {
            lblBusinessName.Text = "-";
            lblBillDate.Text = "-";
            lblTotalCharges.Text = "-";
            lblDiscount.Text = "-";
            lblSubTotal.Text = "-";
            lblVAT.Text = "-";
            lblFinalCost.Text = "-";

            dgvBillBreakdown.DataSource = null;
        }

        private void StyleGrid()
        {
            dgvBillBreakdown.ReadOnly = true;
            dgvBillBreakdown.AllowUserToAddRows = false;
            dgvBillBreakdown.AllowUserToDeleteRows = false;
            dgvBillBreakdown.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillBreakdown.RowHeadersVisible = false;
            dgvBillBreakdown.BackgroundColor = Color.White;
        }

        // ================= SAFE PDF PATH =================
        private string GetPdfPath(int billId)
        {
            string folder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ScotWaterV1",
                "Bills"
            );

            Directory.CreateDirectory(folder);

            return Path.Combine(folder, $"ScotWaterBill_{billId}.pdf");
        }

        // ================= PDF =================
        private void btnPrintPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBillSearch.Text, out int billId))
                {
                    MessageBox.Show("Invalid Bill ID");
                    return;
                }

                string path = GetPdfPath(billId);
                GeneratePdf(path);

                MessageBox.Show($"PDF saved here:\n{path}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF Error: " + ex.Message);
            }
        }

        private void GeneratePdf(string path)
        {
            if (File.Exists(path))
                File.Delete(path);

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                Document doc = new Document(PageSize.A4);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                var normal = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                doc.Add(new Paragraph("SCOTWATER INVOICE", titleFont));
                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph($"Business: {lblBusinessName.Text}", normal));
                doc.Add(new Paragraph($"Date: {lblBillDate.Text}", normal));
                doc.Add(new Paragraph($"Total: {lblFinalCost.Text}", normal));

                doc.Close();
            }
        }

        // ================= EMAIL FIXED (NO CRASH) =================
        private async void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBillSearch.Text, out int billId))
                {
                    MessageBox.Show("Load a bill first.");
                    return;
                }

                using (var context = new BusinessDataContext())
                {
                    var bill = context.BusinessBills.FirstOrDefault(b => b.BusinessBillID == billId);

                    if (bill == null)
                    {
                        MessageBox.Show("Bill not found.");
                        return;
                    }

                    var business = context.BusinessUser.FirstOrDefault(b => b.BusinessID == bill.BusinessID);

                    if (business == null)
                    {
                        MessageBox.Show("Business not found.");
                        return;
                    }

                    string toEmail = business.ContactEmail;

                    // 🔥 FIX: stop invalid email crash
                    if (string.IsNullOrWhiteSpace(toEmail))
                    {
                        MessageBox.Show("No email found for this business.");
                        return;
                    }

                    toEmail = toEmail.Trim();

                    try
                    {
                        new MailAddress(toEmail); // validate only
                    }
                    catch
                    {
                        MessageBox.Show("Invalid email in database: " + toEmail);
                        return;
                    }

                    string pdfPath = GetPdfPath(billId);
                    GeneratePdf(pdfPath);

                    await SendEmailAsync(toEmail, pdfPath);

                    MessageBox.Show("Email sent successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email failed: " + ex.Message);
            }
        }

        // ================= SAFE SMTP =================
        private async Task SendEmailAsync(string toEmail, string attachmentPath)
        {
            string senderEmail = "WaterscotTest@outlook.com";
            string senderPassword = "0776Hh<3";

            if (string.IsNullOrWhiteSpace(senderEmail) || !senderEmail.Contains("@"))
                throw new Exception("Sender email is invalid.");

            if (string.IsNullOrWhiteSpace(toEmail) || !toEmail.Contains("@"))
                throw new Exception("Recipient email is invalid.");

            using (MailMessage message = new MailMessage())
            using (SmtpClient smtp = new SmtpClient("smtp.office365.com", 587))
            {
                message.From = new MailAddress(senderEmail);
                message.To.Add(new MailAddress(toEmail));
                message.Subject = "Your ScotWater Bill";
                message.Body = "Please find your bill attached.";

                if (File.Exists(attachmentPath))
                    message.Attachments.Add(new Attachment(attachmentPath));

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtp.Timeout = 20000;

                await smtp.SendMailAsync(message);
            }
        }

        // ================= SEARCH =================
        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBillSearch.Text, out int id))
                LoadBill(id);
            else
                MessageBox.Show("Enter valid Bill ID.");
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Close();
        }
    }
}