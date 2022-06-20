using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace simpleClient
{
    public static class myTransformer1
    {
        public static string Encrypt(string value)
        {
            byte[] plaintext = Encoding.Unicode.GetBytes(value);

            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "voanhkiet";
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048, cspParams))
            {
                byte[] encryptedData = RSA.Encrypt(plaintext, false);
                return Convert.ToBase64String(encryptedData);
            }
        }

        public static string Decrypt(string value)
        {
            byte[] encryptedData = Convert.FromBase64String(value);

            CspParameters cspParams = new CspParameters();
            cspParams.KeyContainerName = "voanhkiet";
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048, cspParams))
            {
                byte[] decryptedData = RSA.Decrypt(encryptedData, false);
                return Encoding.Unicode.GetString(decryptedData);
            }
        }

    }
}
