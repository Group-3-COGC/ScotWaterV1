using System;
using System.Windows.Forms;
using ScotWaterV1.Models;

namespace ScotWaterV1
{
    public partial class StaffDashboard : Form
    {
        private StaffUser _loggedInUser;

        public StaffDashboard(StaffUser user)
        {
            InitializeComponent();
            _loggedInUser = user;

            // Display the username on the dashboard
            lblWelcome.Text = $"Welcome, {_loggedInUser.Username}";
        }
    }
}