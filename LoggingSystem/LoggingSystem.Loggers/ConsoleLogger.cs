using System;

namespace LoggingSystem.Loggers
{
    public class ConsoleLogger : Logger
    {
        public override void WriteLog(LogLevel errorLevel, string message)
        {
            Console.WriteLine($"{DateTime.Now} -  {errorLevel} - {message}");
        }
    }
}
