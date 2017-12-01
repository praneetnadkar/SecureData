# SecureData
Encrypt/Decrypt data in C#
Security has become an integral part of our lives. We first tend to check with the security in our phone, in our home, in bank accounts and what not. The same has happened with the softwares.

Security has been a major point to mull over for any software development. To implement any security in an application, there are a lot of ways one can do that. One of the most common terms that one sees in this is “Cryptography”. According to wiki “Cryptography or cryptology is the practice and study of techniques for secure communication”. This practice of secure communication, can be achieved by a no of ways or algorithms. One of the basic thing to be implemented in crypto is encryption.

In cryptography, encryption is the process of encoding a message or information in such a way that only authorized parties can access it. Encryption does not itself prevent interference, but denies the intelligible content to a would-be interceptor. There are many algorithms present using which this can be done. One of the way to do that is using certificated and public and private keys.

# What is PFX ?

In cryptography, PKCS #12 defines an archive file format(.p12 or .pfx) for storing many cryptography objects as a single file. It is commonly used to bundle a private key with its X.509 certificate or to bundle all the members of a chain of trust. Windows uses .pfx for a PKCS #12 file. This file can contain a variety of cryptographic information, including certificates, certificate chains, root authority certificates, and private keys. Its contents can be cryptographically protected (with passwords) to keep private keys private and preserve the integrity of root certificates.

# What is CER

Windows uses .cer extension for an X.509 certificate. These can be in “binary” (ASN.1 DER), or it can be encoded with Base-64 and have a header and footer applied (PEM); Windows will recognize either. To verify the integrity of a certificate, you have to check its signature using the issuer’s public key… which is, in turn, another certificate.

# Using pfx and cer in .Net application

I have been using these files for encryption and decryption of the data in a few web services. The pfx and vcer file can be generated using the utilities in the Windows operating systems. However, it becomes really great if there is someway, where we can automate this programatically.

To do this, I am using an API Bouncy Castle. It is simply an amazing work by these guys here.

In C#, I have created a console app, and installed bouncy castle in the project. To install the nuget package, use Install-Package BouncyCastle -Version 1.8.1

Once this is installed, you can use the code to create a pfx file or a cer file.
