using System;
using System.Security.Cryptography;

namespace ScotWaterV1.Core
{
    public static class PasswordSecurity
    {
        // Dean Caldwell
        // 06/05/2026
        public static string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt = new byte[16];
            
            // Use a secure random number generator to create the salt
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            // Hash the password with the salt using PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 20000, HashAlgorithmName.SHA256);
            
            // Get the hash of the password
            byte[] hash = pbkdf2.GetBytes(32);
            
            //combine the salt and hash into a single array for byte storage
            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);

            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Decode the stored hash from Base64
            byte[] hashBytes = Convert.FromBase64String(storedHash);

            // Extract the salt from the stored hash
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // Hash the entered password with the extracted salt using PBKDF2
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 20000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32);

            // Compare the computed hash with the stored hash
            for (int i = 0; i < 32; i++)
            {
                // Use a constant-time comparison to prevent timing attacks
                if (hashBytes[i + 16] != hash[i])
                    return false;
            }

            return true;
        }
    }
}
