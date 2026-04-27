using ScotWaterV1.Models;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace ScotWaterV1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            Database.SetInitializer(new BusinessDatabaseInitialiser());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
