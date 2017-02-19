using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Types
{
    enum Type
    {
        Simple, Class, Package, Record, Table
    }

    abstract class TypeInfo
    {
        public TypeInfo(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
        public virtual Type Type { get; protected set; }
        public virtual List<MethodInfo> Methods { get { return null;} }
        public virtual List<VarInfo> Fields { get { return null; } }
        public virtual List<TypeInfo> Types { get { return null; } }

        public virtual string LibName { get; protected set; }
        public virtual string Namespace { get; protected set; }
        public virtual bool IsLibClass { get; protected set; }

        public virtual bool IsCompatible(TypeInfo info)
        {
            return Equals(info);
        }

        public virtual TypeInfo GetType(string typeName)
        {
            return null;
        }
        public virtual VarInfo GetField(string memberName)
        {
            return null;
        }
        public virtual MethodInfo GetMethod(string methodName, List<TypeInfo> args, bool isStatic)
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            var type = obj as TypeInfo;

            return type != null && type.Name == Name;
        }
        public override string ToString()
        {
            return Type.ToString() + "." + Name;
        }

        private static TypeInfo bool_ = new SimpeType(SimpleTypeEnum.Bool);
        private static TypeInfo int_ = new SimpeType(SimpleTypeEnum.Int);
        private static TypeInfo char_ = new SimpeType(SimpleTypeEnum.Char);
        private static TypeInfo double_ = new SimpeType(SimpleTypeEnum.Double);
        private static TypeInfo string_ = new SimpeType(SimpleTypeEnum.String);
        private static TypeInfo float_ = new SimpeType(SimpleTypeEnum.Float);
        private static TypeInfo null_ = new SimpeType(SimpleTypeEnum.Null);
        private static TypeInfo void_ = new SimpeType(SimpleTypeEnum.Void);
        private static TypeInfo undefined = new SimpeType(SimpleTypeEnum.Undefined);

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
