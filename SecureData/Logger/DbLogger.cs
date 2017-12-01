using System;

namespace Logger
{
    public class DBLogger : LogBase
    {
        readonly string _connectionString = string.Empty;
        public override void Log(Exception exception)
        {
            var message = exception.InnerException + Environment.NewLine + exception.Message;
            //Code to log data to the database
        }
    }
}
