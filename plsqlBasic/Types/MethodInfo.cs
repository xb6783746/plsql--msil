using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Types
{
    public class MethodInfo
    {

        public MethodInfo(string name, TypeInfo ret, bool isStatic, ClassType where)
        {
            Name = name;
            Ret = ret;
            IsStatic = isStatic;

            Where = where;
        }

        private List<MethodVarInfo> vars = new List<MethodVarInfo>();

        public bool IsStatic { get; private set; }
        public string Name { get; private set; }

        public List<MethodVarInfo> Arguments
        {
            get
            {
                return vars
                    .Where(x => x.VarType == MethodVarType.Argument)
                    .ToList();
            }
        }
        public List<MethodVarInfo> LocalVars
        {
            get
            {
                return vars
                    .Where(x => x.VarType == MethodVarType.Local)
                    .ToList();
            }
        }
        public TypeInfo Ret { get; private set; }
        public ClassType Where { get; private set; }

        public List<TypeInfo> ArgTypes
        {
            get
            {
                return Arguments.Select(x => x.Type).ToList();
            }
        }

        public VarInfo GetVar(string name)
        {
            return vars.FirstOrDefault(x => x.Name == name);
        }

        public bool AddArg(string name, TypeInfo type)
        {
            return Add(name, type, MethodVarType.Argument);
        }
        public bool AddLocalVar(string name, TypeInfo type)
        {
            return Add(name, type, MethodVarType.Local);
        }


        private bool Add(string name, TypeInfo type, MethodVarType varType)
        {
            bool res = !Exists(name);

            if (res)
            {
                vars.Add(new MethodVarInfo(name, type, varType));
            }

            return res;
        }

        public override bool Equals(object obj)
        {
            var method = obj as MethodInfo;

            if(method != null)
            {
                return IsStatic == method.IsStatic
                    && Name == method.Name
                    && CompareVarList(vars, method.vars)
                    && Ret.Equals(method.Ret);
            }

            return false;
        }

        private bool CompareVarList(List<MethodVarInfo> first, List<MethodVarInfo> second)
        {
            return TypeInfo.Compare(
                first.Select(x => x.Type),
                second.Select(x => x.Type));
        }

        private bool Exists(string name)
        {
            return GetVar(name) != null;
        }
    }
}
