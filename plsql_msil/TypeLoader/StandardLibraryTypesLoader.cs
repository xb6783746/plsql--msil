using plsql_msil.TypeLoader;
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

            classLoader = new ClassLoader(storage);
            packageLoader = new PackageLoader(storage);

            LoadTypes(libs);

            return storage;
        }

        private TypeStorage storage;
        private List<System.Type> libTypes = new List<System.Type>();

        private ClassLoader classLoader;
        private PackageLoader packageLoader;

        private void GetSimpleTypes(TypeStorage storage)
        {

            storage.AddType(Types.TypeInfo.Int);
            storage.AddType(Types.TypeInfo.Char);
            storage.AddType(Types.TypeInfo.Double);
            storage.AddType(Types.TypeInfo.Bool);
            storage.AddType(Types.TypeInfo.Float);
            storage.AddType(Types.TypeInfo.String);
            storage.AddType(Types.TypeInfo.Void);
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
                .Where(x => x.IsClass && x.IsPublic);

            libTypes.AddRange(types);

            foreach (var item in types)
            {
                storage.AddType(GetTypeInfo(item));
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
                typeInfo = new PackageType(type.Assembly.GetName().Name, type.Namespace, type.Name, true);
            }
            else
            {
                typeInfo = new ClassType(type.Assembly.GetName().Name, type.Namespace, type.Name, true);
            }

            return typeInfo;
        }

        private void BuildType(System.Type type)
        {
            var typeInfo = storage.GetType(type.Name);

            if (type.IsAbstract)
            {
                packageLoader.Build(typeInfo as PackageType, type);
            }
            else
            {
                classLoader.Build(typeInfo as ClassType, type);
            }
        }

        //private void BuildPackage(PackageType packageType, System.Type type)
        //{
        //    var fields = type.GetFields().Where(x => x.IsPublic && x.IsStatic && IsSimpleType(x.FieldType));

        //    foreach (var field in fields)
        //    {
        //        var fieldType = storage.GetType(ConvertMSILNames(field.FieldType));

        //        packageType.AddField(field.Name, fieldType);
        //    }

        //    var methods = type.GetMethods().Where(x => 
        //        x.IsPublic && x.IsStatic 
        //        && IsSimpleType(x.ReturnType) 
        //        && x.GetParameters().ToList().TrueForAll(y => IsSimpleType(y.ParameterType)));

        //    foreach (var method in methods)
        //    {
        //        var retType = storage.GetType(ConvertMSILNames(method.ReturnType));

        //        var methodInfo = new plsql_msil.Types.MethodInfo(method.Name, retType, true, packageType);

        //        foreach (var item in method.GetParameters())
        //        {
        //            var varType = storage.GetType(ConvertMSILNames(item.ParameterType));

        //            methodInfo.AddArg(item.Name, varType);
        //        }

        //        packageType.AddMethod(methodInfo);
        //    }

        //}


    }
}
