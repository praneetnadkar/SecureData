using Data.Helpers;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace CreateKeyHolders
{
    public static class CertificateBuilder
    {
        /// <summary>
        /// Creates the certificate based on the subject name
        /// </summary>
        /// <param name="certificate">The certificate object with custom values for the certificate</param>
        /// <returns></returns>
        public static bool GeneratePfx(CertificateAttributes certificate)
        {
            var isCertificateCreated = false;
            try
            {
                var keyPairGenerator = new RsaKeyPairGenerator();
                keyPairGenerator.Init(new KeyGenerationParameters(new SecureRandom(new CryptoApiRandomGenerator()), 1024));
                var kp = keyPairGenerator.GenerateKeyPair();
                var signatureFactory = new Asn1SignatureFactory(certificate.Algorithm.GetDescription(), kp.Private);
                var gen = new X509V3CertificateGenerator();
                var certName = new X509Name("CN=" + certificate.SubjectName);
                var serialNo = BigInteger.ProbablePrime(120, new Random());
                //sets the serial no for the certificate : add a custom serial no if you have one
                gen.SetSerialNumber(serialNo);
                //set the subject name : can be custom here
                gen.SetSubjectDN(certName);
                //sets the issuer name
                gen.SetIssuerDN(certName);
                gen.SetNotAfter(DateTime.Now.AddYears(100));
                gen.SetNotBefore(DateTime.Now.Subtract(new TimeSpan(7, 0, 0, 0)));
                //set the public key for the certificate
                gen.SetPublicKey(kp.Public);

                gen.AddExtension(
                    X509Extensions.AuthorityKeyIdentifier.Id,
                    false,
                    new AuthorityKeyIdentifier(
                        SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(kp.Public),
                        new GeneralNames(new GeneralName(certName)),
                        serialNo));

                gen.AddExtension(
                    X509Extensions.ExtendedKeyUsage.Id,
                    false,
                    new ExtendedKeyUsage(new List<object> { new DerObjectIdentifier("1.3.6.1.5.5.7.3.1") }));

                var newCert = gen.Generate(signatureFactory);
                var createdCertificate = DotNetUtilities.ToX509Certificate(newCert);
                var byteArray = createdCertificate.Export(X509ContentType.Pkcs12, certificate.Password);
                var byteArray1 = createdCertificate.Export(X509ContentType.Cert, certificate.Password);

                //Save the pfx file here
                Helper.WriteAllBytes("C:\\certs\\" + certificate.SubjectName + ".pfx", byteArray);

                //save the cert here
                if (certificate.SaveCerFile)
                    Helper.WriteAllBytes("C:\\certs\\" + certificate.SubjectName + ".cer", byteArray1);

                isCertificateCreated = true;
            }
            catch (Exception exception)
            {
                var logger = new Logger.FileLogger();
                logger.Log(exception);
            }

            return isCertificateCreated;
        }
    }
}