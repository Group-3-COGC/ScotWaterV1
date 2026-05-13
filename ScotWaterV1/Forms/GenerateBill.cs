using ScotWaterV1.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ScotWaterV1.Forms
{
    
   
    public partial class frmGenerateBill : Form
    {
        public frmGenerateBill()
        {
            InitializeComponent();
        }

        //Load the businesses onto the grid and load the grid itself.
        private void frmGenerateBill_Load(object sender, EventArgs e)
        {
            LoadBusinesses();
            LoadBusinessGrid();

            dtpBillDate.Value = DateTime.Now.Date;
        }

        //the method used to load businesses from database
        private void LoadBusinesses()
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

                
                cmbBusinessNames.DropDownStyle = ComboBoxStyle.DropDown;
                cmbBusinessNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbBusinessNames.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        //load the data grid view method
        private void LoadBusinessGrid()
        {
            using (var context = new BusinessDataContext())
            {
                dgvBusinessesBill.DataSource = context.BusinessUser
                    .OrderBy(b => b.CompanyName)
                    .Select(b => new
                    {
                        b.BusinessID,
                        b.CompanyName,
                        b.ContactEmail
                    })
                    .ToList();
            }


            dgvBusinessesBill.ReadOnly = true;
            dgvBusinessesBill.AllowUserToAddRows = false;
            dgvBusinessesBill.AllowUserToDeleteRows = false;
            dgvBusinessesBill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBusinessesBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //when the specific business is clicked, display their usages in the grid
        private void dgvBusinessesBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string name = dgvBusinessesBill.Rows[e.RowIndex]
                    .Cells["CompanyName"].Value.ToString();

                cmbBusinessNames.Text = name;
            }
        }

        //generate bill , Jack Smith 03/05/2026
        private async void btnGenerateBill_Click_1(object sender, EventArgs e)
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

                //grab the usages by filtering through the database looking for the specific business chosen
                var usage = context.WaterUsage
                    .FirstOrDefault(w =>
                        w.BusinessID == businessId &&
                        DbFunctions.TruncateTime(w.ReadingDate) == billDate);

                if (usage == null)
                {
                    MessageBox.Show("No water usage found for this business on the selected date.");
                    return;
                }

                //search through the database to check if a bill for that specific business already exists on that specific date
                var existingBill = context.BusinessBills
                    .FirstOrDefault(b =>
                        b.BusinessID == businessId &&
                        DbFunctions.TruncateTime(b.BillDate) == billDate);

                if (existingBill != null)
                {
                    MessageBox.Show("A bill already exists. Opening it.");
                    OpenBillInMainPanel(existingBill.BusinessBillID);
                    return;
                }

                //close this form and automaticcally move to display bill form and display the specific bill chosen
                var billingService = new BillingService();
                BusinessBills bill = billingService.GenerateBill(usage);

                bill.BusinessID = businessId;
                bill.BillDate = billDate;

                context.BusinessBills.Add(bill);
                context.SaveChanges();

                await SendBillEmail(bill, business);

                OpenBillInMainPanel(bill.BusinessBillID);
            }
        }

        //opens the generate bill form inside the panel of the main menu form
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

            MessageBox.Show("Bill generated, but could not open display page.");
        }

        //signs the user out and sends them back to the login screen
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmMainMenu mainMenu = this.ParentForm as frmMainMenu;

            if (mainMenu != null)
            {
                new frmLogin().Show();
                mainMenu.Close();
                return;
            }

            new frmLogin().Show();
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

            new frmMainMenu().Show();
            this.Close();
        }

        //once user clicks generate bill a confirmation email is automatically sent to the users livnked email
        private async Task SendBillEmail(BusinessBills bill, BusinessUser business)
        {
            if (business == null)
            {
                MessageBox.Show("Business not found.");
                return;
            }

            if (string.IsNullOrWhiteSpace(business.ContactEmail))
            {
                MessageBox.Show("No email found for business.");
                return;
            }

            string subject = "Your water bill";

            string contactName = string.IsNullOrWhiteSpace(business.ContactName)
                ? business.CompanyName : business.ContactName;

            string body =
                $"Hello {contactName}, \n\n" +
                $"Your water bill has been generated. \n\n" +
                $"Company: {business.CompanyName}\n" +
                $"Bill ID: {bill.BusinessBillID} \n" +
                $"Bill Date: {bill.BillDate:dd MMM yyyy}\n" +
                $"Total Charges: £{bill.TotalCharges:F2}\n" +
                $"Total Discount £{bill.TotalDiscount:F2}\n" +
                $"Subtotal: £{bill.SubTotal:F2}\n" +
                $"VAT: £{bill.VAT:F2}\n" +
                $"Final Amount: £{bill.BusinessFinalCost:F2}\n\n" +
                $"If you have any questions, please contact Scot-Water.\n\n" +
                $"Regards, \n" +
                $"Scot-Water Billing team";      

            //call the EmailService class
            try
            {
                EmailService emailservice = new EmailService();

                await emailservice.SendMailAsync(
                    business.ContactEmail,
                    subject,
                    body                   
                    );

                
                MessageBox.Show("Test email sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email failed" + ex.Message);
            }

        }
    }
}