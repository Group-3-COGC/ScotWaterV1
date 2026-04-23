using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class DisplayBill : Form
    {
        private int _billId;

        // Constructor that receives the Bill ID
        public DisplayBill(int billId)
        {
            InitializeComponent();
            _billId = billId;
        }

        // Load bill details when the form opens
        private void DisplayBill_Load(object sender, EventArgs e)
        {
            using (var context = new BusinessDataContext())
            {
                var bill = context.BusinessBills
                    .Where(b => b.BusinessBillID == _billId)
                    .Select(b => new
                    {
                        b.BillDate,
                        b.TotalCharges,
                        b.TotalDiscount,
                        b.DiscountRate,
                        b.SubTotal,
                        b.VAT,
                        b.BusinessFinalCost,
                        b.BusinessUser.CompanyName
                    })
                    .FirstOrDefault();

                if (bill == null)
                {
                    MessageBox.Show("Bill not found.");
                    return;
                }

                // Fill labels on the form
                lblCompanyName.Text = bill.CompanyName;
                lblBillDate.Text = bill.BillDate.ToShortDateString();
                lblTotalCharges.Text = bill.TotalCharges.ToString("C");
                lblDiscount.Text = bill.TotalDiscount.ToString("C");
                lblSubTotal.Text = bill.SubTotal.ToString("C");
                lblVAT.Text = bill.VAT.ToString("C");
                lblFinalCost.Text = bill.BusinessFinalCost.ToString("C");
            }
        }

        // Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Back to main menu
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            menu.Show();
            this.Hide();
        }
    }
}
