using System;
using System.IO;

namespace LoggingSystem.Loggers
{
    public class FileLogger : Logger
    {
        private const string DefaultFileName = "Log.txt";

        public FileLogger()
            : this (null, null)
        {
        }

        public FileLogger(string directory)
            : this (directory, null)
        {
        }

        public FileLogger(string directory, string fileName)
        {
            Directory = directory ?? string.Empty;
            FileName = fileName ?? DefaultFileName;
        }

        public string Directory { get; }

        public string FileName { get; }

        public override void WriteLog(LogLevel errorLevel, string message)
        {
            string directory = Directory;
            if (string.IsNullOrWhiteSpace(directory))
            {
                directory = Environment.CurrentDirectory;
            }

            if (!System.IO.Directory.Exists(directory))
            {
                System.IO.Directory.CreateDirectory(directory);
            }

            string fileName = FileName;
            if (string.IsNullOrWhiteSpace(fileName))
            {
                fileName = DefaultFileName;
            }

            string filePath = Path.Combine(directory, FileName);
            string logEntry = $"{DateTime.Now} -  {errorLevel} - {message}";
            File.AppendAllLines(filePath, new[] { logEntry });
        }
    }
}
