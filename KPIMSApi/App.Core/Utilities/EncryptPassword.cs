using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System.Text;

namespace KPIMS.Core.Utilities
{
    public class EncryptPassword
    {
        public static string GetSalt()
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);
            return Convert.ToBase64String(salt);
        }

        public static string GetHas(string password, string salt)
        {
            byte[] saltsByte = Encoding.ASCII.GetBytes(salt);
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: saltsByte,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 100000,
                    numBytesRequested: 256 / 8
                )
            );

            return hashed;
        }

        public static bool IsValid(string originalPassword, string salt, string hasPassword)
        {
            return (GetHas(originalPassword, salt) == hasPassword);
        }
    }
}
