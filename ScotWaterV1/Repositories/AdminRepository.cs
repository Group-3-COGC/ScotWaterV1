using System.Linq;
using System.Collections.Generic;
using ScotWaterV1.Models;

namespace ScotWaterV1.Repositories
{
    public class AdminRepository
    {
        private List<AdminUsers> admins = new List<AdminUsers>()
        {
            new AdminUsers { AdminID = 1, AdminUsername = "admin", AdminPassword = "1234" }
        };

        public AdminUsers Login(string username, string password)
        {
            return admins.FirstOrDefault(a =>
                a.AdminUsername.Equals(username, System.StringComparison.OrdinalIgnoreCase) &&
                a.AdminPassword == password);
        }
    }
}