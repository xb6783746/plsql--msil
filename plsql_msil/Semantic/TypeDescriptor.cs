using plsql_msil.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plsql_msil.Semantic
{
    class TypeDescriptor
    {
        public TypeDescriptor(bool isLvalue, TypeInfo type)
        {
            IsLvalue = isLvalue;
            Type = type;
        }
        public TypeDescriptor(bool isLvalue, TypeInfo type, bool isObject) :this(isLvalue, type)
        {
            IsObject = isObject;
        }

        public bool IsLvalue
        {
            get;
            private set;
        }
        public bool IsObject
        {
            get;
            private set;
        }
        public TypeInfo Type
        {
            get;
            private set;
        }

        public static TypeDescriptor Int
        {
            get { return new TypeDescriptor(false, TypeInfo.Int); }
        }
        public static TypeDescriptor Char
        {
            get { return new TypeDescriptor(false, TypeInfo.Char); }
        }
        public static TypeDescriptor Double
        {
            get { return new TypeDescriptor(false, TypeInfo.Double); }
        }
        public static TypeDescriptor Bool
        {
            get { return new TypeDescriptor(false, TypeInfo.Bool); }
        }
        public static TypeDescriptor String
        {
            get { return new TypeDescriptor(false, TypeInfo.String); }
        }
        public static TypeDescriptor Float
        {
            get { return new TypeDescriptor(false, TypeInfo.Float); }
        }
        public static TypeDescriptor Void
        {
            get { return new TypeDescriptor(false, TypeInfo.Void); }
        }
        public static TypeDescriptor Undefined
        {
            get { return new TypeDescriptor(false, TypeInfo.Undefined); }
        }
        public static TypeDescriptor Null
        {
            get { return new TypeDescriptor(false, TypeInfo.Null); }
        }
    }
}
