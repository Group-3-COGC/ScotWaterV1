using ScotWaterV1.Models;
using System;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmChangeWaterLevels : Form
    {






        // SIGN OUT
        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        // MAIN MENU
        private void btnChangeWaterCharges_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }
    }
}