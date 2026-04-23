using ScotWaterV1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScotWaterV1.Forms
{
    public partial class MeterReadings : Form
    {
        private readonly BusinessDataContext _context = new BusinessDataContext();

        public MeterReadings()
        {
            InitializeComponent();
        }





        // End of Save Method

        private void ClearFields()
        {
            txtCustomerNameMR.Clear();
            txtAccountNumberMR.Clear();
            txtBuisnessAddressMR.Clear();
            txtMeterNumberMR.Clear();
            txtCurrentReadingMR.Clear();
            txtPreviousReadingMR.Clear();
            txtStaffNameMR.Clear();
            txtAdditioanlNotesMR.Clear();
            txtWaterUsage_MR.Clear();
            txtRecycledWaterUsage_MR.Clear();
            txtUsageAmountMR.Clear();
            dateTimePicker1MR.Value = DateTime.Now;
        }

        private void btnM_R_MainMenu_Click(object sender, EventArgs e)
        {

        }

        private void MeterReadings_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnSaveMeterReading_Click(object sender, EventArgs e)
        {
            //Validation to check if all textboxes are filled
            if (string.IsNullOrWhiteSpace(txtCustomerNameMR.Text) ||
                string.IsNullOrWhiteSpace(txtAccountNumberMR.Text) ||
                string.IsNullOrWhiteSpace(txtBuisnessAddressMR.Text) ||
                string.IsNullOrWhiteSpace(txtMeterNumberMR.Text) ||
                string.IsNullOrWhiteSpace(txtCurrentReadingMR.Text) ||
                string.IsNullOrWhiteSpace(txtPreviousReadingMR.Text) ||
                string.IsNullOrWhiteSpace(txtStaffNameMR.Text))
            {
                MessageBox.Show("Please fill in all required fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Convert meter readings values from text to integers
                int currentReading = int.Parse(txtCurrentReadingMR.Text);
                int previousReading = int.Parse(txtPreviousReadingMR.Text);
                int freshwaterUnitsUsed = currentReading - previousReading;

                //Validation to check the water used is a positive amount
                if (freshwaterUnitsUsed < 0)
                {
                    MessageBox.Show("Current reading must be greater than or equal to previous reading.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Create a new WaterUsage object and populate it with data from the form
                var waterUsage = new WaterUsage
                {

                    FreshwaterUnitsUsed = int.Parse(txtWaterUsage_MR.Text),
                    RecycledUnits = int.Parse(txtRecycledWaterUsage_MR.Text),
                    ReadingDate = dateTimePicker1MR.Value,

                };

                //Save a new record to the database database
                _context.WaterUsage.Add(waterUsage);
                _context.SaveChanges();

                MessageBox.Show("Meter reading saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields after successful save
                ClearFields();
            }
            catch (FormatException)
            {
                //Validation to check for correct input type
                MessageBox.Show("Please enter valid numeric values for readings and usage.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
