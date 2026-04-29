using ScotWaterV1.Forms;
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
        // UI SETUP
        // =========================
        private void ApplyUI()
        {
            this.BackColor = Color.FromArgb(240, 242, 245);

            PanelMenu.BackColor = Color.FromArgb(33, 43, 54);
            panelMain.BackColor = Color.White;

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
                    btn.Width = PanelMenu.Width;

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
        // TOP BAR (SAFE VERSION)
        // =========================
        private void SetupTopBar()
        {
            panelTop.Controls.Clear();
            panelTop.BackColor = Color.FromArgb(45, 45, 48);

            Label lblTitle = new Label
            {
                Text = "ScotWater System",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 15)
            };

            Label lblUser = new Label
            {
                Text = IsAdmin ? "Admin User" : "Staff User",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(300, 18)
            };

            Button btnLogout = new Button
            {
                Text = "Sign Out",
                Size = new Size(90, 30),
                Location = new Point(200, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                BackColor = Color.FromArgb(200, 50, 50),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

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
        // MENU UI EFFECTS
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
            OpenForm(new DisplayBill(1));
        }

        private void btnAddNewStaff_Click(object sender, EventArgs e)
        {
            if (!IsAdmin)
            {
                MessageBox.Show("Only admin users can add new staff members");
                return;
            }

            OpenForm(new AddNewStaffMember());
        }

        private void btnMainMenuSignOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }
    }
}