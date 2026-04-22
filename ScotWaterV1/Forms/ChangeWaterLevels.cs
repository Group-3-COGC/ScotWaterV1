using ScotWaterV1.Models;
using System;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmChangeWaterLevels : Form
    {
        public frmChangeWaterLevels()
        {
            InitializeComponent();
            
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
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.Show();
            this.Hide();
        }

        private void progressBarReserveLevel_Click(object sender, EventArgs e)
        {
            progressBarReserveLevel.Value = trkReserveLevel.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WaterUsage usage = new WaterUsage();
            usage.FreshwaterUnitsUsed = trkReserveLevel.Value;

        }


        private void frmChangeWaterLevels_Load(object sender, EventArgs e)
        {

        }
    }
}
