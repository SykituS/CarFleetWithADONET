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
        /// <summary>
        /// Hash password in SHA-256 method
        /// </summary>
        /// <param name="password">Password to hash</param>
        /// <returns></returns>
        public static string EncodePassword(string password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] inArray = HashAlgorithm.Create("SHA-256").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }
    }
}
