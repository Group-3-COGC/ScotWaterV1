using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmChangeWaterLevels : Form
    {
        public frmChangeWaterLevels()
        {
            InitializeComponent();
        }

        //set a base value for the water levels
        private void frmChangeWaterLevels_Load(object sender, EventArgs e)
        {
            trkReserveLevel.Minimum = 0;
            trkReserveLevel.Maximum = 100;

            progressBarReserveLevel.Minimum = 0;
            progressBarReserveLevel.Maximum = 100;

            //load the latest updated water levels 
            LoadLatestLevel();
        }

       
        private void trkReserveLevel_Scroll(object sender, EventArgs e)
        {
            UpdateUI(trkReserveLevel.Value);
        }

        //update the UI dynamically so that depending on the level it will display LOW RESERVE or STANDARD
        private void UpdateUI(int value)
        {
            
            if (value < 0) value = 0;
            if (value > 100) value = 100;

            lblValue.Text = value + "%";
            progressBarReserveLevel.Value = value;
            trkReserveLevel.Value = value;

            if (value < 25)
            {
                lblWaterReserveStatus.Text = "LOW RESERVE";
                lblWaterReserveStatus.ForeColor = System.Drawing.Color.Red;
            }
           
            else
            {
                lblWaterReserveStatus.Text = "STANDARD";
                lblWaterReserveStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

      //saves 
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BusinessDataContext())
                {
                    var reserve = db.ReserveConfigs.FirstOrDefault();


                    if (reserve == null)
                    {
                        reserve = new ReserveConfig();
                        db.ReserveConfigs.Add(reserve);

                    }
                    reserve.CurrentReservePercentage = trkReserveLevel.Value;
                    db.SaveChanges();
                }

                MessageBox.Show("Water level saved!");

                LoadLatestLevel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        //search through the reserve configs to display the level than was selected by the staff member
        private void LoadLatestLevel()
        {
            using (var db = new BusinessDataContext())
            {
                var reserve = db.ReserveConfigs.FirstOrDefault();

                if (reserve == null)
                {
                    UpdateUI(80);
                    return;
                }

                int value = (int)reserve.CurrentReservePercentage;

                if (value < 0) value = 0;
                if (value > 100) value = 100;

                UpdateUI(value);
            }
        }
       
        private void btnSignOut_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu();
            menu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}