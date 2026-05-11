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
        // WATER CHARGE VALUES
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

            // STANDARD
            comboChangeCharges.Items.Add("Standard 0-40 Units");
            comboChangeCharges.Items.Add("Standard 41-80 Units");
            comboChangeCharges.Items.Add("Standard 81+ Units");

            // RESERVE
            comboChangeCharges.Items.Add("Reserve 0-40 Units");
            comboChangeCharges.Items.Add("Reserve 41-80 Units");
            comboChangeCharges.Items.Add("Reserve 81+ Units");

            // RECYCLE
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

            if (!decimal.TryParse(txtNewPrice.Text, out decimal newPrice)
                || newPrice < 0
                || newPrice > 40)
            {
                MessageBox.Show("Enter a valid price between 0 and 40.");
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

            MessageBox.Show("Price updated successfully.");
        }

        // =========================
        // SAVE TO DATABASE
        // =========================

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new BusinessDataContext())
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

                MessageBox.Show("Water charges saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        // =========================
        // UPSERT DATABASE RECORD
        // =========================

        private void Upsert(BusinessDataContext db,
                            string category,
                            string tier,
                            decimal price)
        {
            var existing = db.WaterCharges
                .FirstOrDefault(x =>
                    x.Category == category &&
                    x.Tier == tier);

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
                    var charges = db.WaterCharges.ToList();

                    foreach (var charge in charges)
                    {
                        double price = (double)charge.Price;

                        // STANDARD
                        if (charge.Category == "Standard" && charge.Tier == "Low")
                            StandardLow = price;

                        else if (charge.Category == "Standard" && charge.Tier == "Medium")
                            StandardMedium = price;

                        else if (charge.Category == "Standard" && charge.Tier == "High")
                            StandardHigh = price;

                        // RESERVE
                        else if (charge.Category == "Reserve" && charge.Tier == "Low")
                            ReserveLow = price;

                        else if (charge.Category == "Reserve" && charge.Tier == "Medium")
                            ReserveMedium = price;

                        else if (charge.Category == "Reserve" && charge.Tier == "High")
                            ReserveHigh = price;

                        // RECYCLE
                        else if (charge.Category == "Recycle" && charge.Tier == "Low")
                            RecycleLow = price;

                        else if (charge.Category == "Recycle" && charge.Tier == "Medium")
                            RecycleMedium = price;

                        else if (charge.Category == "Recycle" && charge.Tier == "High")
                            RecycleHigh = price;
                    }
                }
            }
            catch
            {
                // ignore empty table errors
            }
        }

        // =========================
        // REFRESH LABELS
        // =========================

        private void RefreshLabels()
        {
            // STANDARD
            lblLowUsagePrice.Text =
                $"0-40 Units : £{StandardLow:F2}";

            lblMediumUsagePrice.Text =
                $"41-80 Units : £{StandardMedium:F2}";

            lblHighUsagePrice.Text =
                $"81+ Units : £{StandardHigh:F2}";

            // RESERVE
            lblDroughtLowUsagePrice.Text =
                $"0-40 Units : £{ReserveLow:F2}";

            lblDroughtMediumUsagePrice.Text =
                $"41-80 Units : £{ReserveMedium:F2}";

            lblDroughtHighUsagePrice.Text =
                $"81+ Units : £{ReserveHigh:F2}";

            // RECYCLE
            lblRecycledLowDiscount.Text =
                $"0-5 Units : £{RecycleLow:F2}";

            lblMediumRecyclePrice.Text =
                $"6-20 Units : £{RecycleMedium:F2}";

            lblHighRecyclePrice.Text =
                $"21+ Units : £{RecycleHigh:F2}";
        }

        // =========================
        // NAVIGATION
        // =========================

        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?",
                "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnChangeWaterCharges_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void lblRecycledLowDiscount_Click(object sender, EventArgs e)
        {

        }
    }
}