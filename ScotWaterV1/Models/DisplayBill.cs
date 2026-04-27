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
            using (var context = new BusinessDataContext())
            {
                var bill = context.BusinessBills
                    .FirstOrDefault(b => b.BusinessBillID == _billId);

                if (bill == null)
                {
                    MessageBox.Show("Bill not found.");
                    return;
                }

                // Load business info
                var business = context.BusinessUser
                    .FirstOrDefault(b => b.BusinessID == bill.BusinessID);

                // -----------------------------
                // DISPLAY BILL DETAILS ON FORM
                // -----------------------------
                lblBusinessName.Text = business.CompanyName;
                lblBillDate.Text = bill.BillDate.ToShortDateString();
                lblTotalCharges.Text = bill.TotalCharges.ToString("C");
                lblDiscount.Text = bill.TotalDiscount.ToString("C");
                lblSubTotal.Text = bill.SubTotal.ToString("C");
                lblVAT.Text = bill.VAT.ToString("C");
                lblFinalCost.Text = bill.BusinessFinalCost.ToString("C");
            }
        }
    }
}
