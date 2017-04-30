﻿using plsql_msil.AstNodes;
using plsql_msil.AstNodes.MethodNodes;
using plsql_msil.AstNodes.OtherNodes;
using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.AstNodes.TypeNodes;
using plsql_msil.Loggers;
using plsql_msil.Semantic.Passes;

namespace plsql_msil.Semantic
{
    class Analyser
    {

        protected struct VarStruct
        {
            public VarStruct(string name, TypeInfo type)
            {
                Name = name;
                Type = type;
            }

            public string Name;
            public TypeInfo Type;
        }
        protected struct MethodStruct
        {
            public MethodStruct(string name, TypeInfo ret, List<VarStruct> args)
            {
                Name = name;
                Ret = ret;
                Args = args;
            }

            public string Name;
            public TypeInfo Ret;
            public List<VarStruct> Args;
        }


        public bool Error { get; protected set; }
        protected ILogger logger;

        protected TypeStorage types;

        protected VarStruct GetVar(VarDefNode node)
        {
            string name = node.VarName;
            //string typeName = node.VarType.TypeName;

            var type = Visit(node.VarType as dynamic);

            VarStruct var = new VarStruct(name, type.Type);

            if (type.Type == null)
            {
                Log(
                    String.Format("У переменной {0} тип {1} не существует",
                        name,
                        node.VarType.TypeName),
                    node);
            }

            return var;

        }

        protected TypeInfo GenerateTableType(TypeNode node, string name = null)
        {
            var type = Visit(node as dynamic);

            var tableTypeTemplate = types.GetTemplate("List`1");

            return tableTypeTemplate.Generate(name, type.Type);

        }
        protected TypeInfo GenerateDictionaryType(TypeNode kTypeNode, TypeNode valTypeNode, string name = null)
        {
            var type = Visit(kTypeNode as dynamic);

            var valType = Visit(valTypeNode as dynamic);

            var dictTypeTemplate = types.GetTemplate("Dictionary`2");

            return dictTypeTemplate.Generate(name, type.Type, valType.Type);
        }
        protected TypeInfo GenerateArrayType(TypeNode node, string name = null)
        {
            var type = Visit(node as dynamic);

            var arrTypeTemplate = types.GetTemplate("Array`1");

            return arrTypeTemplate.Generate(name, type.Type);
        }

        private TypeDescriptor Visit(TypeNode node)
        {
            return new TypeDescriptor(false, types.GetType(node.TypeName), false);
        }
        private TypeDescriptor Visit(TableTypeNode node)
        {
            var tableType = GenerateTableType(node.TypeNode);

            return new TypeDescriptor(false, tableType, false);
        }
        private TypeDescriptor Visit(DictionaryTypeNode node)
        {
            var dictType = GenerateDictionaryType(node.IndexTypeNode, node.TypeNode);

            return new TypeDescriptor(false, dictType, false);
        }
        private TypeDescriptor Visit(ArrayTypeNode node)
        {
            var arrType = GenerateArrayType(node.TypeNode);

            return new TypeDescriptor(false, arrType, false);
        }

        protected MethodStruct GetMethod(MethodDeclNode node)
        {

            var type = Visit(node.Ret as dynamic);

            if (type.Type == null)
            {
                Log(
                    String.Format(
                        "В методе {0} возвращаемый тип {1} не существует",
                        node.MethodName,
                        node.Ret.TypeName),
                    node);

                type = SimpleType.Undefined;
            }

            var args = new List<VarStruct>();

            foreach (var item in node.Vars)
            {
                var varInfo = GetVar(item);

                if (args.Exists(x => x.Name == varInfo.Name))
                {
                    Log(
                        String.Format("В методе {0} аргумент с именем {1} уже встречается", node.MethodName, varInfo.Name),
                        node);
                }

                args.Add(varInfo);
            }

            return new MethodStruct(node.MethodName, type.Type, args);

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
                message = String.Format("{0}, строка {1}", message, node.Line);
            }

            logger.Log(message, logLevel);
        }

    }
}
