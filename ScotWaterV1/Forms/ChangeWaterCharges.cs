using ScotWaterV1.Models;
using System;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmChangeWaterCharges : Form
    {
        // 1. Variable moved here so it's accessible to the whole class
        private StaffUser _currentUser;

        // 2. Closed this constructor properly
        public frmChangeWaterCharges()
        {
            InitializeComponent();
        }

        // Update constructor to accept the user
        public frmChangeWaterCharges(StaffUser user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnChangeWaterCharges_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu(_currentUser);
            frmMainMenu.Show();
            this.Hide();
        }
    } 
} 
