using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

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

        // ================= LOAD SINGLE BILL =================
        private void LoadBill(int billId)
        {
            try
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
                            CompanyName = b.BusinessUser.CompanyName
                        })
                        .FirstOrDefault();

                    if (bill == null)
                    {
                        MessageBox.Show("Bill not found.");
                        ClearBillLabels();
                        return;
                    }

                    // ================= LABELS =================
                    lblBusinessName.Text = bill.CompanyName;
                    lblBillDate.Text = bill.BillDate.ToString("dd/MM/yyyy");
                    lblTotalCharges.Text = $"£{bill.TotalCharges:F2}";
                    lblDiscount.Text = $"£{bill.TotalDiscount:F2}";
                    lblSubTotal.Text = $"£{bill.SubTotal:F2}";
                    lblVAT.Text = $"£{bill.VAT:F2}";
                    lblFinalCost.Text = $"£{bill.BusinessFinalCost:F2}";

                    txtBillSearch.Text = bill.BusinessBillID.ToString();

                    // ================= GRID =================
                    dgvBillBreakdown.DataSource = new[]
                    {
                        new { Item = "Water Charges", Amount = bill.TotalCharges },
                        new { Item = "Discount", Amount = -bill.TotalDiscount },
                        new { Item = "VAT", Amount = bill.VAT },
                        new { Item = "FINAL TOTAL", Amount = bill.BusinessFinalCost }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bill: " + ex.Message);
            }
        }

        // ================= CLEAR =================
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

        // ================= STYLE GRID =================
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

        // ================= SEARCH =================
        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBillSearch.Text, out int billId))
            {
                MessageBox.Show("Enter valid Bill ID.");
                return;
            }

            LoadBill(billId);
        }

        // ================= NAV =================
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Close();
        }
    }
}