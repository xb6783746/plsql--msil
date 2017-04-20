using plsql_msil.Semantic.Passes;

namespace plsql_msil.Loggers
{
    interface ILogger
    {
        void Log(string message, LogLevel level);
        void Log(string message);
    }
}
