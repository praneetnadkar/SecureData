using System;

namespace SecureData
{
    class Program
    {
        static void Main()
        {
            //var result = CertificateBuilder.GeneratePfx("test", "test@1234");

            const string DecryptCertPath = @"E:\AppCert.pfx";
            const string EncryptCertPath = @"E:\appBrowserCert.cer";

            const string input = "The quick brown fox jumps over a lazy dog.";
            var array = Helper.GetBytes(input);
            var ecertificate2 = ReadPfx.GetCertificate(EncryptCertPath);
            var encrypted = Encrypt.EncryptData(array, ecertificate2);
            var encryptedbase64 = Convert.ToBase64String(encrypted);
            Console.WriteLine(encryptedbase64);
            var decryptedArray = Convert.FromBase64String(encryptedbase64);
            var dcertificate2 = ReadPfx.GetCertificate(DecryptCertPath);
            var decrypted = Decrypt.DecryptData(encrypted, dcertificate2);
            var dectyptedString = Helper.GetStringFromByte(decrypted);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(dectyptedString);
            Console.WriteLine("==================================================");
            Console.ReadKey();
        }
    }
}
