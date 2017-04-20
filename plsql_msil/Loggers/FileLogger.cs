using System.IO;
using plsql_msil.Semantic.Passes;

namespace plsql_msil.Loggers
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
