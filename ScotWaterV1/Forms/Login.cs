using ScotWaterV1.Core;
using ScotWaterV1.Models;
using ScotWaterV1.Services;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
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

        private async Task HandleResetForUser(
    string username,
    string email,
    string currentCode,
    Action<string> setCode,
    Action<string> setPassword,
    BusinessDataContext db)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("No email assigned to this user");
                return;
            }

            string inputEmail = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your email:",
                "Email Verification",
                "");

            if (inputEmail.Trim().ToLower() != email.Trim().ToLower())
            {
                MessageBox.Show("Email does not match");
                return;
            }

            string code = new Random().Next(100000, 999999).ToString();
            setCode(code);
            db.SaveChanges();

            await SendResetEmail(email, code);

            MessageBox.Show("Code sent to email");

            string enteredCode = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter reset code:",
                "Verify Code",
                "");

            if (enteredCode != code)
            {
                MessageBox.Show("Invalid code");
                return;
            }

            string newPassword = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter new password:",
                "Reset Password",
                "");

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Password cannot be empty");
                return;
            }

            setPassword(PasswordSecurity.HashPassword(newPassword));
            setCode(null);

            db.SaveChanges();

            MessageBox.Show("Password reset successful!");
        }


        //Pasword reset functionality for users
        private async void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string username = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your username:",
                "Forgot Password",
                "");

            if (string.IsNullOrWhiteSpace(username))
                return;

            using (var db = new BusinessDataContext())
            {
                // TRY STAFF FIRST
                var staff = db.StaffUser.FirstOrDefault(u => u.staffUsername == username);

                if (staff != null)
                {
                    await HandleResetForUser(
                        staff.staffUsername,
                        staff.staffEmail,
                        staff.ResetCode,
                        code => staff.ResetCode = code,
                        password => staff.staffPassword = password,
                        db
                    );
                    return;
                }

                // TRY ADMIN
                var admin = db.AdminUsers.FirstOrDefault(u => u.AdminUsername == username);

                if (admin != null)
                {
                    await HandleResetForUser(
                        admin.AdminUsername,
                        admin.AdminEmail,
                        admin.ResetCode,
                        code => admin.ResetCode = code,
                        password => admin.AdminPassword = password,
                        db
                    );
                    return;
                }

                MessageBox.Show("User not found");
            }
        }

        private async Task SendResetEmail(string toEmail, string code)
        {
            string senderEmail = "scottwatertest@gmail.com";
            string senderPassword = "hyad gfyc dwqb iitn";

            using (MailMessage message = new MailMessage())
            {
                message.From = new MailAddress(senderEmail);
                message.To.Add(toEmail);
                message.Subject = "Password Reset Code";
                message.Body = $"Your reset code is: {code}";

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.EnableSsl = true;
                    smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    await smtp.SendMailAsync(message);
                }
            }
        }


    }
}
