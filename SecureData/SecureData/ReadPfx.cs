using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SecureData
{
    internal class ReadPfx
    {
        public static X509Certificate2 GetCertificate(string path)
        {
            const string password = "";

            var collection = new X509Certificate2Collection();

            collection.Import(path, password, X509KeyStorageFlags.PersistKeySet);

            var certificate = collection[0];

            return certificate;
        }
    }
}
