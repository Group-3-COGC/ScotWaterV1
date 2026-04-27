using System.Linq;
using ScotWaterV1.Core;
using ScotWaterV1.Models;

namespace ScotWaterV1.Repositories
{
    public class StaffUserRepository
    {
        public StaffUser Login(string username, string password)
        {
            using (var context = new BusinessDataContext())
            {
                // Step 1: Find user by username ONLY
                var user = context.StaffUser
                    .FirstOrDefault(s => s.staffUsername == username);

                if (user == null)
                    return null;

                // Step 2: Verify hashed password (PBKDF2)
                bool isValid = PasswordSecurity.VerifyPassword(password, user.staffPassword);

                return isValid ? user : null;
            }
        }
    }
}
