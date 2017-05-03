using plsql_msil.AstNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsqlBasic.Loggers;

namespace plsql_msil.Semantic
{
    class Analyser
    {

        protected struct VarStruct
        {
            public VarStruct(string name, TypeInfo type) : this()
            {
                this.Name = name;
                this.Type = type;
            }

            public string Name { get; private set; }
            public TypeInfo Type { get; private set; }
        }
        protected struct MethodStruct
        {
            public MethodStruct(string name, TypeInfo ret, List<VarStruct> args, bool isStatic) : this()
            {
                this.Name = name;
                this.Ret = ret;
                this.Args = args;
                Static = isStatic;
            }

            public string Name { get; private set; }
            public TypeInfo Ret { get; private set; }
            public List<VarStruct> Args { get; private set; }
            public bool Static { get; private set; }
        }

        public Analyser(TypeStorage types, ILogger logger)
        {
            this.logger = logger;
            this.types = types;

            builder = new TypesBuilder(types);
        }

        public bool Error { get; protected set; }
        protected ILogger logger;

        protected TypeStorage types;
        protected TypesBuilder builder;

        protected VarStruct GetVar(VarDefNode node)
        {
            string name = node.VarName;

            var type = builder.Build(node.VarType);

            VarStruct var = new VarStruct(name, type);

            if (type == null)
            {
                Log(
                    string.Format("У переменной {0} тип {1} не существует",
                        name,
                        node.VarType.TypeName),
                    node);
            }

            return var;

        }

        protected MethodStruct GetMethod(MethodDeclNode node)
        {

            var type = builder.Build(node.Ret);

            if (type == null)
            {
                Log(
                    string.Format(
                        "В методе {0} возвращаемый тип {1} не существует",
                        node.MethodName,
                        node.Ret.TypeName),
                    node);

                type = TypeInfo.Undefined;
            }

            var args = new List<VarStruct>();

            foreach (var item in node.Vars)
            {
                var varInfo = GetVar(item);

                if (args.Exists(x => x.Name == varInfo.Name))
                {
                    Log(
                        string.Format("В методе {0} аргумент с именем {1} уже встречается", node.MethodName, varInfo.Name),
                        node);
                }

                args.Add(varInfo);
            }

            return new MethodStruct(node.MethodName, type, args, IsStatic(node.Modifier));

        }

        protected bool IsStatic(string str)
        {
            return str.ToLower().Trim() == "static";
        }


        protected void Log(string message, BasicNode node, LogLevel logLevel = LogLevel.Error)
        {
            if (logLevel == LogLevel.Error)
            {
                Error = true;
            }

            if (node != null)
            {
                message = string.Format("{0}, строка {1}", message, node.Line);
            }

            logger.Log(message, logLevel);
        }

    }

   
}