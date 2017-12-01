using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace SecureData
{
    public static class Decrypt
    {
        public static byte[] DecryptData(byte[] encryptedData, X509Certificate2 certificate)
        {
            if (!certificate.HasPrivateKey)
                throw new Exception("The certificate does not have a private key");

            var privateKey = certificate.PrivateKey as RSACryptoServiceProvider;
            var data = privateKey.Decrypt(encryptedData, false);
            return data;
        }
    }
}
