using System;
using System.Collections.Generic;
using System.Text;
using plsql_msil.Types;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Codegeneration.Builders
{
    class ClassBuilder : Builder
    {
        public ClassBuilder(ClassType classType, INameConvertor nameConvertor)
        {
            ClassType = classType;
            this.nameConvertor = nameConvertor;

            Build(classType);

            BuildConstructor();
        }

        public ClassType ClassType { get; private set; }

        private StringBuilder template = new StringBuilder(
@"
.class private auto ansi beforefieldinit commands.{__className} extends [mscorlib]System.Object 
{
{__fields}
{__methodsCode}

{__constructorCode}
}
");

        private INameConvertor nameConvertor;

        protected virtual void Build(ClassType classType)
        {
            template.Replace("{__className}", classType.Name);
            template.Replace("{__fields}", GetFields(classType.Fields, false));

        }

        protected virtual void BuildConstructor()
        {
            var builder = new ConstructorBuilder(ClassType.Constructors[0], nameConvertor); //плохо
            template.Replace("{__constructorCode}", builder.Generate());
        }

        protected string GetFields(List<VarInfo> fields, bool isStatic)
        {
            var builder = new StringBuilder();
            string st = isStatic ? "static" : "";
            foreach (var item in fields)
            {
                builder.AppendFormat(
                    "\t.field public {3} {0} {1};{2}", 
                    GetMSILTypeName(item.Type), 
                    item.Name, Environment.NewLine, 
                    st);
            }

            return builder.ToString();
        }

        public MethodBuilder BuildMethod(MethodInfo methodInfo)
        {
            var methodBuilder = new MethodBuilder(methodInfo, nameConvertor);
            builders.Add(methodBuilder);

            return methodBuilder;
        }

        public override string Generate()
        {
            string tmp = base.Generate();

            template.Replace("{__methodsCode}", tmp);

            return template.ToString();
        }

        private string GetMSILTypeName(TypeInfo type)
        {
            return nameConvertor.Convert(type);
        }
    }
}
