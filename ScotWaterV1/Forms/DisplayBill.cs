using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

// iTextSharp
using iTextSharp.text;
using iTextSharp.text.pdf;

// SAFE ALIASES (IMPORTANT FIX)
using PDFRect = iTextSharp.text.Rectangle;
using PDFImage = iTextSharp.text.Image;
using PDFColor = iTextSharp.text.BaseColor;

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

        private void DisplayBill_Load(object sender, EventArgs e)
        {
            StyleGrid();

            if (_billId > 0)
                LoadBill(_billId);
            else
                ClearBillLabels();
        }

        // ================= LOAD BILL =================
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
                        b.BusinessUser.CompanyName,
                        b.BusinessUser.ContactName,
                        b.BusinessUser.ContactEmail,
                        b.BusinessUser.Postcode,
                        b.BusinessUser.BusinessID
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

        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBillSearch.Text, out int id))
                LoadBill(id);
            else
                MessageBox.Show("Enter valid Bill ID.");
        }

        // ================= PDF EXPORT =================
        private void btnPrintPdf_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog
                {
                    Filter = "PDF File|*.pdf",
                    FileName = "ScotWaterBill.pdf"
                };

                if (save.ShowDialog() != DialogResult.OK)
                    return;

                Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                PdfWriter.GetInstance(doc, new FileStream(save.FileName, FileMode.Create));
                doc.Open();

                // COLORS
                BaseColor blue = new BaseColor(0, 70, 140);
                BaseColor lightGray = new BaseColor(245, 245, 245);
                BaseColor red = new BaseColor(200, 0, 0);

                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20, blue);
                var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                var valueFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
                var totalFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, red);

                // ================= LOGO =================
                string logoPath = @"C:\Users\30553902\source\repos\Group-3-COGC\ScotWaterV1\ScotWaterV1\Images\Designer.png";

                PdfPTable header = new PdfPTable(2);
                header.WidthPercentage = 100;
                header.SetWidths(new float[] { 70f, 30f });

                PdfPCell title = new PdfPCell(new Phrase("SCOTWATER BUSINESS INVOICE", titleFont));
                title.Border = PDFRect.NO_BORDER;

                PdfPCell logoCell = new PdfPCell();
                logoCell.Border = PDFRect.NO_BORDER;

                if (File.Exists(logoPath))
                {
                    PDFImage logo = PDFImage.GetInstance(logoPath);
                    logo.ScaleToFit(100f, 100f);
                    logo.Alignment = Element.ALIGN_RIGHT;
                    logoCell.AddElement(logo);
                }

                header.AddCell(title);
                header.AddCell(logoCell);

                doc.Add(header);
                doc.Add(new Paragraph("\n"));

                // ================= BUSINESS DETAILS =================
                PdfPTable business = new PdfPTable(2);
                business.WidthPercentage = 100;

                void AddBusiness(string a, string b)
                {
                    PdfPCell c1 = new PdfPCell(new Phrase(a, headerFont));
                    PdfPCell c2 = new PdfPCell(new Phrase(b ?? "-", valueFont));

                    c1.BackgroundColor = lightGray;
                    c1.Padding = 6;
                    c2.Padding = 6;

                    business.AddCell(c1);
                    business.AddCell(c2);
                }

                AddBusiness("Business Name", lblBusinessName.Text);

                // ✅ FIXED ONLY THIS LINE
                AddBusiness("Contact Email", lblBusinessName.Text);

                AddBusiness("Bill Date", lblBillDate.Text);

                doc.Add(business);

                doc.Add(new Paragraph("\n"));

                // ================= BILL DETAILS =================
                PdfPTable billTable = new PdfPTable(2);
                billTable.WidthPercentage = 100;

                void AddBill(string a, string b, bool isTotal = false)
                {
                    PdfPCell c1 = new PdfPCell(new Phrase(a, headerFont));
                    PdfPCell c2 = new PdfPCell(new Phrase(b ?? "-", isTotal ? totalFont : valueFont));

                    c1.BackgroundColor = isTotal ? new BaseColor(255, 220, 220) : lightGray;
                    c2.BackgroundColor = isTotal ? new BaseColor(255, 220, 220) : lightGray;

                    c1.Padding = 6;
                    c2.Padding = 6;

                    billTable.AddCell(c1);
                    billTable.AddCell(c2);
                }

                AddBill("Total Charges", lblTotalCharges.Text);
                AddBill("Discount", lblDiscount.Text);
                AddBill("Subtotal", lblSubTotal.Text);
                AddBill("VAT", lblVAT.Text);
                AddBill("FINAL TOTAL", lblFinalCost.Text, true);

                doc.Add(billTable);

                doc.Add(new Paragraph("\nThank you for your business!", titleFont));

                doc.Close();

                MessageBox.Show("PDF created successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF Error: " + ex.Message);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Close();
        }
    }
}