using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Types
{
    enum Type
    {
        Simple, Class, Package, Record, Table, Generic
    }

    abstract class TypeInfo
    {
        public TypeInfo(string name, bool isImplemented = false)
        {
            Name = name;
            IsImplemented = isImplemented;
        }

        public string Name { get; protected set; }
        public virtual Type Type { get; protected set; }
        public virtual List<ConstructorInfo> Constructors { get { return null; } }
        public virtual List<MethodInfo> Methods { get { return null;} }
        public virtual List<VarInfo> Fields { get { return null; } }      
        public virtual List<TypeInfo> Types { get { return null; } }
        public bool IsImplemented { get; set; }

        public virtual string LibName { get; protected set; }
        public virtual string Namespace { get; protected set; }
        public virtual bool IsLibClass { get; protected set; }

        public virtual bool CanBeAssignedWith(TypeInfo info)
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

        public virtual bool ContainsConstructor(List<TypeInfo> args)
        {
            return false;
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
