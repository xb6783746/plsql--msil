using System.Collections.Generic;
using System.Linq;
using System.Text;
using plsql_msil.Types;

namespace plsql_msil.Codegeneration.Builders
{
    enum Jump
    {
        IfTrue, IfFalse, Always
    }

    class MethodBuilder : CommandBuilder, IBuilder
    {
        public MethodBuilder(MethodInfo methodInfo, bool isEntryPoint)
        {
            this.methodInfo = methodInfo;

            template.Replace("{__entryPoint}", isEntryPoint? ".entrypoint" : "");

            Build(methodInfo);
            InitLocals(methodInfo);

        }
        public MethodBuilder(MethodInfo methodInfo) :this(methodInfo, false)
        {
        }

        private MethodInfo methodInfo;
        

        private StringBuilder template = new StringBuilder(
@"
.method public hidebysig {__static} {__retType} {__methodName} ({__methodArgs}) cil managed 
 {
	{__entryPoint}
	.maxstack {__maxStack}
	.locals init ({__localVars}) 

{__code}

}
");

        protected virtual void Build(MethodInfo methodInfo)
        {
            template.Replace("{__static}", methodInfo.IsStatic ? "static" : "");
            template.Replace("{__retType}", GetMSILTypeName(methodInfo.Ret));
            template.Replace("{__methodName}", methodInfo.Name);

            template.Replace("{__methodArgs}", GetArgsString(methodInfo.Arguments));

            template.Replace("{__localVars}", GetLocalsString(methodInfo));

        }

        public virtual string Generate()
        {
            template.Replace("{__maxStack}", maxStack.ToString());
            template.Replace("{__code}", GetCode());

            return template.ToString();

        }

        protected string GetArgsString(List<VarInfo> vars)
        {
            var builder = new StringBuilder(" ");

            foreach (var item in vars)
            {
                builder.AppendFormat(" {0} {1},",
                    GetMSILTypeNameWithClass(item.Type),
                    item.Name);
            }

            builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }
        protected string GetLocalsString(MethodInfo methodInfo)
        {
            var builder = new StringBuilder(" ");

            for (int i = 0; i < methodInfo.Vars.Count; i++)
            {
                builder.AppendFormat(
                    " [{0}] {1} {2},",
                    i,
                    GetMSILTypeNameWithClass(methodInfo.Vars[i].Type),
                    methodInfo.Vars[i].Name);
            }

            builder.Remove(builder.Length - 1, 1);

            return builder.ToString();
        }

        private void InitLocals(MethodInfo method)
        {
            var locals = method.Vars.Where(x => x.Type.Type == Types.Type.Record || x.Type.Type == Types.Type.Table);

            foreach(var item in locals)
            {

                DefaultConstructor(item.Type);

                Assign(null, item);
            }
        }

    }
}
