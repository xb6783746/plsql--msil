

namespace plsqlBasic.Loggers
{
    public enum LogLevel
    {
        Warning, Error, Info
    }
    public interface ILogger
    {
        void Log(string message, LogLevel level);
        void Log(string message);
    }
}
