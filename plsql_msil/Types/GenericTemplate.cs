using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.TypeLoader;

namespace plsql_msil.Types
{
    class GenericMehodInfo
    {
        public GenericMehodInfo(List<TypeWithName> args, TypeInfo ret, string name, bool isStatic)
        {
            this.args = args;
            this.ret = ret;
            this.name = name;
            this.isStatic = isStatic;
        }

        public List<TypeWithName> args;
        public TypeInfo ret;
        public string name;
        public bool isStatic;
    }

    class GenericTemplate
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

        public void AddMethod(string name, List<TypeWithName> args, TypeInfo ret, bool isStatic)
        {
            Methods.Add(new GenericMehodInfo(args, ret, name, isStatic));
        }
        public void AddConstructor(List<TypeWithName> args)
        {
            Constructors.Add(new GenericMehodInfo(args, TypeInfo.Void, "", false));
        }

        public TypeInfo Generate(params TypeInfo[] types)
        {
            string name = Name;
            foreach (var item in types)
            {
                name += item.Name;
            }


            var res = new GenericClassType(Name, name, types);

            foreach (var item in Methods)
            {
                res.AddMethod(BuildMethod(item, types, res));
            }

            return res;
        }


        private MethodInfo BuildMethod(GenericMehodInfo method, TypeInfo[] types, ClassType where)
        {
            var gRet = method.ret as GenericType;

            var realRetType = gRet != null ? types[gRet.Number] : method.ret;

            var res = new MethodInfo(method.name, realRetType, method.isStatic, where);

            foreach (var item in method.args)
            {
                var gtype = item.type as GenericType;

                res.AddArg(item.name, gtype != null ? types[gtype.Number] : item.type);
            }

            return res;
        }
    }
}
