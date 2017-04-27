using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration.Builders
{
    class ConstructorBuilder : MethodBuilder
    {

        public ConstructorBuilder(ConstructorInfo type, INameConvertor nameConvertor)
            : base(type, nameConvertor)
        {

            Fill(type);
        }

        private MethodBuilder methodBuilder;

        private string staticConstructorHeader =
@".method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed";

        private string constructorHeader =
@".method public hidebysig specialname rtspecialname 
            instance void  .ctor({__methodArgs}) cil managed";


        private StringBuilder template = new StringBuilder(
@"{__header}
    {
	.maxstack {__maxStack}
	.locals init ( ) 

{__code}
}
");

        protected override void Build(MethodInfo methodInfo)
        {
            template.Replace("{__methodArgs}", GetArgsString(methodInfo.Arguments));
        }

        protected void Fill(ConstructorInfo constructor)
        {
            var type = constructor.Where;
            bool isStatic = constructor.IsStatic;

            template.Replace("{__header}", isStatic ? staticConstructorHeader : constructorHeader);

            template.Replace("{__methodArgs}", GetArgsString(constructor.Arguments));


            if (!isStatic)
            {
                InitFieldsFromConstructor(type, constructor.Arguments);
            }

            InitFields(type, type.Fields.Where(x => x.Type.Type == Types.Type.Record).ToList(), isStatic);
            InitFields(type, type.Fields.Where(x => x.Type.Type == Types.Type.Table).ToList(), isStatic);

            Ret();
        }


        private void InitFieldsFromConstructor(TypeInfo where, List<VarInfo> args)
        {
            foreach (var item in args)
            {
                LoadThis();
                LoadToStack(null, item);

                var field = new VarInfo(item.Name, item.Type, VarLocation.Global);

                Assign(where, field);
            }
        }

        private void InitFields(ClassType classType, List<VarInfo> fields, bool isStatic)
        {
            foreach (var item in fields)
            {
                if (!isStatic)
                {
                    LoadThis();
                }

                DefaultConstructor(item.Type);

                Assign(classType, item);
            }
        }

        public override string Generate()
        {
            template.Replace("{__maxStack}", maxStack.ToString());
            template.Replace("{__code}", GetCode());

            return template.ToString();
        }
    }
}
