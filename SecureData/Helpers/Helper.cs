using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Helpers
{
    public static class Helper
    {
        public static void WriteAllBytes(string path, byte[] byteArray)
        {
            try
            {
                if (!string.IsNullOrEmpty(path) && byteArray.LongLength > 0)
                {
                    File.WriteAllBytes(path, byteArray);
                }
            }
            catch (Exception exception)
            {
                var logger = new Logger.FileLogger();
                logger.Log(exception);
            }            
        }
    }
}
