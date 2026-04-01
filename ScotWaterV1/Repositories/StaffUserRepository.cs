using System.Linq;
using ScotWaterV1;
using ScotWaterV1.Models;
using System.Collections.Generic;

public class StaffUserRepository
{
    // Temporary in‑memory list (no database yet)
    private List<StaffUser> users = new List<StaffUser>()
        {
            new StaffUser { UserID = 1, Username = "dean", Password = "abcd" },
            new StaffUser { UserID = 2, Username = "staff", Password = "1234" }
        };

    // Login method
    public StaffUser Login(string username, string password)
    {
        return users.FirstOrDefault(u =>
            u.Username.Equals(username, System.StringComparison.OrdinalIgnoreCase) &&
            u.Password == password);

    }
}