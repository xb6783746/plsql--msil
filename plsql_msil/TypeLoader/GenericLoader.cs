using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConstructorInfo = plsql_msil.Types.ConstructorInfo;
using TypeInfo = plsql_msil.Types.TypeInfo;

namespace plsql_msil.TypeLoader
{
    class TypeWithName
    {
        public TypeWithName(TypeInfo type, string name)
        {
            this.type = type;
            this.name = name;
        }

        public TypeInfo type;
        public string name;
    }

    class GenericLoader :AbstractTypeLoader
    {

        public GenericLoader(TypeStorage storage, CSNameConvertor nameConvertor)
            : base(storage, nameConvertor)
        {
        }

        public void Build(GenericTemplate templateType, System.Type type)
        {

            var methods = type.GetMethods().Where(x => x.IsPublic && !x.IsStatic);

            foreach (var method in methods)
            {
                BuildMethod(templateType, method);
            }

            var constrInfo = type.GetConstructors().Where(x => x.IsPublic && !x.IsStatic);

            foreach (var item in constrInfo)
            {
                BuildConstructor(templateType, item);
            }
        }

        private void BuildConstructor(GenericTemplate classType, System.Reflection.ConstructorInfo constructorInfo)
        {
            var args = constructorInfo.GetParameters().Select(
              x => new TypeWithName(
              
                  x.ParameterType.FullName == null? 
                      GenericType.Get(x.ParameterType.GenericParameterPosition):
                      storage.GetType(ConvertMSILNames(x.ParameterType)), 
                  x.Name
              )).ToList();

            if (!args.Any(x => x.type == null))
            {
                classType.AddConstructor(args);
            }
        }

        private void BuildMethod(GenericTemplate classType, System.Reflection.MethodInfo type)
        {
            var list = new List<TypeWithName>();

            foreach (var item in type.GetParameters())
            {
                if (item.ParameterType.FullName == null)
                {
                    list.Add(new TypeWithName(GenericType.Get(item.ParameterType.GenericParameterPosition), item.Name));
                }
                else
                {
                    var itemType = storage.GetType(ConvertMSILNames(item.ParameterType));
                    list.Add(new TypeWithName(itemType, item.Name));
                }
            }

            var retType = type.ReturnType.FullName == null
                ? GenericType.Get(type.ReturnType.GenericParameterPosition)
                : storage.GetType(ConvertMSILNames(type.ReturnType));

            classType.AddMethod(type.Name, list, retType, false);
        }
    }
}
