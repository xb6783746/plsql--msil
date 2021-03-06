﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Types
{
    public class ClassType :TypeInfo
    {

        public ClassType(string name) :base(name)
        {
        }

        protected List<MethodInfo> innerMethods = new List<MethodInfo>();
        protected List<VarInfo> innerVars = new List<VarInfo>();
        private List<ConstructorInfo> constructors = new List<ConstructorInfo>();

        public List<MethodInfo> Methods
        {
            get
            {
                return innerMethods;
            }
        }
        public List<VarInfo> Fields
        {
            get
            {
                return innerVars;
            }
        }
        public List<ConstructorInfo> Constructors
        {
            get { return constructors; }
        }

        public VarInfo GetField(string memberName)
        {
            return innerVars.FirstOrDefault(x => x.Name == memberName);
        }
        public MethodInfo GetMethod(string methodName, List<TypeInfo> args, bool isStatic)
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
                innerVars.Add(new GlobalVarInfo(name, type, this));
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

        public bool ContainsConstructor(List<TypeInfo> args)
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
