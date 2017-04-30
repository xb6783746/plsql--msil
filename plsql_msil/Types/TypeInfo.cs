using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Types
{
    abstract class TypeInfo
    {
        public TypeInfo(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
        public bool IsGenericImplementation { get; private set; }
        public int GenericPosition { get; private set; }

        public TypeInfo Generic(int pos)
        {
            var res = MemberwiseClone() as TypeInfo;

            res.IsGenericImplementation = true;
            res.GenericPosition = pos;

            return res;
        }

        public virtual bool CanBeAssignedWith(TypeInfo info)
        {
            return Equals(info);
        }

        public override bool Equals(object obj)
        {
            var type = obj as TypeInfo;

            return type != null && type.Name == Name;
        }
        public override string ToString()
        {
            return Name;
        }

        private static TypeInfo bool_ = new SimpleType(SimpleTypeEnum.Bool);
        private static TypeInfo int_ = new SimpleType(SimpleTypeEnum.Int);
        private static TypeInfo char_ = new SimpleType(SimpleTypeEnum.Char);
        private static TypeInfo byte_ = new SimpleType(SimpleTypeEnum.Byte);
        private static TypeInfo double_ = new SimpleType(SimpleTypeEnum.Double);
        private static TypeInfo string_ = new SimpleType(SimpleTypeEnum.String);
        private static TypeInfo float_ = new SimpleType(SimpleTypeEnum.Float);
        private static TypeInfo null_ = new SimpleType(SimpleTypeEnum.Null);
        private static TypeInfo void_ = new SimpleType(SimpleTypeEnum.Void);
        private static TypeInfo undefined = new SimpleType(SimpleTypeEnum.Undefined);

        public static TypeInfo Bool
        {
            get { return bool_; }
        }
        public static TypeInfo Int
        {
            get { return int_; }
        }
        public static TypeInfo Char
        {
            get { return char_; }
        }
        public static TypeInfo Byte
        {
            get { return byte_; }
        }
        public static TypeInfo Double
        {
            get { return double_; }
        }
        public static TypeInfo String
        {
            get { return string_; }
        }
        public static TypeInfo Float
        {
            get { return float_; }
        }
        public static TypeInfo Void
        {
            get { return void_; }
        }
        public static TypeInfo Null
        {
            get { return null_; }
        }
        public static TypeInfo Undefined
        {
            get { return undefined; }
        }

        public static bool Compare(IEnumerable<TypeInfo> first, IEnumerable<TypeInfo> second)
        {

            return first.SequenceEqual(second);
        }

    }
}
