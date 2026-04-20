using ScotWaterV1.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ScotWaterV1.Forms
{
    public partial class ViewBusinesses : Form
    {
        private StaffUser _currentUser;

        // Constructor (default)
        public ViewBusinesses()
        {
            InitializeComponent();
        }

        // Constructor with logged-in user
        public ViewBusinesses(StaffUser currentUser) : this()
        {
            _currentUser = currentUser;
        }

        // =========================
        // LOAD BUSINESSES
        // =========================
        private void LoadBusinesses()
        {
            using (var db = new BusinessDataContext())
            {
                dgvBusinesses.DataSource = db.BusinessUser.ToList();
            }

            dgvBusinesses.Columns["BusinessID"].Visible = false; // optional cleanup
        }

        // =========================
        // FORM LOAD
        // =========================
        private void ViewBusinesses_Load(object sender, EventArgs e)
        {
            dgvBusinesses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBusinesses.MultiSelect = false;
            dgvBusinesses.ReadOnly = true;

            LoadBusinesses();
        }

        // =========================
        // SEARCH BUTTON
        // =========================
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new BusinessDataContext())
            {
                string search = txtSearch.Text.ToLower();

                var result = db.BusinessUser
                    .Where(b =>
                        b.CompanyName.ToLower().Contains(search) ||
                        b.Postcode.ToLower().Contains(search) ||
                        b.ContactEmail.ToLower().Contains(search))
                    .ToList();

                dgvBusinesses.DataSource = result;
            }
        }

        // =========================
        // RESET / SHOW ALL (optional)
        // =========================
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LoadBusinesses();
        }

        // =========================
        // EDIT BUTTON
        // =========================
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBusinesses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a business.");
                return;
            }

            int id = (int)dgvBusinesses.SelectedRows[0].Cells["BusinessID"].Value;

            using (var db = new BusinessDataContext())
            {
                var business = db.BusinessUser.Find(id);

                if (business == null)
                {
                    MessageBox.Show("Business not found.");
                    return;
                }

                business.CompanyName = Microsoft.VisualBasic.Interaction.InputBox(
                    "Edit Company Name:", "Edit Business", business.CompanyName);

                business.Postcode = Microsoft.VisualBasic.Interaction.InputBox(
                    "Edit Postcode:", "Edit Business", business.Postcode);

                business.ContactEmail = Microsoft.VisualBasic.Interaction.InputBox(
                    "Edit Email:", "Edit Business", business.ContactEmail);

                db.SaveChanges();
            }

            LoadBusinesses();
        }

        // =========================
        // SIGN OUT
        // =========================
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        // =========================
        // MAIN MENU
        // =========================
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu menu = new frmMainMenu(_currentUser);
            menu.Show();
            this.Hide();
        }

        private void dgvBusinesses_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}