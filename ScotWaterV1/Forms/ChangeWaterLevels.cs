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
    public partial class ChangeWaterLevels : Form
    {
        private StaffUser _currentUser;

        public ChangeWaterLevels(StaffUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }


        private void trkReserveLevel_Scroll(object sender, EventArgs e)
        {
            trkReserveLevel.Minimum = 0;
            trkReserveLevel.Maximum = 100;
        }

        private void ChangeWaterLevels_Load(object sender, EventArgs e)
        {
            trkReserveLevel.Minimum = 0;
            trkReserveLevel.Maximum = 100;


            //Determines what the Water Reserve Status Label displays.
            WaterUsage usage = new WaterUsage();
            bool isLowReserve = usage.IsLowReserve;

            if (isLowReserve)
            {
                lblWaterReserveStatus.Text = "LOW RESERVE";
            }
            else
            {
                lblWaterReserveStatus.Text = "STANDARD";
            }

        }

        //Navigation button back to Main Menu
        private void btnM_R_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu frmMainMenu = new frmMainMenu(_currentUser);
            frmMainMenu.Show();
            this.Hide();
        }

      

    }
}
