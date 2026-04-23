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
            txtLoginPassword.UseSystemPasswordChar = true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // STAFF LOGIN
            StaffUserRepository staffRepo = new StaffUserRepository();
            StaffUser staff = staffRepo.Login(username, password);

            if (staff != null)
            {
                MessageBox.Show("Staff login successful!");
                frmMainMenu menu = new frmMainMenu();
                menu.Show();
                this.Hide();
                return;
            }

            // ADMIN LOGIN
            AdminRepository adminRepo = new AdminRepository();
            AdminUsers admin = adminRepo.Login(username, password);

            if (admin != null)
            {
                MessageBox.Show("Admin login successful!");
                frmMainMenu menu = new frmMainMenu();
                menu.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Invalid username or password.");
        }

       
    }
}
