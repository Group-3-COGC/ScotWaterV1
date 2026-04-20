using System;
using System.Windows.Forms;
using ScotWaterV1.Models;

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
            
        }

        private void btnWaterConsumption_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyWaterPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnModifyWaterReserveLevels_Click(object sender, EventArgs e)
        {

        }
    }
}