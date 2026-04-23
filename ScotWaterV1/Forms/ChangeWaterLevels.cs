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

        // =========================
        // FORM LOAD
        // =========================
        private void frmChangeWaterLevels_Load(object sender, EventArgs e)
        {
            trkReserveLevel.Minimum = 0;
            trkReserveLevel.Maximum = 100;

            progressBarReserveLevel.Minimum = 0;
            progressBarReserveLevel.Maximum = 100;

            LoadLatestLevel();
        }

        // =========================
        // TRACKBAR LIVE UPDATE
        // =========================
        private void trkReserveLevel_Scroll(object sender, EventArgs e)
        {
            UpdateUI(trkReserveLevel.Value);
        }

        // =========================
        // UPDATE UI SAFELY
        // =========================
        private void UpdateUI(int value)
        {
            // clamp safety
            if (value < 0) value = 0;
            if (value > 100) value = 100;

            lblValue.Text = value + "%";
            progressBarReserveLevel.Value = value;
            trkReserveLevel.Value = value;

            if (value < 30)
            {
                lblWaterReserveStatus.Text = "LOW RESERVE";
                lblWaterReserveStatus.ForeColor = System.Drawing.Color.Red;
            }
            else if (value < 70)
            {
                lblWaterReserveStatus.Text = "MEDIUM RESERVE";
                lblWaterReserveStatus.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                lblWaterReserveStatus.Text = "STANDARD";
                lblWaterReserveStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        // =========================
        // SAVE BUTTON
        // =========================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BusinessDataContext())
                {
                    var usage = new WaterUsage
                    {
                        FreshwaterUnitsUsed = trkReserveLevel.Value,
                        RecycledUnits = 0,
                        ReadingDate = DateTime.Now,
                        IsLowReserve = trkReserveLevel.Value < 30,

                        // TEMP FIX (you should later replace with real selected business)
                        BusinessID = 1,
                        StaffUserID = 1
                    };

                    db.WaterUsage.Add(usage);
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

        // =========================
        // LOAD LAST SAVED VALUE
        // =========================
        private void LoadLatestLevel()
        {
            using (var db = new BusinessDataContext())
            {
                var latest = db.WaterUsage
                    .OrderByDescending(w => w.ReadingDate)
                    .FirstOrDefault();

                if (latest == null)
                {
                    UpdateUI(0);
                    return;
                }

                int value = latest.FreshwaterUnitsUsed;

                // SAFE CLAMP (THIS FIXES YOUR CRASH)
                if (value < 0) value = 0;
                if (value > 100) value = 100;

                UpdateUI(value);
            }
        }

        // =========================
        // MAIN MENU
        // =========================
       

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
    }
}