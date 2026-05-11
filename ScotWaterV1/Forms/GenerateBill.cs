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

        // ================= LOAD =================
        private void frmGenerateBill_Load(object sender, EventArgs e)
        {
            LoadBusinesses();
            LoadBusinessGrid();

            dtpBillDate.Value = DateTime.Now.Date;
        }

        // ================= LOAD COMBOBOX =================
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

                // ✅ AUTOCOMPLETE FIX
                cmbBusinessNames.DropDownStyle = ComboBoxStyle.DropDown;
                cmbBusinessNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbBusinessNames.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        // ================= LOAD GRID =================
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

        // ================= GRID CLICK =================
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
                    MessageBox.Show("A bill already exists. Opening it.");
                    OpenBillInMainPanel(existingBill.BusinessBillID);
                    return;
                }

                var billingService = new BillingService();
                BusinessBills bill = billingService.GenerateBill(usage);

                bill.BusinessID = businessId;
                bill.BillDate = billDate;

                context.BusinessBills.Add(bill);
                context.SaveChanges();

                SendBillEmail(bill, business);

                OpenBillInMainPanel(bill.BusinessBillID);
            }
        }

        // ================= OPEN BILL =================
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

        // ================= SIGN OUT =================
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

        // ================= MAIN MENU =================
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

        // ================= EMAIL =================
        private void SendBillEmail(BusinessBills bill, BusinessUser business)
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

        }
    }
}