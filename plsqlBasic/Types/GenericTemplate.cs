﻿using System.Collections.Generic;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Types
{
    public class GenericMehodInfo
    {
        public GenericMehodInfo(List<VarInfo> args, TypeInfo ret, string name, bool isStatic)
        {
            this.args = args;
            this.ret = ret;
            this.name = name;
            this.isStatic = isStatic;
        }

        public List<VarInfo> args;
        public TypeInfo ret;
        public string name;
        public bool isStatic;
    }

    public class GenericTemplate
    {
        public GenericTemplate(string name, int genericCount)
        {
            Name = name;
            this.genericCount = genericCount;
            Methods = new List<GenericMehodInfo>();
            Constructors = new List<GenericMehodInfo>();
        }

        public string Name { get; private set; }
        private int genericCount;
        public List<GenericMehodInfo> Methods { get; private set; }
        public List<GenericMehodInfo> Constructors { get; private set; }

        public void AddMethod(string name, List<VarInfo> args, TypeInfo ret, bool isStatic)
        {
            Methods.Add(new GenericMehodInfo(args, ret, name, isStatic));
        }
        public void AddConstructor(List<VarInfo> args)
        {
            Constructors.Add(new GenericMehodInfo(args, TypeInfo.Void, "", false));
        }

        public TypeInfo Generate(string typeName, params TypeInfo[] types)
        {
            if (typeName == null)
            {

                typeName = Name;
                foreach (var item in types)
                {
                    typeName += item.Name;
                }
            }


            var res = new GenericClassType(Name, typeName, types);

            foreach (var item in Methods)
            {
                res.AddMethod(BuildMethod(item, types, res));
            }

            return res;
        }


        private MethodInfo BuildMethod(GenericMehodInfo method, TypeInfo[] types, ClassType where)
        {
            var gRet = method.ret as GenericType;

            var realRetType = gRet != null ? types[gRet.Number].Generic(gRet.Number) : method.ret;

            var res = new MethodInfo(method.name, realRetType, method.isStatic, where);

            foreach (var item in method.args)
            {
                var gtype = item.Type as GenericType;
                TypeInfo varType;

                if (gtype != null)
                {
                    varType = types[gtype.Number].Generic(gtype.Number);
                }
                else
                {
                    varType = item.Type;
                }

                res.AddArg(item.Name, varType);

                //res.GenericArgs.Add(gtype != null ? gtype.Number : -1);
            }

            return res;
        }
    }
}
