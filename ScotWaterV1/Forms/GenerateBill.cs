using ScotWaterV1.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmGenerateBill : Form
    {
        public frmGenerateBill()
        {
            InitializeComponent();
        }

        // LOAD BUSINESSES INTO COMBO BOX WHEN FORM LOADS
  
        private void frmGenerateBill_Load(object sender, EventArgs e)
        {
            using (var context = new BusinessDataContext())
            {
                var businesses = context.BusinessUser
                    .Select(b => new { b.BusinessID, b.CompanyName })
                    .ToList();

                cmbBusinessNames.DataSource = businesses;
                cmbBusinessNames.DisplayMember = "CompanyName";
                cmbBusinessNames.ValueMember = "BusinessID";
            }

            dtpBillDate.Value = DateTime.Now;
        }

        
        // GENERATE BILL BUTTON CLICK
        

        private void btnGenerateBill_Click_1(object sender, EventArgs e)
        {
            if (cmbBusinessNames.SelectedValue == null)
            {
                MessageBox.Show("Please select a business.");
                return;
            }

            int businessId = (int)cmbBusinessNames.SelectedValue;
            DateTime billDate = dtpBillDate.Value.Date;

            using (var context = new BusinessDataContext())
            {

                var usage = context.WaterUsage
               .FirstOrDefault(w => w.BusinessID == businessId &&
                         DbFunctions.TruncateTime(w.ReadingDate) == billDate);


                if (usage == null)
                {
                    MessageBox.Show("No water usage found for this date.");
                    return;
                }

                // -------------------------------
                // BILL CALCULATION LOGIC
                // -------------------------------
                decimal chargePerUnit = 0.20m;
                decimal discountRate = usage.IsLowReserve ? 0.10m : 0.05m;
                decimal vatRate = 0.20m;

                decimal totalCharges = usage.FreshwaterUnitsUsed * chargePerUnit;
                decimal totalDiscount = totalCharges * discountRate;
                decimal subTotal = totalCharges - totalDiscount;
                decimal vat = subTotal * vatRate;
                decimal finalCost = subTotal + vat;

                // -------------------------------
                // SAVE BILL TO DATABASE
                // -------------------------------
                BusinessBills bill = new BusinessBills()
                {
                    BusinessID = businessId,
                    BillDate = billDate,
                    TotalCharges = totalCharges,
                    TotalDiscount = totalDiscount,
                    DiscountRate = discountRate,
                    SubTotal = subTotal,
                    VAT = vat,
                    BusinessFinalCost = finalCost
                };

                context.BusinessBills.Add(bill);
                context.SaveChanges();

                MessageBox.Show("Bill generated successfully!");

                // -------------------------------
                // OPEN DISPLAY BILL FORM
                // -------------------------------
                DisplayBill displayForm = new DisplayBill(bill.BusinessBillID);
                displayForm.Show();
                this.Close();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmLogin SignOut = new frmLogin();
            SignOut.Show();
            this.Hide();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu Main = new frmMainMenu();
            Main.Show();
            this.Hide();
        }
    }
    }

