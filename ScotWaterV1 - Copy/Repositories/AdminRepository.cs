using System.Linq;
using ScotWaterV1.Core;
using ScotWaterV1.Models;

namespace ScotWaterV1.Repositories
{
    public class AdminRepository
    {
        public AdminUsers Login(string username, string password)
        {
            using (var context = new BusinessDataContext())
            {
                // Step 1: Find admin by username ONLY
                var user = context.AdminUsers
                    .FirstOrDefault(a => a.AdminUsername == username);

                if (user == null)
                    return null;

                // Step 2: Verify hashed password (PBKDF2)
                bool isValid = PasswordSecurity.VerifyPassword(password, user.AdminPassword);

                return isValid ? user : null;
            }
        }
    }
}
