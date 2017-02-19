using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration.Builders
{
    class EntryPointBuilder :MethodBuilder
    {
        public EntryPointBuilder(MethodInfo methodInfo)
            : base(methodInfo, true)
        {
        }

        private StringBuilder classTemplate = new StringBuilder(
@"
.class private auto ansi beforefieldinit commands.Program
       extends [mscorlib]System.Object
{

{__main}

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .maxstack  0
  }

  .method private hidebysig specialname rtspecialname static 
          void  .cctor() cil managed
  {
    .maxstack  0
  }

} // end of class commands.Program
"
);

        public override string Generate()
        {
            string tmp = base.Generate();

            classTemplate.Replace("{__main}", tmp);

            return classTemplate.ToString();
        }
    }
}
