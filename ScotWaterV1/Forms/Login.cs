using System;
using System.Windows.Forms;
using ScotWaterV1.Models;
using ScotWaterV1.Repositories;

namespace ScotWaterV1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        
            string AdminUsername = txtLoginUsername.Text.Trim();
            string AdminPassword = txtLoginPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(AdminUsername) || string.IsNullOrWhiteSpace(AdminPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Try Staff login
            StaffUserRepository staffRepo = new StaffUserRepository();
            StaffUser staff = staffRepo.Login(AdminUsername, AdminPassword);

            if (staff != null)
            {
                MessageBox.Show("Staff login successful!");
                frmMainMenu menu = new frmMainMenu(staff);
                menu.Show();
                this.Hide();
                return;
            }

            // Try Admin login
            AdminRepository adminRepo = new AdminRepository();
            AdminUsers admin = adminRepo.Login(AdminUsername, AdminPassword);

            if (admin != null)
            {
                MessageBox.Show("Admin login successful!");
                frmMainMenu menu = new frmMainMenu(admin);
                menu.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Invalid username or password.");
        }

    }
}
