using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class DisplayBill : Form
    {
        private int _billId;

        public DisplayBill(int billId)
        {
            InitializeComponent();
            _billId = billId;
        }

        private void DisplayBill_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new BusinessDataContext())
                {
                    var bill = context.BusinessBills
                        .Include("BusinessUser")
                        .Where(b => b.BusinessBillID == _billId)
                        .Select(b => new
                        {
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
                        return;
                    }

                    lblBusinessName.Text = bill.CompanyName;
                    lblBillDate.Text = bill.BillDate.ToShortDateString();
                    lblTotalCharges.Text = bill.TotalCharges.ToString("C");
                    lblDiscount.Text = bill.TotalDiscount.ToString("C");
                    lblSubTotal.Text = bill.SubTotal.ToString("C");
                    lblVAT.Text = bill.VAT.ToString("C");
                    lblFinalCost.Text = bill.BusinessFinalCost.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the bill: " + ex.Message);
            }
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
                this.Close();
            }
        }

        private void btnBillSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBillSearch.Text, out int billId))
            {
                LoadBill(billId);
            }
            else
            {
                MessageBox.Show("Enter a valid Bill ID.");
            }
        }

        private void LoadBill(int billId)
        {
            try
            {
                using (var context = new BusinessDataContext())
                {
                    var bill = context.BusinessBills
                        .Include("BusinessUser")
                        .Where(b => b.BusinessBillID == billId)
                        .Select(b => new
                        {
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
                        return;
                    }

                    lblBusinessName.Text = bill.CompanyName;
                    lblBillDate.Text = bill.BillDate.ToShortDateString();
                    lblTotalCharges.Text = bill.TotalCharges.ToString("C");
                    lblDiscount.Text = bill.TotalDiscount.ToString("C");
                    lblSubTotal.Text = bill.SubTotal.ToString("C");
                    lblVAT.Text = bill.VAT.ToString("C");
                    lblFinalCost.Text = bill.BusinessFinalCost.ToString("C");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading the bill: " + ex.Message);
            }
        }
    }
}

