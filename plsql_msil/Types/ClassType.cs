using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class ClassType :TypeInfo
    {

        public ClassType(string libName, string namespace_, string name, bool isImplemented = false)
            : base(name, isImplemented)
        {
            LibName = libName;
            Namespace = namespace_;
            IsLibClass = true;
        }
        public ClassType(string name, bool isImplemented = false) :base(name, isImplemented)
        {
        }

        protected List<MethodInfo> innerMethods = new List<MethodInfo>();
        protected List<VarInfo> innerVars = new List<VarInfo>();
        private List<ConstructorInfo> constructors = new List<ConstructorInfo>();

        public override Type Type
        {
            get { return Type.Class; }
        }
        public override List<MethodInfo> Methods
        {
            get
            {
                return innerMethods;
            }
        }
        public override List<VarInfo> Fields
        {
            get
            {
                return innerVars;
            }
        }
        public override List<ConstructorInfo> Constructors
        {
            get { return constructors; }
        }

        public override VarInfo GetField(string memberName)
        {
            return innerVars.FirstOrDefault(x => x.Name == memberName);
        }
        public override MethodInfo GetMethod(string methodName, List<TypeInfo> args, bool isStatic)
        {
            return innerMethods.FirstOrDefault(x => 
                   x.Name == methodName 
                && TypeInfo.Compare(x.ArgTypes, args) 
                && x.IsStatic == isStatic);
        }

        public bool AddField(string name, TypeInfo type)
        {
            bool ok = GetField(name) == null;

            if (ok)
            {
                innerVars.Add(new VarInfo(name, type, VarLocation.Global));
            }

            return ok;
        }
        public bool AddMethod(MethodInfo method)
        {
            bool ok = GetMethod(method.Name, method.ArgTypes, method.IsStatic) == null;

            if (ok)
            {
                innerMethods.Add(method);
            }

            return ok;
        }

        public override bool ContainsConstructor(List<TypeInfo> args)
        {
            return constructors.Exists(x => TypeInfo.Compare(x.ArgTypes, args));
        }

        public bool AddConstructor(ConstructorInfo constructor)
        {
            bool ok = !ContainsConstructor(constructor.ArgTypes);

            if (ok)
            {
                constructors.Add(constructor);
            }

            return ok;
        }
    }
}
