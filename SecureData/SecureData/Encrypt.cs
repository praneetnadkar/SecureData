using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SecureData
{
    public static class Encrypt
    {
        public static byte[] EncryptData(byte[] data, X509Certificate2 certificate2)
        {
            var publicKey = certificate2.PublicKey.Key as RSACryptoServiceProvider;
            var encryptedData = publicKey.Encrypt(data, false);
            return encryptedData;
        }
    }
}
