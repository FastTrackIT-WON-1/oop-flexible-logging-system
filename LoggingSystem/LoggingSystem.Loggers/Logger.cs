namespace LoggingSystem.Loggers
{
    public abstract class Logger
    {
        public abstract void WriteLog(LogLevel errorLevel, string message);
    }
}
