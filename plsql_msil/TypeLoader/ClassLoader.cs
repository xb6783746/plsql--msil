using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConstructorInfo = plsql_msil.Types.ConstructorInfo;

namespace plsql_msil.TypeLoader
{
    class ClassLoader :AbstractTypeLoader
    {

        public ClassLoader(TypeStorage storage): base(storage)
        {
        }

        public void Build(ClassType classType, System.Type type)
        {
            base.Build(classType, type, (x) => x.IsPublic && !x.IsStatic, (x) => x.IsPublic && !x.IsStatic);

            var constrInfo = type.GetConstructors().Where(x => x.IsPublic && !x.IsStatic);

            foreach (var item in constrInfo)
            {
                BuildConstructor(classType, item);
            }
        }

        private void BuildConstructor(ClassType classType, System.Reflection.ConstructorInfo constructorInfo)
        {
            var args = constructorInfo.GetParameters().Select(
                x => new { Type = storage.GetType(ConvertMSILNames(x.ParameterType)), Name = x.Name });

            if (!args.Any(x => x.Type == null))
            {
                var constructor = new ConstructorInfo(false, classType);

                foreach (var item in args)
                {
                    constructor.AddArg(item.Name, item.Type);
                }

                classType.AddConstructor(constructor);
            }

        }
    }
}
