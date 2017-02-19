using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Semantic
{
    interface ILogger
    {
        void Log(string message, LogLevel level);
        void Log(string message);
    }
}
