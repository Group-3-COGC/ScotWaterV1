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
            string email = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text.Trim();

            using (var context = new BusinessDataContext())
            {
                //check admin
                var adminUser = context.AdminUsers
                    .FirstOrDefault(a => a.AdminUsername == email && a.AdminPassword == password);

                if (adminUser != null)
                {
                    MessageBox.Show("Admin login successful");

                    frmMainMenu frmmainMenu = new frmMainMenu();
                    frmmainMenu.Show();
                    this.Hide();
                    return;
                }


            }
        }
    }
}