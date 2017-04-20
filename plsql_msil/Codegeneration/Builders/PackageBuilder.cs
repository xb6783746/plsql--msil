using System.Linq;
using System.Text;
using plsql_msil.Types;

namespace plsql_msil.Codegeneration.Builders
{
    class PackageBuilder : ClassBuilder
    {
        public PackageBuilder(PackageType packageType)
            : base(packageType)
        {

            template.Replace("{__innerTypes}", GetInnerTypes(packageType));
        }

        private const string innerTypeTemplate =
@"
.class auto ansi nested public beforefieldinit {__className}
         extends [mscorlib]System.Object
  {
{__fields}

.method public hidebysig specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      .maxstack  8
      IL_0000:  ldarg.0
      IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
      IL_0006:  ret
    }
  }
";
        private StringBuilder template = new StringBuilder(
@"
.class private abstract auto ansi sealed beforefieldinit commands.{__className}
       extends [mscorlib]System.Object
{
{__innerTypes}
{__fields}
{__methodsCode}

{__constructorCode}
}
");

        protected override void Build(ClassType classType)
        {
            template.Replace("{__className}", classType.Name);
            template.Replace("{__fields}", GetFields(classType.Fields, true));
           
        }

        protected override void BuildConstructor()
        {
            template.Replace("{__constructorCode}", "");
        }

        private string GetInnerTypes(PackageType packageType)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder builder;

            var records = packageType.Types.Where(x => x.Type == Types.Type.Record).Select(x => x as RecordType);

            foreach (var item in records)
            {
                builder = new StringBuilder(innerTypeTemplate);

                builder.Replace("{__className}", item.RecordName);
                builder.Replace("{__fields}", GetFields(item.Vars, false));

                result.AppendLine(builder.ToString());
            }

            return result.ToString();
        }

        public override string Generate()
        {
            string tmp = GetCode();

            template.Replace("{__methodsCode}", tmp);

            return template.ToString();
        }
    }
}
