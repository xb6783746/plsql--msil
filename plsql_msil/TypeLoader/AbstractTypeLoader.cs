using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.TypeLoader
{
    class AbstractTypeLoader
    {

        public AbstractTypeLoader(TypeStorage storage)
        {

            this.storage = storage;
        }


        protected TypeStorage storage;

        protected void Build(ClassType classType, System.Type type, Func<FieldInfo, bool> fieldCond, Func<System.Reflection.MethodInfo, bool> methodCond)
        {
            var fields = type.GetFields().Where(fieldCond);

            foreach (var field in fields)
            {
                BuildField(classType, field);
            }

            var methods = type.GetMethods().Where(methodCond);

            foreach (var method in methods)
            {
                BuildMethod(classType, method);
            }
        }

        protected void BuildField(ClassType classType, FieldInfo fieldInfo)
        {
            var fieldType = storage.GetType(ConvertMSILNames(fieldInfo.FieldType));

            if (fieldType != null)
            {
                classType.AddField(fieldInfo.Name, fieldType);
            }
        }
        protected void BuildMethod(ClassType classType, System.Reflection.MethodInfo methodInfo)
        {
            var retType = storage.GetType(ConvertMSILNames(methodInfo.ReturnType));          

            var args =
                methodInfo.GetParameters()
                    .ToList()
                    .Select(x => new {Type = storage.GetType(ConvertMSILNames(x.ParameterType)), Name = x.Name});

            if (!args.Any(x => x.Type == null))
            {
                var method = new plsql_msil.Types.MethodInfo(methodInfo.Name, retType, methodInfo.IsStatic, classType);

                foreach (var item in args)
                {
                    method.AddArg(item.Name, item.Type);
                }

                classType.AddMethod(method);
            }

        }

        private static Dictionary<string, string> primitiveTypes = new Dictionary<string, string>()
        {
            {"Int32", "int"},
            {"Byte", "byte"},
            {"Char", "char"},
            {"Double", "double"},
            {"Float", "float"},
            {"String", "string"},
            {"Void", "void"}

        };

        protected string ConvertMSILNames(System.Type type)
        {
            if (primitiveTypes.ContainsKey(type.Name))
            {
                return primitiveTypes[type.Name];
            }

            return type.Name;
        }

        private bool IsSimpleType(System.Type type)
        {
            return primitiveTypes.ContainsKey(type.Name);
        }
    }
}
