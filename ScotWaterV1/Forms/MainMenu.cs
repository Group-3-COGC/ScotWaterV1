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
            SetupTopBar();

            btnAddNewStaff.Visible = IsAdmin;
        }

        // =========================
        // UI SETUP (PRO STYLE)
        // =========================
        private void ApplyUI()
        {
            this.BackColor = Color.FromArgb(240, 242, 245);

            PanelMenu.BackColor = Color.FromArgb(33, 43, 54);
            panelMain.BackColor = Color.White;

            if (panelTop != null)
                panelTop.BackColor = Color.FromArgb(45, 45, 48);

            foreach (Control ctrl in PanelMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    btn.BackColor = Color.FromArgb(33, 43, 54);
                    btn.ForeColor = Color.White;

                    btn.Font = new Font("Segoe UI", 10);
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
        // TOP BAR (FIXED)
        // =========================
        private void SetupTopBar()
        {
            panelTop.Controls.Clear();

            // TITLE
            Label lblTitle = new Label();
            lblTitle.Text = "ScotWater System";
            lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 15);

            // USER
            Label lblUser = new Label();
            lblUser.Text = IsAdmin ? "Admin User" : "Staff User";
            lblUser.Font = new Font("Segoe UI", 10);
            lblUser.ForeColor = Color.White;
            lblUser.AutoSize = true;
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUser.Location = new Point(panelTop.Width - 220, 20);

            // LOGOUT BUTTON
            Button btnLogout = new Button();
            btnLogout.Text = "Sign Out";
            btnLogout.Size = new Size(90, 30);
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(panelTop.Width - 110, 15);

            btnLogout.BackColor = Color.FromArgb(200, 50, 50);
            btnLogout.ForeColor = Color.White;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;

            btnLogout.Click += (s, e) =>
            {
                new frmLogin().Show();
                this.Close();
            };

            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(lblUser);
            panelTop.Controls.Add(btnLogout);
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
        // BUTTON HIGHLIGHT
        // =========================
        private void MenuActive(object sender, EventArgs e)
        {
            if (currentButton != null)
                currentButton.BackColor = Color.FromArgb(33, 43, 54);

            currentButton = (Button)sender;
            currentButton.BackColor = Color.FromArgb(0, 122, 204);
        }

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
        // SIGN OUT (OLD BUTTON)
        // =========================
        private void btnMainMenuSignOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }

        private void BtnBill_Click_1(object sender, EventArgs e)
        {
            OpenForm(new frmGenerateBill());
        }
    }
}