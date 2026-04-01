using ScotWaterV1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string username = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            StaffUserRepository repo = new StaffUserRepository();
            StaffUser user = repo.Login(username, password);

            if (user != null)
            {
                MessageBox.Show("Login successful!");

                // Open dashboard and pass logged-in user
                StaffDashboard dashboard = new StaffDashboard(user);
                dashboard.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
    }
}
