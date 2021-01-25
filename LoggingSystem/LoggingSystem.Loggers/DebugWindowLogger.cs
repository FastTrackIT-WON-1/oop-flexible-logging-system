using System;
using System.Diagnostics;

namespace LoggingSystem.Loggers
{
    public class DebugWindowLogger : Logger
    {
        public override void WriteLog(LogLevel errorLevel, string message)
        {
            Debug.WriteLine($"{DateTime.Now} -  {errorLevel} - {message}");
        }
    }
}
