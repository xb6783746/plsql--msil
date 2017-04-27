using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    class CSNameConvertor :INameConvertor
    {
        private static Dictionary<SimpleTypeEnum, string> simpleTypes = new Dictionary<SimpleTypeEnum, string>()
        {
            {SimpleTypeEnum.Int, "int32"},
            {SimpleTypeEnum.Byte, "uint8"},
            {SimpleTypeEnum.Char, "char"},
            {SimpleTypeEnum.Double, "float64"},
            {SimpleTypeEnum.Float, "float32"},
            {SimpleTypeEnum.String, "string"},
            {SimpleTypeEnum.Bool, "bool"},
            {SimpleTypeEnum.Void, "void"}
        };

        public CSNameConvertor()
        {
            this.defaultNamespace = "commands";
        }

        private string defaultNamespace;

        private Dictionary<string, string> names = new Dictionary<string, string>();

        public void Register(string name, string convertedName)
        {
            names[name] = String.Format("class {0}.{1}", defaultNamespace, convertedName);
        }
        public void Register(string libName, string _namespace, string name, string convertedName)
        {
            names[name] = String.Format("class [{0}]{1}.{2}", libName, _namespace, convertedName);
        }

        public string Convert(TypeInfo type)
        {
            if (type is GenericClassType)
            {
                return GenericType(type as GenericClassType);
            }

            if (names.ContainsKey(type.Name))
            {
                return names[type.Name];
            }

            if (type is SimpleType)
            {
                return SimpleTypes(type as SimpleType);
            }

            throw new Exception();

        }

        private static string SimpleTypes(SimpleType type)
        {
            return simpleTypes[type.SType];
        }

        private string GenericType(GenericClassType type)
        {

            string prefix = names[type.Name];

            prefix += "<" + Convert(type.ItemsType[0]);

            for (int i = 0; i < type.ItemsType.Length; i++)
            {
                prefix += ", " + Convert(type.ItemsType[i]);
            }

            prefix += ">";

            return prefix;
        }

        public string FromPlatformName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
