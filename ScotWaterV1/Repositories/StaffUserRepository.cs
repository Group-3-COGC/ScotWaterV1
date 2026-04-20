using System.Linq;
using System.Collections.Generic;
using ScotWaterV1.Models;

namespace ScotWaterV1.Repositories
{
    public class StaffUserRepository
    {
        public StaffUser Login(string username, string password)
        {
            using (var context = new BusinessDataContext())
            {
                return context.StaffUser
                    .FirstOrDefault(s => s.staffUsername == username
                                      && s.staffPassword == password);
            }
        }
    }
}