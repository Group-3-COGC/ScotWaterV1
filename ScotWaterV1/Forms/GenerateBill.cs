using iTextSharp.text;
using iTextSharp.text.pdf;
using ScotWaterV1.Models;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDFRect = iTextSharp.text.Rectangle;

namespace ScotWaterV1.Forms
{
    public partial class frmGenerateBill : Form
    {
        public frmGenerateBill()
        {
            InitializeComponent();
        }

        private void frmGenerateBill_Load(object sender, EventArgs e)
        {
            LoadBusinesses();
            LoadBusinessGrid();
            dtpBillDate.Value = DateTime.Now.Date;
        }

        private void LoadBusinesses()
        {
            using (var context = new BusinessDataContext())
            {
                var businesses = context.BusinessUser
                    .OrderBy(b => b.CompanyName)
                    .Select(b => new
                    {
                        b.BusinessID,
                        b.CompanyName
                    })
                    .ToList();

                cmbBusinessNames.DataSource = businesses;
                cmbBusinessNames.DisplayMember = "CompanyName";
                cmbBusinessNames.ValueMember = "BusinessID";

                cmbBusinessNames.DropDownStyle = ComboBoxStyle.DropDown;
                cmbBusinessNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbBusinessNames.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void LoadBusinessGrid()
        {
            using (var context = new BusinessDataContext())
            {
                dgvBusinessesBill.DataSource = context.BusinessUser
                    .OrderBy(b => b.CompanyName)
                    .Select(b => new
                    {
                        b.BusinessID,
                        b.CompanyName,
                        b.ContactEmail
                    })
                    .ToList();
            }

            dgvBusinessesBill.ReadOnly = true;
            dgvBusinessesBill.AllowUserToAddRows = false;
            dgvBusinessesBill.AllowUserToDeleteRows = false;
            dgvBusinessesBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBusinessesBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvBusinessesBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = dgvBusinessesBill.Rows[e.RowIndex]
                    .Cells["CompanyName"].Value.ToString();

                cmbBusinessNames.Text = name;
            }
        }

        private async void btnGenerateBill_Click_1(object sender, EventArgs e)
        {
            if (cmbBusinessNames.SelectedValue == null)
            {
                MessageBox.Show("Please select a business.");
                return;
            }

            if (!int.TryParse(cmbBusinessNames.SelectedValue.ToString(), out int businessId))
            {
                MessageBox.Show("Invalid business selected.");
                return;
            }

            DateTime billDate = dtpBillDate.Value.Date;

            using (var context = new BusinessDataContext())
            {
                var business = context.BusinessUser.FirstOrDefault(b => b.BusinessID == businessId);

                if (business == null)
                {
                    MessageBox.Show("Business not found.");
                    return;
                }

                var usage = context.WaterUsage.FirstOrDefault(w =>
                    w.BusinessID == businessId &&
                    DbFunctions.TruncateTime(w.ReadingDate) == billDate);

                if (usage == null)
                {
                    MessageBox.Show("No water usage found for this business on the selected date.");
                    return;
                }

                var existingBill = context.BusinessBills.FirstOrDefault(b =>
                    b.BusinessID == businessId &&
                    DbFunctions.TruncateTime(b.BillDate) == billDate);

                if (existingBill != null)
                {
                    MessageBox.Show("A bill already exists. Opening it.");
                    OpenBillInMainPanel(existingBill.BusinessBillID);
                    return;
                }

                var billingService = new BillingService();
                BusinessBills bill = billingService.GenerateBill(usage);

                bill.BusinessID = businessId;
                bill.BillDate = billDate;

                context.BusinessBills.Add(bill);
                context.SaveChanges();


                OpenBillInMainPanel(bill.BusinessBillID);

                // IMPORTANT: email runs AFTER bill is created
                bool emailSuccess = await SendBillEmail(bill, business);

                if (emailSuccess)
                    MessageBox.Show("Bill generated + email sent successfully.");
                else
                    MessageBox.Show("Bill generated, but email failed.");
            }
        }

        private void OpenBillInMainPanel(int billId)
        {
            frmMainMenu mainMenu = this.ParentForm as frmMainMenu;

            if (mainMenu != null)
            {
                mainMenu.OpenForm(new DisplayBill(billId));
                return;
            }

            mainMenu = Application.OpenForms
                .OfType<frmMainMenu>()
                .FirstOrDefault();

            if (mainMenu != null)
            {
                mainMenu.OpenForm(new DisplayBill(billId));
                return;
            }

            MessageBox.Show("Bill generated, but could not open display page.");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault()?.Close();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Close();
        }

        // ================= EMAIL + PDF =================
        private async Task<bool> SendBillEmail(BusinessBills bill, BusinessUser business)
        {
            try
            {
                if (business == null || string.IsNullOrWhiteSpace(business.ContactEmail))
                    return false;

                string pdfPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    $"ScotWaterBill_{bill.BusinessBillID}.pdf"
                );

                // ================= PDF =================
                Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
                doc.Open();

                BaseColor blue = new BaseColor(0, 70, 140);
                BaseColor lightGray = new BaseColor(245, 245, 245);

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20, blue);
                var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                var valueFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);

                PdfPTable header = new PdfPTable(1);
                header.WidthPercentage = 100;

                PdfPCell title = new PdfPCell(new Phrase("SCOTWATER BUSINESS INVOICE", titleFont));
                title.Border = PDFRect.NO_BORDER;
                title.HorizontalAlignment = Element.ALIGN_CENTER;

                header.AddCell(title);
                doc.Add(header);

                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;

                void Add(string a, string b)
                {
                    table.AddCell(new PdfPCell(new Phrase(a, headerFont)) { BackgroundColor = lightGray, Padding = 6 });
                    table.AddCell(new PdfPCell(new Phrase(b ?? "-", valueFont)) { Padding = 6 });
                }

                Add("Business Name", business.CompanyName);
                Add("Contact Name", business.ContactName);
                Add("Contact Email", business.ContactEmail);
                Add("Postcode", business.Postcode);
                Add("Bill Date", bill.BillDate.ToString("dd/MM/yyyy"));

                doc.Add(table);
                doc.Close();

                // ================= EMAIL =================
                using (var db = new BusinessDataContext())
                {
                    var config = db.EmailConfigs.FirstOrDefault();
                    if (config == null) return false;

                    using (MailMessage message = new MailMessage())
                    using (SmtpClient smtp = new SmtpClient(config.SmtpHost, config.SmtpPort))
                    {
                        message.From = new MailAddress(config.SenderEmail);
                        message.To.Add(business.ContactEmail);
                        message.Subject = "Your ScotWater Bill";
                        message.Body = $"Hello {business.ContactName ?? business.CompanyName}, your bill is attached.";
                        message.Attachments.Add(new Attachment(pdfPath));

                        smtp.EnableSsl = config.EnableSsl;
                        smtp.Credentials = new NetworkCredential(config.SenderEmail, config.SenderPassword);

                        await smtp.SendMailAsync(message);
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email error: " + ex.Message);
                return false;
            }
        }
    }
}