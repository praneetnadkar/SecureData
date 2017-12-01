using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateKeyHolders
{
    public enum AlgorithmEnum
    {
        [Description(nameof(MD2WITHRSAENCRYPTION))]
        MD2WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        MD2WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        MD5WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        MD5WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA1WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA1WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA224WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA224WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA256WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA256WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA384WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA384WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA512WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA512WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA1WITHRSAANDMGF1,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA224WITHRSAANDMGF1,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA256WITHRSAANDMGF1,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA384WITHRSAANDMGF1,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA512WITHRSAANDMGF1,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        RIPEMD160WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        RIPEMD160WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        RIPEMD128WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        RIPEMD128WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        RIPEMD256WITHRSAENCRYPTION,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        RIPEMD256WITHRSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA1WITHDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        DSAWITHSHA1,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA224WITHDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA256WITHDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA384WITHDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA512WITHDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA1WITHECDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        ECDSAWITHSHA1,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA224WITHECDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA256WITHECDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        SHA384WITHECDSA,

        [Description(nameof(SHA512WITHECDSA))]
        SHA512WITHECDSA,

        [Description(nameof(MD2WITHRSAENCRYPTION))]
        GOST3411WITHGOST3410,

        [Description("GOST3411WITHGOST3410-94")]
        GOST3411WITHGOST3410_94,

        [Description(nameof(GOST3411WITHECGOST3410))]
        GOST3411WITHECGOST3410,

        [Description("GOST3411WITHECGOST3410-2001")]
        GOST3411WITHECGOST3410_2001,

        [Description("GOST3411WITHGOST3410-2001")]
        GOST3411WITHGOST3410_2001
    }

    /// <summary>
    /// Extension class to get the description
    /// </summary>
    public static class AlgorithmEnumExtensions
    {
        public static string GetDescription(this AlgorithmEnum val)
        {
            var attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
