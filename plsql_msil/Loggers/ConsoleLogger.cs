using System;
using plsql_msil.Semantic.Passes;

namespace plsql_msil.Loggers
{
    class ConsoleLogger :ILogger
    {

        public void Log(string message, LogLevel level)
        {
            Console.WriteLine("{0}: {1}", level.ToString(), message);
        }


        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
