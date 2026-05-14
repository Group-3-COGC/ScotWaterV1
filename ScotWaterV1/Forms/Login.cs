using ScotWaterV1.Core;
using ScotWaterV1.Models;
using ScotWaterV1.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1
{
    //Dean caldwell

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
         InitializeComponent();

         //This hides the password characters in the password textbox.
         txtLoginPassword.UseSystemPasswordChar = false;
         txtLoginPassword.PasswordChar = '*';

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            {
                string username = txtLoginUsername.Text.Trim();
                string password = txtLoginPassword.Text.Trim();

                // Validation to ensure both fields are filled in before attempting login.
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                var auth = new AuthService();

                // Try STAFF login first
                if (auth.LoginStaff(username, password, out string staffError))
                {
                    frmMainMenu menu = new frmMainMenu();
                    menu.IsAdmin = false;
                    menu.Show();
                    this.Hide();
                    return;
                }
                else if (staffError == "Incorrect username")
                {
                    // Username not found in staff — check admin next
                    if (auth.LoginAdmin(username, password, out string adminError))
                    {
                        frmMainMenu menu = new frmMainMenu();
                        menu.IsAdmin = true;
                        menu.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show(adminError); // Incorrect username or Incorrect password
                        return;
                    }
                }
                else
                {
                    // Staff username exists but password wrong
                    MessageBox.Show(staffError); // Incorrect password
                    return;
                }
            }
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

                //Asking for new password input.
                string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter your new password:",
                    "New Password",
                    "");

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    MessageBox.Show("Password cannot be empty");
                    return;
                }

                //Hashing password and saving to database.
                user.staffPassword = PasswordSecurity.HashPassword(newPassword);
                db.SaveChanges();

                MessageBox.Show("Password updated successfully!");
            }
        }

      
    }
}
