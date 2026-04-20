using ScotWaterV1.Forms;
using ScotWaterV1.Models;
using System;
using System.Windows.Forms;

namespace ScotWaterV1
{
    public partial class frmMainMenu : Form

    {
        // STAFF constructor
        public frmMainMenu(StaffUser user)

        {
            InitializeComponent();
           
        }

        // ADMIN constructor
        public frmMainMenu(AdminUsers admin)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome Admin: {admin.AdminUsername}";
        }
        private void btnViewBusinesses_Click(object sender, EventArgs e)
        {
            ViewBusinesses businesses = new ViewBusinesses();
            this.Show();
            this.Hide();
        }

        
    }
}