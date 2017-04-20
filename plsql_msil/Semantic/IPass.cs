using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Loggers;

namespace plsql_msil.Semantic
{
    interface IPass
    {
        bool Check(CommonTree tree, ILogger logger);
    }
}
