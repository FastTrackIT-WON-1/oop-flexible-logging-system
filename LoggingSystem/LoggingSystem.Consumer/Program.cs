using LoggingSystem.Loggers;
using System;
using System.IO;

namespace LoggingSystem.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationLogger.SetupLogging(new FileLogger(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));

            int[] array = ConsoleHelper.ReadVector();

            ConsoleHelper.PrintVector(array);
        }
    }
}
