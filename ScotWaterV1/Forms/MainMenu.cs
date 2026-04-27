using ScotWaterV1.Forms;
using ScotWaterV1.Models;
using System;
using System.Windows.Forms;

namespace ScotWaterV1
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnViewBusinesses_Click(object sender, EventArgs e)
        {
            ViewBusinesses businesses = new ViewBusinesses();
            businesses.Show();
            this.Hide();
        }

        private void btnWaterConsumption_Click(object sender, EventArgs e)
        {
            BusinessWaterUsage businessWaterUsage = new BusinessWaterUsage();
            businessWaterUsage.Show();
            this.Hide();
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            frmGenerateBill Bill = new frmGenerateBill();
            Bill.Show();
            this.Hide();


        }

        private void btnModifyWaterPrice_Click(object sender, EventArgs e)
        {
            frmChangeWaterCharges Modify = new frmChangeWaterCharges();
            Modify.Show();
            this.Hide();
        }

        private void btnModifyWaterReserveLevels_Click(object sender, EventArgs e)
        {
            frmChangeWaterLevels form = new frmChangeWaterLevels();
            form.Show();
            this.Hide();




        }

        private void btnMeterReadings_Click(object sender, EventArgs e)
        {
            MeterReadings Meter = new MeterReadings();
            Meter.Show();
            this.Hide();
        }

        private void btnAddBusiness_Click(object sender, EventArgs e)
        {
            frmAddBusiness NewBusiness = new frmAddBusiness();
            NewBusiness.Show();
            this.Hide();
        }

        private void btnMainMenuSignOut_Click(object sender, EventArgs e)
        {
            frmLogin SignOut = new frmLogin();
            SignOut.Show();
            this.Close();
        }
        
    }
}