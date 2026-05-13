using System.Linq;
using ScotWaterV1.Core;
using ScotWaterV1.Models;

namespace ScotWaterV1.Repositories
{
    //Dean Caldwell
    //06/05/2026

    public class AdminRepository
    {
        public AdminUsers Login(string username, string password)
        {
            using (var context = new BusinessDataContext())
            {
               
                var user = context.AdminUsers
                    .FirstOrDefault(a => a.AdminUsername == username);

                if (user == null)
                    return null;

                
                bool isValid = PasswordSecurity.VerifyPassword(password, user.AdminPassword);

                return isValid ? user : null;
            }
        }
    }
}
