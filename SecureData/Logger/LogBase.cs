using System;

namespace Logger
{
    public abstract class LogBase
    {
        public abstract void Log(Exception exception);
    }
}
