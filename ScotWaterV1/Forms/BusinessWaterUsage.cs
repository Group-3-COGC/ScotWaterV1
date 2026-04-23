using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class BusinessWaterUsage : Form
    {
        public BusinessWaterUsage()
        {
            InitializeComponent();
            LoadBusinesses(); // load dropdown on start
        }

        // =========================
        // LOAD COMBOBOX (BUSINESSES)
        // =========================
        private void LoadBusinesses()
        {
            using (var db = new BusinessDataContext())
            {
                CmbBusiness.DataSource = db.BusinessUser.ToList();
                CmbBusiness.DisplayMember = "CompanyName";
                CmbBusiness.ValueMember = "BusinessID";
            }
        }

        // =========================
        // SHOW USAGE IN GRID
        // =========================
        private void LoadUsageForBusiness()
        {
            if (CmbBusiness.SelectedValue == null)
                return;

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            using (var db = new BusinessDataContext())
            {
                dgv_Business.DataSource = db.WaterUsage
                    .Where(w => w.BusinessID == businessId)
                    .Select(w => new
                    {
                        Business = w.BusinessUser.CompanyName,
                        Date = w.ReadingDate,
                        WaterUsed = w.FreshwaterUnitsUsed,
                        Recycled = w.RecycledUnits,
                        Status = w.IsLowReserve ? "LOW" : "OK"
                    })
                    .ToList();
            }
        }

        // =========================
        // SHOW BUTTON
        // =========================
        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadUsageForBusiness();
        }

        // =========================
        // ADD WATER USAGE
        // =========================
        private void btn_AddUsage_Click(object sender, EventArgs e)
        {
            if (CmbBusiness.SelectedValue == null)
            {
                MessageBox.Show("Please select a business");
                return;
            }

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            int used;
            int recycled;

            if (!int.TryParse(txt_Water_Used.Text, out used) ||
                !int.TryParse(txtRecycledWater.Text, out recycled))
            {
                MessageBox.Show("Enter valid numbers");
                return;
            }

            using (var db = new BusinessDataContext())
            {
                WaterUsage usage = new WaterUsage
                {
                    BusinessID = businessId,
                    StaffUserID = 1, // required for FK
                    FreshwaterUnitsUsed = used,
                    RecycledUnits = recycled,
                    ReadingDate = dtpDate.Value,
                    IsLowReserve = false
                };

                db.WaterUsage.Add(usage);
                db.SaveChanges();
            }

            MessageBox.Show("Usage saved successfully");

            // refresh grid
            LoadUsageForBusiness();

            // clear inputs
            txt_Water_Used.Clear();
            txtRecycledWater.Clear();
        }

        // =========================
        // SIGN OUT
        // =========================
        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Sign out and return to login?",
                "Confirm Signout",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // =========================
        // EMPTY EVENTS (SAFE)
        // =========================
        private void CmbBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            // optional - leave empty
        }

        private void BusinessWaterUsage_Load(object sender, EventArgs e)
        {
            // optional
        }
    }
}