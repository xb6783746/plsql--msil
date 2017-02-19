using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Semantic
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
