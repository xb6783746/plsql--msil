using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using plsql_msil.Types;

namespace plsql_msil.TypeLoader
{
    class StandardLibraryTypesLoader
    {
        public TypeStorage Load(List<string> libs)
        {

            var assemblies = libs.Select(Assembly.LoadFrom).ToList();
            return Load(assemblies);
        }
        public TypeStorage Load(List<Assembly> libs)
        {
            storage = new TypeStorage();
            GetSimpleTypes(storage);

            classLoader = new ClassLoader(storage);
            packageLoader = new PackageLoader(storage);

            LoadTypes(libs);

            return storage;
        }

        private TypeStorage storage;

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


        private void LoadTypes(List<Assembly> libs)
        {
            foreach (var item in libs)
            {
                LoadTypes(item);
            }
        }

        private void LoadTypes(Assembly assembly)
        {

            storage.Libs.Add(
                new LibraryInfo(
                    assembly.GetName().Name, 
                    assembly.GetName().Version.ToString()
                    )
                  );

            var types = assembly
                .GetTypes()
                .Where(x => x.IsClass && x.IsPublic);

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

            return type.IsAbstract ? 
                  new PackageType(type.Assembly.GetName().Name, type.Namespace, type.Name, true) 
                : new ClassType(type.Assembly.GetName().Name, type.Namespace, type.Name, true);
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


    }
}
