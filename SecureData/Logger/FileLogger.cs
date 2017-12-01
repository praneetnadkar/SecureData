using System;
using System.IO;

namespace Logger
{
    public class FileLogger : LogBase
    {
        public string filePath = @"D:\Log.txt";

        public override void Log(Exception exception)
        {
            var message = exception.InnerException + Environment.NewLine + exception.Message;
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }
    }
}
