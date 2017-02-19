using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Codegeneration
{
    class NameConvertor
    {

        private static Dictionary<SimpleTypeEnum, string> simpleTypes = new Dictionary<SimpleTypeEnum, string>()
        {
            {SimpleTypeEnum.Int, "int32"},
            {SimpleTypeEnum.Char, "char"},
            {SimpleTypeEnum.Double, "double"},
            {SimpleTypeEnum.Float, "float"},
            {SimpleTypeEnum.String, "string"},
            {SimpleTypeEnum.Bool, "bool"},
            {SimpleTypeEnum.Void, "void"}
        };

        private static string tableTemplate =
@"[mscorlib]System.Collections.Generic.List`1<{__itemType}>";

        public static string Convert(TypeInfo type)
        {
            if(type is SimpeType)
            {
                return SimpleTypes(type as SimpeType);
            }

            if (type is TableType)
            {
                return TableType(type as TableType);
            }

            if(type is ClassType)
            {
                return ClassType(type as ClassType);
            }

            if(type is RecordType)
            {
                var recordType = type as RecordType;

                return "commands." + recordType.PackageName + "/" + recordType.RecordName; 
            }

            if(type is GenericType)
            {
                return type.Name;
            }

            throw new Exception();
        }

        private static string SimpleTypes(SimpeType type)
        {
            return simpleTypes[type.SimpleType];
        }

        private static string ClassType(ClassType type)
        {
            if(type.IsLibClass)
            {
                return String.Format("[{0}]{1}.{2}", type.LibName, type.Namespace, type.Name);
            }
            else
            {
                return String.Format("commands.{0}", type.Name);
            }
        }
        private static string TableType(TableType type)
        {
            return String.Format("class [mscorlib]System.Collections.Generic.Dictionary`2<int32,{0}>", Convert(type.ItemsType));
        }
    }
}
