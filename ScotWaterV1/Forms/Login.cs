using System;
using System.Linq;
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
            string email = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            // Try Staff login
            StaffUserRepository staffRepo = new StaffUserRepository();
            StaffUser staff = staffRepo.Login(username, password);

                if (adminUser != null)
                {
                    MessageBox.Show("Admin login successful");

                    frmMainMenu frmmainMenu = new frmMainMenu();
                    frmmainMenu.Show();
                    this.Hide();
                    return;
                }

            // Try Admin login
            AdminRepository adminRepo = new AdminRepository();
            AdminUsers admin = adminRepo.Login(username, password);

            }
        }

    }
}
