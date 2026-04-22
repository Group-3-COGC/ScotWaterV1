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
    public partial class frmGenerateBill : Form
    {
       
        public frmGenerateBill()
        {
            InitializeComponent();
        }
       
        private void btnG_B_SignOut_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnG_B_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
            this.Hide();
        }
    }
}
