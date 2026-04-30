using ScotWaterV1.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            }

            dtpBillDate.Value = DateTime.Now.Date;
        }

        private void btnGenerateBill_Click_1(object sender, EventArgs e)
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
                var business = context.BusinessUser
                    .FirstOrDefault(b => b.BusinessID == businessId);

                if (business == null)
                {
                    MessageBox.Show("Business not found.");
                    return;
                }

                var usage = context.WaterUsage
                    .FirstOrDefault(w =>
                        w.BusinessID == businessId &&
                        DbFunctions.TruncateTime(w.ReadingDate) == billDate);

                if (usage == null)
                {
                    MessageBox.Show("No water usage found for this business on the selected date.");
                    return;
                }

                var existingBill = context.BusinessBills
                    .FirstOrDefault(b =>
                        b.BusinessID == businessId &&
                        DbFunctions.TruncateTime(b.BillDate) == billDate);

                if (existingBill != null)
                {
                    MessageBox.Show("A bill already exists for this business on this date. Opening existing bill.");

                    OpenBillInMainPanel(existingBill.BusinessBillID);
                    return;
                }

                var billingService = new BillingService();
                BusinessBills bill = billingService.GenerateBill(usage);

                bill.BusinessID = businessId;
                bill.BillDate = billDate;

                context.BusinessBills.Add(bill);
                context.SaveChanges();

                MessageBox.Show("Bill generated successfully. Bill ID = " + bill.BusinessBillID);

                SendBillEmail(bill, business);

                OpenBillInMainPanel(bill.BusinessBillID);
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

            MessageBox.Show("Bill generated, but could not open the display bill page.");
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = this.ParentForm as frmMainMenu;

            if (mainMenu != null)
            {
                frmLogin login = new frmLogin();
                login.Show();
                mainMenu.Close();
                return;
            }

            frmLogin signOut = new frmLogin();
            signOut.Show();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = this.ParentForm as frmMainMenu;

            if (mainMenu != null)
            {
                this.Close();
                return;
            }

            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void SendBillEmail(BusinessBills bill, BusinessUser business)
        {
            if (business == null)
            {
                MessageBox.Show("Bill generated, but business details could not be found.");
                return;
            }

            if (string.IsNullOrWhiteSpace(business.ContactEmail) || !business.ContactEmail.Contains("@"))
            {
                MessageBox.Show("Bill generated, but no valid email address was found for this business.");
                return;
            }

            string senderEmail = "yourcompany@example.com";
            string senderPassword = "yourpassword";

            // Prevent accidental failed login attempts while placeholder details are still being used.
            if (senderEmail == "yourcompany@example.com" || senderPassword == "yourpassword")
            {
                MessageBox.Show("Bill generated, but email was not sent because email settings are still placeholders.");
                return;
            }

            string subject = "Your Water Bill";

            string contactName = string.IsNullOrWhiteSpace(business.ContactName)
                ? business.CompanyName
                : business.ContactName;

            string body =
                $"Hello {contactName},\n\n" +
                $"Your water bill has been generated.\n\n" +
                $"Company: {business.CompanyName}\n" +
                $"Bill ID: {bill.BusinessBillID}\n" +
                $"Bill Date: {bill.BillDate:dd MMM yyyy}\n" +
                $"Total Charges: £{bill.TotalCharges:F2}\n" +
                $"Total Discount: £{bill.TotalDiscount:F2}\n" +
                $"Subtotal: £{bill.SubTotal:F2}\n" +
                $"VAT: £{bill.VAT:F2}\n" +
                $"Final Amount: £{bill.BusinessFinalCost:F2}\n\n" +
                $"If you have any questions, please contact Scot-Water.\n\n" +
                $"Regards,\n" +
                $"Scot-Water Billing Team";

            try
            {
                using (MailMessage msg = new MailMessage())
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    msg.From = new MailAddress(senderEmail);
                    msg.To.Add(business.ContactEmail);
                    msg.Subject = subject;
                    msg.Body = body;

                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);

                    smtp.Send(msg);
                }

                MessageBox.Show("Bill emailed to client successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bill generated, but email failed to send.\n\nError: " + ex.Message);
            }
        }
    }
}