using System.Linq;
using ScotWaterV1.Core;
using ScotWaterV1.Models;

namespace ScotWaterV1.Repositories
{

    //Dean Caldwell
    //06/05/2026

    public class StaffUserRepository
    {
        public StaffUser Login(string username, string password)
        {
            using (var context = new BusinessDataContext())
            {
               
                var user = context.StaffUser
                    .FirstOrDefault(s => s.staffUsername == username);

                if (user == null)
                    return null;

                bool isValid = PasswordSecurity.VerifyPassword(password, user.staffPassword);

                return isValid ? user : null;
            }
        }
    }
}
