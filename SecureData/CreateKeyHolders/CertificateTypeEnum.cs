namespace CreateKeyHolders
{
    public enum CertificateTypeEnum
    {
        /// <summary>
        /// For generating the CA certificate by name
        /// </summary>
        CertificationAuthority = 0,

        /// <summary>
        /// for generating the self signed Certificate
        /// </summary>
        SelfSigned = 1
    }
}
