using System;
using System.Windows.Forms;
using ScotWaterV1.Models;

namespace ScotWaterV1
{
    public partial class frmMainMenu : Form
    {
        // STAFF constructor
        public frmMainMenu(StaffUser user)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {user.Username}";
        }

        // ADMIN constructor
        public frmMainMenu(AdminUsers admin)
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome Admin: {admin.AdminUsername}";
        }
    }
}