using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Semantic
{
    class Context
    {

        public Context(TypeStorage types)
        {
            this.Types = types;

            NotImplementedTypes = new List<TypeInfo>();
        }

        public List<TypeInfo> NotImplementedTypes { get; set; }
        public ClassType Self { get; private set; }
        public MethodInfo CurrentMethod { get; set; }
        public TypeStorage Types { get; private set; }

        public TypeInfo GetType(string name)
        {

            return Types.GetType(name);
        }

        public GenericTemplate GetTemplate(string name)
        {

            return Types.GetTemplate(name);
        }

        public VarInfo GetVar(string name)
        {
            VarInfo res = null;
            if (CurrentMethod != null)
            {
                res = CurrentMethod.GetVar(name);
            }

            if (res == null && Self != null)
            {
                return Self.GetField(name);
            }

            return res;
        }


        public void EnterClass(ClassType type)
        {
            Self = type;
        }
        public void ExitClass()
        {
            Self = null;
        }

    }
}
