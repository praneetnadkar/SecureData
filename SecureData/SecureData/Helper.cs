using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureData
{
    public static class Helper
    {
        public static string GetStringFromByte(byte[] data)
        {
            //Here converting the byteArray to string
            var meaningfullData = Encoding.UTF8.GetString(data, 0, data.Length);
            return meaningfullData;
        }

        public static byte[] GetBytes(string data)
        {
            //Here converting the string to byteArray
            var byteArray = Encoding.UTF8.GetBytes(data);
            return byteArray;
        }
    }
}
