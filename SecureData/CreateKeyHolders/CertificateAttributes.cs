using System;

namespace CreateKeyHolders
{
    public class CertificateAttributes
    {
        /// <summary>
        /// Name of the pfx file to be created
        /// </summary>
        public string SubjectName { get; set; }

        /// <summary>
        /// password for the pfx file to be created
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// bool flag to set if the cer file has to be saved
        /// </summary>
        public bool SaveCerFile { get; set; }

        /// <summary>
        /// Algorithm type
        /// </summary>
        public AlgorithmEnum Algorithm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime SetNotAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime SetNotBefore { get; set; }
    } 
}
