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
    public partial class BusinessWaterUsage : Form
    {
        public BusinessWaterUsage()
        {
            InitializeComponent();
        }

        private void Businmess_Load(object sender, EventArgs e)
        {

        }

        private void btnChangeWaterCharges_SignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Signout and return to welcome screen?", "Confirm Signout").
    }
}
