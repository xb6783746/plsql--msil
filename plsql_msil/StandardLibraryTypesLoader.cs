using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Semantic
{
    class StandardLibraryTypesLoader
    {

        public TypeStorage Load(List<string> libs)
        {
            storage = new TypeStorage();
            GetSimpleTypes(storage);

            LoadTypes(libs);

            return storage;
        }

        private TypeStorage storage;
        private List<System.Type> libTypes = new List<System.Type>();

        private void GetSimpleTypes(TypeStorage storage)
        {

            storage.AddType(new SimpeType(SimpleTypeEnum.Int), false);
            storage.AddType(new SimpeType(SimpleTypeEnum.Char), false);
            storage.AddType(new SimpeType(SimpleTypeEnum.Double), false);
            storage.AddType(new SimpeType(SimpleTypeEnum.Bool), false);
            storage.AddType(new SimpeType(SimpleTypeEnum.Float), false);
            storage.AddType(new SimpeType(SimpleTypeEnum.String), false);
            storage.AddType(new SimpeType(SimpleTypeEnum.Void), false);
        }


        private void LoadTypes(List<string> libs)
        {
            foreach (var item in libs)
            {
                LoadTypes(item);
            }
        }

        private void LoadTypes(string path)
        {
            var assembly = Assembly.LoadFrom(path);

            storage.Libs.Add(
                new LibraryInfo(
                    assembly.GetName().Name, 
                    assembly.GetName().Version.ToString()
                    )
                  );

            var types = assembly
                .GetTypes()
                .Where(x => x.IsClass && x.IsPublic && x.IsAbstract);

            libTypes.AddRange(types);

            foreach (var item in types)
            {
                storage.AddType(GetTypeInfo(item), false);
            }

            foreach (var item in types)
            {
                BuildType(item);
            }
        }

        private plsql_msil.Types.TypeInfo GetTypeInfo(System.Type type)
        {
            plsql_msil.Types.TypeInfo typeInfo;

            if(type.IsAbstract)
            {
                typeInfo = new PackageType(type.Assembly.GetName().Name, type.Namespace, type.Name);
            }
            else if(type.IsNestedPublic)
            {
                //typeInfo = new RecordType(type.Assembly.FullName, type.Namespace, type.Name);
                typeInfo = null;
            }
            else
            {
                //typeInfo = new ClassType(type.Assembly.FullName, type.Namespace, type.Name);
                typeInfo = null;
            }

            return typeInfo;
        }

        private void BuildType(System.Type type)
        {
            var typeInfo = storage.GetType(type.Name);

            if (type.IsAbstract)
            {
                BuildPackage(typeInfo as PackageType, type);
            }
            else if (type.IsNestedPublic)
            {
                //typeInfo = new RecordType(type.Assembly.FullName, type.Namespace, type.Name);
                typeInfo = null;
            }
            else
            {
                //BuildClass(typeInfo as ClassType, type);
            }
        }

        private void BuildClass(ClassType classType, System.Type type)
        {
            var fields = type.GetFields().Where(x => x.IsPublic && !x.IsStatic);

            foreach(var field in fields)
            {
                var fieldType = storage.GetType(ConvertMSILNames(field.FieldType));

                classType.AddField(field.Name, fieldType);
            }

            var methods = type.GetMethods().Where(x => x.IsPublic && !x.IsStatic);

            foreach(var method in methods)
            {
                var retType = storage.GetType(ConvertMSILNames(method.ReturnType));

                var methodInfo = new plsql_msil.Types.MethodInfo(method.Name, retType, false, classType);

                foreach(var item in method.GetParameters())
                {
                    var varType = storage.GetType(ConvertMSILNames(item.ParameterType));

                    methodInfo.AddArg(item.Name, varType);
                }
            }
        }

        private void BuildPackage(PackageType packageType, System.Type type)
        {
            var fields = type.GetFields().Where(x => x.IsPublic && x.IsStatic && IsSimpleType(x.FieldType));

            foreach (var field in fields)
            {
                var fieldType = storage.GetType(ConvertMSILNames(field.FieldType));

                packageType.AddField(field.Name, fieldType);
            }

            var methods = type.GetMethods().Where(x => 
                x.IsPublic && x.IsStatic 
                && IsSimpleType(x.ReturnType) 
                && x.GetParameters().ToList().TrueForAll(y => IsSimpleType(y.ParameterType)));

            foreach (var method in methods)
            {
                var retType = storage.GetType(ConvertMSILNames(method.ReturnType));

                var methodInfo = new plsql_msil.Types.MethodInfo(method.Name, retType, true, packageType);

                foreach (var item in method.GetParameters())
                {
                    var varType = storage.GetType(ConvertMSILNames(item.ParameterType));

                    methodInfo.AddArg(item.Name, varType);
                }

                packageType.AddMethod(methodInfo);
            }

        }

        private static Dictionary<string, string> primitiveTypes = new Dictionary<string, string>()
        {
            {"Int32", "int"},
            {"Char", "char"},
            {"Double", "double"},
            {"Float", "float"},
            {"String", "string"},
            {"Void", "void"}

        };

        private string ConvertMSILNames(System.Type type)
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
