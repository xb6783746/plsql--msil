using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class LibraryInfo
    {
        public LibraryInfo(string libName, string version)
        {
            LibName = libName;
            Version = version;
        }

        public string LibName { get; private set; }
        public string Version { get; private set; }
    }
}
