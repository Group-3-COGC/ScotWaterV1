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
            LoadBusinesses();
        }

        // =========================
        // LOAD COMBOBOX
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
        // SHOW BUSINESS DETAILS
        // =========================
        private void btn_ShowDetails_Click(object sender, EventArgs e)
        {
            if (CmbBusiness.SelectedValue == null) return;

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            using (var db = new BusinessDataContext())
            {
                dgv_Business.DataSource = db.BusinessUser
                    .Where(b => b.BusinessID == businessId)
                    .Select(b => new
                    {
                        b.BusinessID,
                        b.CompanyName,
                        b.Address1,
                        b.Address2,
                        b.City,
                        b.Postcode,
                        b.ContactName,
                        b.ContactNumber,
                        b.ContactEmail,
                        b.AccountName
                    })
                    .ToList();
            }
        }

        // =========================
        // SHOW WATER USAGE
        // =========================
        private void btn_ShowUsage_Click(object sender, EventArgs e)
        {
            if (CmbBusiness.SelectedValue == null)
            {
                MessageBox.Show("Select a business first");
                return;
            }

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
        // ADD USAGE (SAVE TO DB)
        // =========================
        private void btn_AddUsage_Click(object sender, EventArgs e)
        {
            if (CmbBusiness.SelectedValue == null)
            {
                MessageBox.Show("Please select a business");
                return;
            }

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            if (!int.TryParse(txt_Water_Used.Text, out int used) ||
                !int.TryParse(txtRecycledWater.Text, out int recycled))
            {
                MessageBox.Show("Enter valid numbers");
                return;
            }

            try
            {
                using (var db = new BusinessDataContext())
                {
                    var usage = new WaterUsage
                    {
                        BusinessID = businessId,
                        StaffUserID = 1, // IMPORTANT: must exist in StaffUsers table
                        FreshwaterUnitsUsed = used,
                        RecycledUnits = recycled,
                        ReadingDate = dtpDate.Value,
                        IsLowReserve = used < 30
                    };

                    db.WaterUsage.Add(usage);
                    db.SaveChanges();
                }

                MessageBox.Show("Usage saved successfully!");

                // refresh grid immediately
                btn_ShowUsage_Click(null, null);

                // clear inputs
                txt_Water_Used.Clear();
                txtRecycledWater.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SAVE FAILED: " + ex.Message);
            }
        }

        // =========================
        // OPTIONAL AUTO REFRESH
        // =========================
        private void CmbBusiness_SelectedIndexChanged(object sender, EventArgs e)
        {
            // optional:
            // btn_ShowUsage_Click(null, null);
        }

        // =========================
        // SIGN OUT
        // =========================
        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}