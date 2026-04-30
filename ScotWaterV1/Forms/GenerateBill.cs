using ScotWaterV1.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


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




        private void btnGenerateBill_Click_1(object sender, EventArgs e)
        {

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
                    var business = context.BusinessUser.FirstOrDefault(b => b.BusinessID == businessId);

                    if (business == null)
                    {
                        MessageBox.Show("Business not found.");
                        return;
                    }

                    var usage = context.WaterUsage
                        .FirstOrDefault(w => w.BusinessID == businessId &&
                                 DbFunctions.TruncateTime(w.ReadingDate) == billDate);

                    if (usage == null)
                    {
                        MessageBox.Show("No water usage found for this date.");
                        return;
                    }

                    bool billAlreadyExists = context.BusinessBills.Any(b =>
                        b.BusinessID == businessId &&
                        DbFunctions.TruncateTime(b.BillDate) == billDate);

                    if (billAlreadyExists)
                    {
                        MessageBox.Show("A bill already exists for this business on this date");
                        return;
                    }
                    var billingService = new BillingService();
                    BusinessBills bill = billingService.GenerateBill(usage);

                    bill.BusinessID = businessId;
                    bill.BillDate = billDate;

                    context.BusinessBills.Add(bill);
                    context.SaveChanges();

                    MessageBox.Show("Bill ID = " + bill.BusinessBillID);



                    SendBillEmail(bill, business);

                    DisplayBill displayForm = new DisplayBill(bill.BusinessBillID);
                    displayForm.Show();
                    this.Hide();
                }
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
        private void SendBillEmail(BusinessBills bill, BusinessUser business)
        {
            string subject = "Your Water Bill";
            string body =
                $"Hello {business.ContactName},\n\n" +
                $"Your water bill has been generated.\n\n" +
                $"Company: {business.CompanyName}\n" +
                $"Bill ID: {bill.BusinessBillID}\n" +
                $"Bill Date: {bill.BillDate:dd MMM yyyy}\n" +
                $"Total Amount: £{bill.BusinessFinalCost:F2}\n\n" +
                $"If you have any questions, contact us.\n\n" +
                $"Regards,\nScotWater Billing Team";

            try
            {
                MailMessage msg = new MailMessage();
                msg.To.Add(business.ContactEmail);
                msg.Subject = subject;
                msg.Body = body;
                msg.From = new MailAddress("yourcompany@example.com");

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("yourcompany@example.com", "yourpassword");

                smtp.Send(msg);

                MessageBox.Show("Bill emailed to client successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bill generated, but email failed to send.\n\nError: " + ex.Message);
            }
        }

    }
}

