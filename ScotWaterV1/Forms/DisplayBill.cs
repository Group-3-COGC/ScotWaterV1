using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    //Dean Caldwell
    //06/05/2026
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
            if (_billId > 0)
            {
                LoadBill(_billId);
            }
            else
            {
                ClearBillLabels();
            }
        }

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

                    lblBusinessName.Text = bill.CompanyName;
                    lblBillDate.Text = bill.BillDate.ToString("dd/MM/yyyy");
                    lblTotalCharges.Text = $"£{bill.TotalCharges:F2}";
                    lblDiscount.Text = $"£{bill.TotalDiscount:F2}";
                    lblSubTotal.Text = $"£{bill.SubTotal:F2}";
                    lblVAT.Text = $"£{bill.VAT:F2}";
                    lblFinalCost.Text = $"£{bill.BusinessFinalCost:F2}";

                    txtBillSearch.Text = bill.BusinessBillID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the bill: " + ex.Message);
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
        }

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

        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBillSearch.Text))
            {
                MessageBox.Show("Please enter a Bill ID.");
                return;
            }

            if (!int.TryParse(txtBillSearch.Text, out int billId) || billId <= 0)
            {
                MessageBox.Show("Enter a valid Bill ID.");
                return;
            }

            LoadBill(billId);
        }
    }
}