using System.Linq;
using System.Collections.Generic;
using ScotWaterV1.Models;

namespace ScotWaterV1.Repositories
{
    public class StaffUserRepository
    {
        private List<StaffUser> users = new List<StaffUser>()
        {
            new StaffUser { UserID = 1, Username = "dean", Password = "abcd" },
            new StaffUser { UserID = 2, Username = "staff", Password = "1234" }
        };

        public StaffUser Login(string username, string password)
        {
            return users.FirstOrDefault(u =>
                u.Username.Equals(username, System.StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);
        }
    }
}