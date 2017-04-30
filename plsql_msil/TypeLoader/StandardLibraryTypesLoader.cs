using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using plsql_msil.Types;

namespace plsql_msil.TypeLoader
{
    class StandardLibraryTypesLoader
    {
        public StandardLibraryTypesLoader(CSNameConvertor nameConvertor)
        {
            this.nameConvertor = nameConvertor;
        }

        public TypeStorage Load(List<string> libs)
        {

            var assemblies = libs.Select(Assembly.LoadFrom).ToList();
            return Load(assemblies);
        }

        public TypeStorage Load(List<Assembly> libs)
        {
            storage = new TypeStorage();
            GetSimpleTypes(storage);

            map.Add(GenericTypeEnum.Table, "List");
            map.Add(GenericTypeEnum.Dictionary, "Dictionary");

            classLoader = new ClassLoader(storage, nameConvertor);
            packageLoader = new PackageLoader(storage, nameConvertor);
            genericLoader = new GenericLoader(storage, nameConvertor);

            LoadTypes(libs);

            return storage;
        }

        private TypeStorage storage;
        private CSNameConvertor nameConvertor;

        private ClassLoader classLoader;
        private PackageLoader packageLoader;
        private GenericLoader genericLoader;

        private Dictionary<GenericTypeEnum, string> map = new Dictionary<GenericTypeEnum, string>();

        private void GetSimpleTypes(TypeStorage storage)
        {

            storage.AddType(Types.TypeInfo.Int);
            storage.AddType(Types.TypeInfo.Byte);
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
                GetTypeInfo(item);
            }

            foreach (var item in types)
            {
                BuildType(item);
            }
        }

        private void GetTypeInfo(System.Type stype)
        {

            if (stype.IsGenericType)
            {
                var template = new GenericTemplate(stype.Name, stype.GetGenericArguments().Length);

                storage.AddTemplate(template);
            }
            else
            {
                var type = stype.IsAbstract
                    ? new PackageType(stype.Name)
                    : new ClassType(stype.Name);

                storage.AddType(type);
            }

            nameConvertor.Register(stype.Assembly.GetName().Name, stype.Namespace, stype.Name, stype.Name);
        }

        private void BuildType(System.Type type)
        {
            if (type.IsGenericType)
            {
                var genericTemplate = storage.GetTemplate(type.Name);

                genericLoader.Build(genericTemplate, type);
            }
            else
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
}
