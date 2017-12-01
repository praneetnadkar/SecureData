using System;
using System.Diagnostics;

namespace Logger
{
    public class EventLogger : LogBase
    {
        public override void Log(Exception exception)
        {
            var message = exception.InnerException + Environment.NewLine + exception.Message;
            using (var eventLog = new EventLog(""))
            {
                eventLog.Source = "EventLog";
                eventLog.WriteEntry(message);
            }
        }
    }
}
