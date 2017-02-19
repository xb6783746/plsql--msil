using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Semantic
{
    class FileLogger :ILogger
    {
        public FileLogger(string path)
        {
            this.path = path;
        }

        private string path;


        public void Log(string message, LogLevel level)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine("{0}: {1}", level.ToString(), message);
            }
        }


        public void Log(string message)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(message);
            }
        }
    }
}
