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
    public partial class frmAddBusiness : Form
    {
        private readonly BusinessDataContext _context = new BusinessDataContext();
        public frmAddBusiness()
        {
            InitializeComponent();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewBusiness_Click(object sender, EventArgs e)
        {
            try
            {
                var newBusiness = new BusinessUser
                {
                    BusinessID = int.Parse(txtBusinessID.Text),
                    CompanyName = txtBusinessName.Text,
                    Address1 = txtAddress1.Text,
                    Address2 = txtAddress2.Text,
                    City = txtCity.Text,
                    Postcode = txtPostcode.Text,
                    Region = cbxRegion.Text,
                    ContactName = txtContactName.Text,
                    ContactEmail = txtEmailAddress.Text,
                    ContactNumber = txtPhoneNumber.Text,
                    AccountName = txtAccountName.Text,
                    SortCode = txtSortCode.Text,
                    AccountNumber = txtAccountNumber.Text
                };

                _context.BusinessUser.Add(newBusiness);
                _context.SaveChanges();

                MessageBox.Show("Business saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving business: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtBusinessName.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtPostcode.Clear();
            cbxRegion.SelectedIndex = -1;
            txtContactName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();
            txtAccountName.Clear();
            txtSortCode.Clear();
            txtAccountNumber.Clear();
        }
    }
}
    

