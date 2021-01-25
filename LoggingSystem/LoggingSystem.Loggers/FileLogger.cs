using System;
using System.IO;

namespace LoggingSystem.Loggers
{
    public class FileLogger : Logger
    {
        public FileLogger(string path)
        {
            Path = path ?? string.Empty;
        }

        public string Path { get; }

        public override void WriteLog(LogLevel errorLevel, string message)
        {
            if (File.Exists(Path))
            {
                string logEntry = $"{DateTime.Now} -  {errorLevel} - {message}";
                File.AppendAllLines(Path, new[] { logEntry, Environment.NewLine });
            }
        }
    }
}
