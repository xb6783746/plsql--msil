using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class MethodInfo
    {

        public MethodInfo(string name, TypeInfo ret, bool isStatic, ClassType where)
        {
            Name = name;
            Ret = ret;
            IsStatic = isStatic;

            Where = where;
        }

        private List<VarInfo> args = new List<VarInfo>();
        private List<VarInfo> vars = new List<VarInfo>();

        public bool IsStatic { get; private set; }
        public string Name { get; private set; }
        public List<VarInfo> Arguments { get { return args; } }
        public List<VarInfo> Vars { get { return vars; } }
        public TypeInfo Ret { get; private set; }
        public ClassType Where { get; private set; }

        public List<TypeInfo> ArgTypes { get { return args.Select(x => x.Type).ToList(); } }

        public VarInfo GetVar(string name)
        {
            return args.Union(vars).FirstOrDefault(x => x.Name == name);
        }

        public bool AddArg(string name, TypeInfo type)
        {
            return Add(name, type, VarLocation.Argument, args);
        }
        public bool AddVar(string name, TypeInfo type)
        {
            return Add(name, type, VarLocation.Local, vars);
        }

        private bool Add(string name, TypeInfo type, VarLocation loc, List<VarInfo> vars)
        {
            bool res = !Exists(name);

            if (res)
            {
                vars.Add(new VarInfo(name, type, loc));
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
                    && CompareVarList(args, method.args)
                    && CompareVarList(vars, method.vars)
                    && Ret.Equals(method.Ret);
            }

            return false;
        }

        private bool CompareVarList(List<VarInfo> first, List<VarInfo> second)
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
