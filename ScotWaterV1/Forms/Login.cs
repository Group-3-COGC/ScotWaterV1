using ScotWaterV1.Core;
using ScotWaterV1.Models;
using ScotWaterV1.Services;
using System;
using System.Linq;
using System.Windows.Forms;

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

            var auth = new AuthService();

            // STAFF LOGIN
            if (auth.LoginStaff(username, password, out string staffError))
            {
                MessageBox.Show("Staff login successful!");

                frmMainMenu menu = new frmMainMenu();
                menu.Show();
                this.Hide();
                return;
            }

            // ADMIN LOGIN
            if (auth.LoginAdmin(username, password, out string adminError))
            {
                MessageBox.Show("Admin login successful!");

                frmMainMenu menu = new frmMainMenu();
                menu.Show();
                this.Hide();
                return;
            }

            // If both failed
            MessageBox.Show("Invalid username or password.");
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your username:",
                "Reset Password",
                "");

            if (string.IsNullOrWhiteSpace(username))
                return;

            using (var db = new BusinessDataContext())
            {
                var user = db.StaffUser
                    .FirstOrDefault(u => u.staffUsername == username);

                if (user == null)
                {
                    MessageBox.Show("User not found");
                    return;
                }

                // ASK FOR NEW PASSWORD
                string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter your new password:",
                    "New Password",
                    "");

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Password cannot be empty");
                    return;
                }

                // SAVE NEW PASSWORD (PBKDF2)
                user.staffPassword = PasswordSecurity.HashPassword(newPassword);
                db.SaveChanges();

                MessageBox.Show("Password updated successfully!");
            }
        }
    }
}
