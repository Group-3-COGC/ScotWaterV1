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

        private Button currentButton;

        public frmMainMenu()
        {
            InitializeComponent();
            this.Load += frmMainMenu_Load;
        }

        // =========================
        // FORM LOAD
        // =========================
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            ApplyUI();

            btnAddNewStaff.Visible = IsAdmin;

            // Optional: show user role
            // lblUser.Text = IsAdmin ? "Admin" : "Staff";
        }

        // =========================
        // UI SETUP (PRO STYLE)
        // =========================
        private void ApplyUI()
        {
            // FORM BACKGROUND
            this.BackColor = Color.FromArgb(240, 242, 245);

            // SIDEBAR
            PanelMenu.BackColor = Color.FromArgb(33, 43, 54);

            // MAIN AREA
            panelMain.BackColor = Color.White;

            // TOP BAR (NEW)
            if (panelTop != null)
            {
                panelTop.BackColor = Color.FromArgb(45, 45, 48);
            }

            // STYLE BUTTONS
            foreach (Control ctrl in PanelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    btn.BackColor = Color.FromArgb(33, 43, 54);
                    btn.ForeColor = Color.White;

                    btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    btn.Height = 45;

                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Padding = new Padding(15, 0, 0, 0);

                    btn.Cursor = Cursors.Hand;

                    btn.MouseEnter += MenuHover;
                    btn.MouseLeave += MenuLeave;
                    btn.Click += MenuActive;
                }
            }
        }

        // =========================
        // LOAD FORM INTO PANEL
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
        // ACTIVE BUTTON (HIGHLIGHT)
        // =========================
        private void MenuActive(object sender, EventArgs e)
        {
            if (currentButton != null)
                currentButton.BackColor = Color.FromArgb(33, 43, 54);

            currentButton = (Button)sender;
            currentButton.BackColor = Color.FromArgb(0, 122, 204);
        }

        // =========================
        // HOVER EFFECT
        // =========================
        private void MenuHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(45, 60, 75);
        }

        private void MenuLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn != currentButton)
                btn.BackColor = Color.FromArgb(33, 43, 54);
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

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAddBusiness());
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            OpenForm(new frmGenerateBill());
        }

        private void BtnBill_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmGenerateBill());
        }

        private void BtnDsplayBill_Click(object sender, EventArgs e)
        {
            int someBillId = 1;
            OpenForm(new DisplayBill(someBillId));
        }

        // =========================
        // ADMIN ONLY
        // =========================
        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {
                MessageBox.Show("Only admin users can add new staff members");
                return;
            }

            OpenForm(new AddNewStaffMember());
        }

        // =========================
        // SIGN OUT
        // =========================
        private void btnMainMenuSignOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }

        private void btnChangeWaterLevel_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmChangeWaterLevels());
        }

        private void btnChangeWaterCharges_Click(object sender, EventArgs e)
        {
            OpenForm(new frmChangeWaterCharges());
        }
    }
}