using System.Linq;
using System.Collections.Generic;
using ScotWaterV1.Models;

namespace ScotWaterV1.Repositories
{
    public class AdminRepository
    {
        public AdminUsers Login(string username, string password)
        {
            using (var context = new BusinessDataContext())
            {
                return context.AdminUsers
                    .FirstOrDefault(a => a.AdminUsername == username
                                      && a.AdminPassword == password);
            }
        }
    }
}