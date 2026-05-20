using ScotWaterV1.Models;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class BusinessWaterUsage : Form
    {
        //
        private readonly Color mainBlue = Color.FromArgb(0, 102, 204);
        
        public BusinessWaterUsage()
        {
            InitializeComponent();
            ApplyUIStyle();
            LoadBusinesses();
        }

        //private method for UI styles
        private void ApplyUIStyle()
        {
            this.BackColor = Color.WhiteSmoke;

            StyleButton(btn_Show);
            StyleButton(btnShowUsage);
            StyleButton(btnAddUsage);
            StyleButton(btn_DeleteUsage);
            
            

            dgv_Business.BorderStyle = BorderStyle.FixedSingle;
            dgv_Business.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv_Business.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_Business.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        //private method for button styles
        private void StyleButton(Button btn)
        {
            if (btn == null) return;

            btn.BackColor = mainBlue;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        //load businesses method

        private void LoadBusinesses()
        {
            //grabs the database and then displays the chosen data on the combo box
            using (var db = new BusinessDataContext())
            {
                CmbBusiness.DataSource = db.BusinessUser.ToList();
                CmbBusiness.DisplayMember = "CompanyName";
                CmbBusiness.ValueMember = "BusinessID";
            }
        }

        //on event click for showing details
        private void btn_ShowDetails_Click(object sender, EventArgs e)
        {
            //firstly check if the selected value does not exist and prevent it from passing 
            if (CmbBusiness.SelectedValue == null) return;

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);

            //grab data base then filter through and then apply the generated business ID to that speciic business
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
        //on event click for showing usage
        private void btn_ShowUsage_Click(object sender, EventArgs e)
        {
            //firstly CHECK if selected business in combo box does not exist
            if (CmbBusiness.SelectedValue == null)
            {
                MessageBox.Show("Select a business first");
                return;
            }

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);
            //grab database and also take the water usage entered, then filter through database and apply that specific water usage to that specific business
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
        //on event click for adding usage
        private void btn_AddUsage_Click(object sender, EventArgs e)
        {
            //check if business is selected
            if (CmbBusiness.SelectedValue == null)
            {
                MessageBox.Show("Please select a business");
                return;
            }

            int businessId = Convert.ToInt32(CmbBusiness.SelectedValue);
            //validate entered data 
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
                //grab database
                using (var db = new BusinessDataContext())
                {
                    //check reserve config to check if its available
                    var reserve = db.ReserveConfigs.FirstOrDefault();
                    if (reserve == null)
                    {
                        MessageBox.Show("Reserve level not configured.");
                        return;
                    }

                    bool isLowReserve = reserve.CurrentReservePercentage < 25;

                    int staffId = Session.StaffUserID;
                    if (staffId == 0) staffId = 1;

                    //create new table waterusage object so that it can load new data into it
                    var usage = new WaterUsage
                    {
                        BusinessID = businessId,
                        StaffUserID = staffId,
                        FreshwaterUnitsUsed = used,
                        RecycledUnits = recycled,
                        ReadingDate = dtpDate.Value,
                        IsLowReserve = isLowReserve
                    };

                    //check if that specific waterusage for that date and business already exists and prevent it from saving 
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