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

        // ===== LOAD =====
        private void DisplayBill_Load(object sender, EventArgs e)
        {
            StyleGrid();

            if (_billId > 0)
                LoadBill(_billId);
            else
                ClearBillLabels();
        }

        // ===== LOAD BILL =====
        private void LoadBill(int billId)
        {
            if (billId <= 0)
            {
                MessageBox.Show("Enter a valid Bill ID.");
                return;
            }

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

                    BindBill(bill);
                    BindBreakdownGrid(bill);

                    txtBillSearch.Text = bill.BusinessBillID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bill: " + ex.Message);
            }
        }

        // ===== BIND MAIN BILL DATA =====
        private void BindBill(dynamic bill)
        {
            lblBusinessName.Text = bill.CompanyName;
            lblBillDate.Text = bill.BillDate.ToString("dd/MM/yyyy");

            lblTotalCharges.Text = $"£{bill.TotalCharges:F2}";
            lblDiscount.Text = $"£{bill.TotalDiscount:F2}";
            lblSubTotal.Text = $"£{bill.SubTotal:F2}";
            lblVAT.Text = $"£{bill.VAT:F2}";
            lblFinalCost.Text = $"£{bill.BusinessFinalCost:F2}";
        }

        // ===== GRID DATA =====
        private void BindBreakdownGrid(dynamic bill)
        {
            dgvBillBreakdown.DataSource = new[]
            {
                new { Item = "Water Charges", Amount = bill.TotalCharges },
                new { Item = "Discount", Amount = -bill.TotalDiscount },
                new { Item = "VAT", Amount = bill.VAT },
                new { Item = "FINAL TOTAL", Amount = bill.BusinessFinalCost }
            };

            dgvBillBreakdown.Columns["Amount"].DefaultCellStyle.Format = "£0.00";
        }

        // ===== CLEAR =====
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

        // ===== GRID STYLE =====
        private void StyleGrid()
        {
            dgvBillBreakdown.ReadOnly = true;
            dgvBillBreakdown.AllowUserToAddRows = false;
            dgvBillBreakdown.AllowUserToDeleteRows = false;
            dgvBillBreakdown.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBillBreakdown.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillBreakdown.RowHeadersVisible = false;
            dgvBillBreakdown.BackgroundColor = Color.White;

            dgvBillBreakdown.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvBillBreakdown.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);
        }

        // ===== NAV =====
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }

        // ===== SEARCH =====
        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBillSearch.Text, out int billId) || billId <= 0)
            {
                MessageBox.Show("Enter a valid Bill ID.");
                return;
            }

            LoadBill(billId);
        }
    }
}