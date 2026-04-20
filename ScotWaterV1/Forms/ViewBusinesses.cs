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

namespace ScotWaterV1.Forms
{
    public partial class ViewBusinesses : Form
    {
        // 1. Variable moved here so it's accessible to the whole class
        private StaffUser _currentUser;

        public ViewBusinesses()
        {
            InitializeComponent();
        }
        public ViewBusinesses(StaffUser currentUser) : this() // Call the default constructor to initialize components
        {
            _currentUser = currentUser; // Store the passed user in the class variable
        }

        private void btnViewBusiness_SignOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnV_B_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu(_currentUser);
            frmMainMenu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
