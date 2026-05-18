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

        // ================= PDF SAVE AS =================
        private void btnPrintPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBillSearch.Text, out int billId))
                {
                    MessageBox.Show("Invalid Bill ID");
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save ScotWater Invoice";
                saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"ScotWaterBill_{billId}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GeneratePdf(saveFileDialog.FileName);
                    MessageBox.Show("PDF saved successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF Error: " + ex.Message);
            }
        }

        // ================= PDF GENERATION =================
        private void GeneratePdf(string path)
        {
            if (File.Exists(path))
                File.Delete(path);

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
                PdfWriter.GetInstance(doc, fs);
                doc.Open();

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
                var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                var normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
                var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.WHITE);
                var totalFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13, BaseColor.RED);

                // ================= LOGO =================
                string logoPath = @"C:\Users\30553902\source\repos\Group-3-COGC\ScotWaterV1\ScotWaterV1\Images\Designer.png";

                if (File.Exists(logoPath))
                {
                    var logo = iTextSharp.text.Image.GetInstance(logoPath);
                    logo.ScaleToFit(120f, 120f);
                    logo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(logo);
                }

                // ================= TITLE =================
                Paragraph title = new Paragraph("SCOTWATER INVOICE", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph(" "));

                // ================= INFO TABLE =================
                PdfPTable info = new PdfPTable(2);
                info.WidthPercentage = 100;

                void AddRow(string label, string value)
                {
                    PdfPCell c1 = new PdfPCell(new Phrase(label, boldFont));
                    c1.BackgroundColor = BaseColor.LIGHT_GRAY;
                    c1.Padding = 6;

                    PdfPCell c2 = new PdfPCell(new Phrase(value, normalFont));
                    c2.Padding = 6;

                    info.AddCell(c1);
                    info.AddCell(c2);
                }

                AddRow("Business", lblBusinessName.Text);
                AddRow("Date", lblBillDate.Text);
                AddRow("Charges", lblTotalCharges.Text);
                AddRow("Discount", lblDiscount.Text);
                AddRow("Subtotal", lblSubTotal.Text);
                AddRow("VAT", lblVAT.Text);

                PdfPCell t1 = new PdfPCell(new Phrase("FINAL TOTAL", boldFont));
                t1.BackgroundColor = BaseColor.LIGHT_GRAY;

                PdfPCell t2 = new PdfPCell(new Phrase(lblFinalCost.Text, totalFont));

                info.AddCell(t1);
                info.AddCell(t2);

                doc.Add(info);

                doc.Add(new Paragraph(" "));

                // ================= GRID =================
                PdfPTable table = new PdfPTable(dgvBillBreakdown.Columns.Count);
                table.WidthPercentage = 100;

                foreach (DataGridViewColumn col in dgvBillBreakdown.Columns)
                {
                    PdfPCell h = new PdfPCell(new Phrase(col.HeaderText, headerFont));
                    h.BackgroundColor = new BaseColor(0, 102, 204);
                    h.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(h);
                }

                foreach (DataGridViewRow row in dgvBillBreakdown.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string text = cell.Value?.ToString() ?? "";

                        PdfPCell c = new PdfPCell(new Phrase(text, normalFont));

                        if (text.Contains("FINAL TOTAL"))
                        {
                            c.Phrase = new Phrase(text, totalFont);
                            c.BackgroundColor = new BaseColor(255, 230, 230);
                        }

                        table.AddCell(c);
                    }
                }

                doc.Add(table);

                doc.Add(new Paragraph(" "));
                doc.Add(new Paragraph("Thank you for using ScotWater.", normalFont));

                doc.Close();
            }
        }

        // ================= EMAIL (UNCHANGED) =================
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

                    if (string.IsNullOrWhiteSpace(toEmail))
                    {
                        MessageBox.Show("No email found for this business.");
                        return;
                    }

                    toEmail = toEmail.Trim();

                    try { new MailAddress(toEmail); }
                    catch
                    {
                        MessageBox.Show("Invalid email in database: " + toEmail);
                        return;
                    }

                    string pdfPath = Path.GetTempFileName();
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

        // ================= SMTP (UNCHANGED) =================
        private async Task SendEmailAsync(string toEmail, string attachmentPath)
        {
            string senderEmail = "scottwatertest@gmail.com";
            string senderPassword = "hyad gfyc dwqb iitn";

            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(senderEmail);
                message.To.Add(new MailAddress(toEmail));
                message.Subject = "Your ScotWater Bill";
                message.Body = "Please find your bill attached.";

                if (File.Exists(attachmentPath))
                    message.Attachments.Add(new Attachment(attachmentPath));

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    smtp.Timeout = 30000;

                    await smtp.SendMailAsync(message);
                }
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