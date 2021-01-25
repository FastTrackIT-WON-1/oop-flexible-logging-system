namespace LoggingSystem.Loggers
{
    public class ApplicationLogger
    {
        private static Logger logger = null;

        public static void SetupLogging(Logger logger)
        {
            ApplicationLogger.logger = logger;
        }

        public static void WriteLog(LogLevel errorLevel, string message)
        {
            ApplicationLogger.logger?.WriteLog(errorLevel, message);
        }
    }
}
