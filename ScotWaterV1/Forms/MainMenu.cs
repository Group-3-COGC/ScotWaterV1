using ScotWaterV1.Forms;
using ScotWaterV1.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScotWaterV1
{
    
    public partial class frmMainMenu : Form
    {
        public bool IsAdmin { get; set; }

        public frmMainMenu()
        {
            InitializeComponent();
        }

        // =========================
        // LOAD FORM INTO MAIN PANEL
        // =========================
        private void OpenForm(Form form)
        {
            panelMain.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelMain.Controls.Add(form);
            form.Show();
        }

        // =========================
        // BUTTON EVENTS
        // =========================

        private void btnViewBusinesses_Click(object sender, EventArgs e)
        {
            OpenForm(new ViewBusinesses());
        }

        private void btnWaterConsumption_Click(object sender, EventArgs e)
        {
            OpenForm(new BusinessWaterUsage());
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            OpenForm(new frmGenerateBill());
        }

        private void btnModifyWaterPrice_Click(object sender, EventArgs e)
        {
            OpenForm(new frmChangeWaterCharges());
        }

        private void btnChangeWaterLevel_Click(object sender, EventArgs e)
        {
            OpenForm(new frmChangeWaterLevels());
        }

        private void btnChangeWaterCharges_Click(object sender, EventArgs e)
        {
            OpenForm(new frmChangeWaterCharges());
        }

        

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAddBusiness());
        }
        
        

        private void BtnBill_Click(object sender, EventArgs e)
        {
            OpenForm(new frmGenerateBill());
        }

        

        private void BtnMeter_Click(object sender, EventArgs e)
        {
            OpenForm(new MeterReadings());
        }

        private void btnMeterReadings_Click(object sender, EventArgs e)
        {
            OpenForm(new MeterReadings());
        }

        // =========================
        // SIGN OUT
        // =========================
        private void btnMainMenuSignOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }

        // =========================
        // FORM LOAD
        // =========================
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            btnAddNewStaff.Visible = IsAdmin;
            StyleMenuButtons();
        }

        // =========================
        // STYLE MENU BUTTONS
        // =========================
        private void StyleMenuButtons()
        {
            foreach (Control ctrl in PanelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.FromArgb(30, 42, 56);
                    btn.ForeColor = Color.White;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(10);

                    btn.MouseEnter += MenuHover;
                    btn.MouseLeave += MenuLeave;
                }
            }
        }

        // =========================
        // HOVER EFFECT
        // =========================
        private void MenuHover(object sender, EventArgs e)
        {
            frmAddBusiness NewBusiness = new frmAddBusiness();
            NewBusiness.Show();
            this.Hide();
        }

        private void MenuLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(30, 42, 56);
        }

        private void btnAddNewStaffMember_Click(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {
                MessageBox.Show("Only admin users can add new staff members");
                return;
            }

            OpenForm(new AddNewStaffMember());
        }

        private void btnChangeWaterLevel_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmChangeWaterLevels());
        }

        private void BtnMeter_Click_1(object sender, EventArgs e)
        {
            OpenForm(new MeterReadings());
        }

        private void BtnBill_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmGenerateBill());
        }

        private void btnChangeWaterCharges_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmChangeWaterCharges());
        }

        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            OpenForm(new AddNewStaffMember());
        }

        private void BtnDsplayBill_Click(object sender, EventArgs e)
        {
            
            int someBillId = 1; 
            OpenForm(new DisplayBill(someBillId));
        }
    }
}