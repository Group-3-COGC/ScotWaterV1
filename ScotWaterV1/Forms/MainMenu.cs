using ScotWaterV1.Forms;
using ScotWaterV1.Models;
using System;
using System.Windows.Forms;

namespace ScotWaterV1
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        public frmMainMenu(StaffUser user)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {user.staffUsername}";
        }

        public frmMainMenu(AdminUsers admin)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome Admin: {admin.AdminUsername}";
        }
    
        private void btnViewBusinesses_Click(object sender, EventArgs e)
        {
            ViewBusinesses businesses = new ViewBusinesses();
            businesses.Show();
            this.Hide();
        }

        private void btnWaterConsumption_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            frmGenerateBill Bill = new frmGenerateBill();
            Bill.Show();
            this.Hide();


        }

        private void btnModifyWaterPrice_Click(object sender, EventArgs e)
        {
            frmChangeWaterCharges Modify = new frmChangeWaterCharges();
            Modify.Show();
            this.Hide();
        }

        private void btnModifyWaterReserveLevels_Click(object sender, EventArgs e)
        {
            



        }
    }
}