using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Semantic
{
    class VarTable
    {
        public VarTable()
        {

        }
        public VarTable(VarTable inner)
        {
            Inner = inner;
        }

        public VarTable Inner { get; private set; }

        private List<VarInfo> vars = new List<VarInfo>();

        public bool AddVar(VarInfo var)
        {
            bool res = GetVar(var.Name) == null;

            if(res)
            {
                vars.Add(var);
            }

            return res;
        }
        //public bool AddLocalVar(string name, TypeInfo type, VarLocation loc)
        //{
        //    return AddLocalVar(new VarInfo(name, type, loc));
        //}
        public VarInfo GetVar(string name)
        {
            VarInfo res = vars.FirstOrDefault(x => x.Name == name);

            if(res == null && Inner != null)
            {
                res = Inner.GetVar(name);
            }

            return res;
        }

        
    }
}
