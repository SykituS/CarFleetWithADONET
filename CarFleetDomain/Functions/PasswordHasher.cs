using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Functions
{
    public class PasswordHasher
    {
        public static string EncodePassword(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA-256").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }
    }
}
