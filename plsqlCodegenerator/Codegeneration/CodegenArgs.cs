using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types;

namespace plsql_msil.Codegeneration
{
    class CodegenArgs
    {
        public CodegenArgs(TypeStorage types, MethodInfo entryPoint)
        {
            Types = types;
            EntryPoint = entryPoint;
        }

        public TypeStorage Types { get; private set; }
        public MethodInfo EntryPoint { get; private set; }
    }
}
