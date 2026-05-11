using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class frmChangeWaterCharges : Form
    {
        public frmChangeWaterCharges()
        {
            InitializeComponent();
            this.Load += frmChangeWaterCharges_Load;
        }

        // =========================
        // PERSISTENT VALUES
        // =========================

        private double StandardLow = 0.41;
        private double StandardMedium = 0.64;
        private double StandardHigh = 1.35;

        private double ReserveLow = 0.47;
        private double ReserveMedium = 0.82;
        private double ReserveHigh = 2.25;

        private double RecycleLow = 0.05;
        private double RecycleMedium = 0.15;
        private double RecycleHigh = 0.25;

        // =========================
        // LOAD FORM
        // =========================
        private void frmChangeWaterCharges_Load(object sender, EventArgs e)
        {
            comboChangeCharges.Items.Clear();

            comboChangeCharges.Items.Add("Standard 0-40 Units");
            comboChangeCharges.Items.Add("Standard 41-80 Units");
            comboChangeCharges.Items.Add("Standard 81+ Units");

            comboChangeCharges.Items.Add("Reserve 0-40 Units");
            comboChangeCharges.Items.Add("Reserve 41-80 Units");
            comboChangeCharges.Items.Add("Reserve 81+ Units");

            comboChangeCharges.Items.Add("Recycle 0-5 Units");
            comboChangeCharges.Items.Add("Recycle 6-20 Units");
            comboChangeCharges.Items.Add("Recycle 21+ Units");

            comboChangeCharges.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadFromDatabase();
            RefreshLabels();
        }

        // =========================
        // UPDATE PRICE
        // =========================
        private void btnChangePrice_Click(object sender, EventArgs e)
        {
            if (comboChangeCharges.SelectedItem == null)
            {
                MessageBox.Show("Please select a charge type.");
                return;
            }

            if (!decimal.TryParse(txtNewPrice.Text, out decimal newPrice) || newPrice < 0)
            {
                MessageBox.Show("Enter a valid price.");
                return;
            }

            string selected = comboChangeCharges.SelectedItem.ToString();
            double price = (double)newPrice;

            // STANDARD
            if (selected == "Standard 0-40 Units")
                StandardLow = price;
            else if (selected == "Standard 41-80 Units")
                StandardMedium = price;
            else if (selected == "Standard 81+ Units")
                StandardHigh = price;

            // RESERVE
            else if (selected == "Reserve 0-40 Units")
                ReserveLow = price;
            else if (selected == "Reserve 41-80 Units")
                ReserveMedium = price;
            else if (selected == "Reserve 81+ Units")
                ReserveHigh = price;

            // RECYCLE
            else if (selected == "Recycle 0-5 Units")
                RecycleLow = price;
            else if (selected == "Recycle 6-20 Units")
                RecycleMedium = price;
            else if (selected == "Recycle 21+ Units")
                RecycleHigh = price;

            RefreshLabels();
            MessageBox.Show("Updated successfully.");
        }

        // =========================
        // SAVE TO DATABASE
        // =========================
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BusinessDataContext()) // ✅ FIXED
                {
                    Upsert(db, "Standard", "Low", (decimal)StandardLow);
                    Upsert(db, "Standard", "Medium", (decimal)StandardMedium);
                    Upsert(db, "Standard", "High", (decimal)StandardHigh);

                    Upsert(db, "Reserve", "Low", (decimal)ReserveLow);
                    Upsert(db, "Reserve", "Medium", (decimal)ReserveMedium);
                    Upsert(db, "Reserve", "High", (decimal)ReserveHigh);

                    Upsert(db, "Recycle", "Low", (decimal)RecycleLow);
                    Upsert(db, "Recycle", "Medium", (decimal)RecycleMedium);
                    Upsert(db, "Recycle", "High", (decimal)RecycleHigh);

                    db.SaveChanges();
                }

                MessageBox.Show("Saved to database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        // =========================
        // UPSERT (FIXED)
        // =========================
        private void Upsert(BusinessDataContext db, string category, string tier, decimal price)
        {
            var existing = db.WaterCharges
                .FirstOrDefault(x => x.Category == category && x.Tier == tier);

            if (existing == null)
            {
                db.WaterCharges.Add(new WaterCharge
                {
                    Category = category,
                    Tier = tier,
                    Price = price
                });
            }
            else
            {
                existing.Price = price;
            }
        }

        // =========================
        // LOAD FROM DATABASE
        // =========================
        private void LoadFromDatabase()
        {
            try
            {
                using (var db = new BusinessDataContext())
                {
                    foreach (var charge in db.WaterCharges.ToList())
                    {
                        double price = (double)charge.Price;

                        if (charge.Category == "Standard" && charge.Tier == "Low")
                            StandardLow = price;
                        else if (charge.Category == "Standard" && charge.Tier == "Medium")
                            StandardMedium = price;
                        else if (charge.Category == "Standard" && charge.Tier == "High")
                            StandardHigh = price;

                        else if (charge.Category == "Reserve" && charge.Tier == "Low")
                            ReserveLow = price;
                        else if (charge.Category == "Reserve" && charge.Tier == "Medium")
                            ReserveMedium = price;
                        else if (charge.Category == "Reserve" && charge.Tier == "High")
                            ReserveHigh = price;

                        else if (charge.Category == "Recycle" && charge.Tier == "Low")
                            RecycleLow = price;
                        else if (charge.Category == "Recycle" && charge.Tier == "Medium")
                            RecycleMedium = price;
                        else if (charge.Category == "Recycle" && charge.Tier == "High")
                            RecycleHigh = price;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message);
            }
        }

        // =========================
        // LABELS
        // =========================
        private void RefreshLabels()
        {
            lblLowUsagePrice.Text = $"Standard Low: £{StandardLow}";
            lblMediumUsagePrice.Text = $"Standard Medium: £{StandardMedium}";
            lblHighUsagePrice.Text = $"Standard High: £{StandardHigh}";

            lblDroughtLowUsagePrice.Text = $"Reserve Low: £{ReserveLow}";
            lblDroughtMediumUsagePrice.Text = $"Reserve Medium: £{ReserveMedium}";
            lblDroughtHighUsagePrice.Text = $"Reserve High: £{ReserveHigh}";

            lblRecycledLowDiscount.Text = $"Recycle Low: £{RecycleLow}";
            lblMediumRecyclePrice.Text = $"Recycle Medium: £{RecycleMedium}";
            lblHighRecyclePrice.Text = $"Recycle High: £{RecycleHigh}";
        }

        // =========================
        // NAVIGATION
        // =========================
        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void btnChangeWaterCharges_MainMenu_Click(object sender, EventArgs e)
        {
            new frmMainMenu().Show();
            this.Close();
        }

        private void lblRecycledLowDiscount_Click(object sender, EventArgs e)
        {

        }

        private void frmChangeWaterCharges_Load_1(object sender, EventArgs e)
        {

        }
    }
}