using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Semantic
{
    class Context
    {

        public Context(TypeStorage types)
        {
            this.Types = types;

            Vars = new VarTable();
        }

        public TypeInfo Self { get; private set; }
        public MethodInfo CurrentMethod { get; set; }
        public VarTable Vars { get; private set; }
        public TypeStorage Types { get; private set; }

        public TypeInfo GetType(string name)
        {

            return Types.GetType(name);
        }

        public void EnterClass(TypeInfo type)
        {
            Self = type;
        }
        public void ExitClass()
        {
            Self = null;
        }

        public void EnterBlock()
        {
            Vars = new VarTable(Vars);
        }
        public void ExitBlock()
        {
            Vars = Vars.Inner;
        }
    }
}
