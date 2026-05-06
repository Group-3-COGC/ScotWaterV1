using ScotWaterV1.Models;
using System;
using System.Data.Entity;
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

        private void LoadBusinesses()
        {
            using (var db = new BusinessDataContext())
            {
                CmbBusiness.DataSource = db.BusinessUser.ToList();
                CmbBusiness.DisplayMember = "CompanyName";
                CmbBusiness.ValueMember = "BusinessID";
            }
        }

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
                        w.WaterUsageID,
                        Business = w.BusinessUser.CompanyName,
                        Date = w.ReadingDate,
                        WaterUsed = w.FreshwaterUnitsUsed,
                        Recycled = w.RecycledUnits,
                        Status = w.IsLowReserve ? "LOW" : "OK"
                    })
                    .ToList();
            }

            if (dgv_Business.Columns.Contains("WaterUsageID"))
                dgv_Business.Columns["WaterUsageID"].Visible = false;
        }

        private void btn_AddUsage_Click(object sender, EventArgs e)
        {
            if (CmbBusiness.SelectedValue == null)
            {
                MessageBox.Show("Please select a business");
                return;
            }

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            if (!int.TryParse(txt_Water_Used.Text, out int used) || used < 0)
            {
                MessageBox.Show("Freshwater units must be valid.");
                return;
            }

            if (!int.TryParse(txtRecycledWater.Text, out int recycled) || recycled < 0)
            {
                MessageBox.Show("Recycled units must be valid.");
                return;
            }

            if (recycled > used)
            {
                MessageBox.Show("Recycled units cannot exceed freshwater units.");
                return;
            }

            try
            {
                using (var db = new BusinessDataContext())
                {                  
                    var reserve = db.ReserveConfigs.FirstOrDefault();
                    if (reserve == null)
                    {
                        MessageBox.Show("Reserve level not configured.");
                        return;
                    }

                    bool isLowReserve = reserve.CurrentReservePercentage < 25;

                    int staffId = Session.StaffUserID;
                    if (staffId == 0)
                        staffId = 1;

                    var usage = new WaterUsage
                    {
                        BusinessID = businessId,
                        StaffUserID = staffId,
                        FreshwaterUnitsUsed = used,
                        RecycledUnits = recycled,
                        ReadingDate = dtpDate.Value,
                        IsLowReserve = isLowReserve
                    };

                    bool exists = db.WaterUsage.Any(u =>
                        u.BusinessID == businessId &&
                        DbFunctions.TruncateTime(u.ReadingDate) == dtpDate.Value.Date);

                    if (exists)
                    {
                        MessageBox.Show("Usage already exists for this date.");
                        return;
                    }

                    db.WaterUsage.Add(usage);
                    db.SaveChanges();
                }

                MessageBox.Show("Usage saved successfully.");
                btn_ShowUsage_Click(null, null);
                txt_Water_Used.Clear();
                txtRecycledWater.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SAVE FAILED: " + ex.Message);
            }
        }

        private void btn_DeleteUsage_Click(object sender, EventArgs e)
        {
            if (dgv_Business.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a usage entry to delete.");
                return;
            }

            int usageId = Convert.ToInt32(
                dgv_Business.SelectedRows[0].Cells["WaterUsageID"].Value
            );

            if (MessageBox.Show("Delete this usage entry?",
                "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }

            using (var db = new BusinessDataContext())
            {
                var usage = db.WaterUsage.FirstOrDefault(u => u.WaterUsageID == usageId);
                if (usage == null)
                {
                    MessageBox.Show("Usage entry not found.");
                    return;
                }

                db.WaterUsage.Remove(usage);
                db.SaveChanges();
            }

            MessageBox.Show("Usage deleted.");
            btn_ShowUsage_Click(null, null);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu main = new frmMainMenu();
            main.Show();
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
