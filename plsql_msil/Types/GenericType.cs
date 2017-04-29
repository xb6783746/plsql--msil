using System.Collections.Generic;
using plsql_msil.Types.VarTypes;

namespace plsql_msil.Types
{
    class GenericType :TypeInfo
    {
        public GenericType(int num, TypeInfo realType = null)
            : base(realType == null? "" : realType.Name)
        {
            Number = num;
            RealType = realType;

        }
        public GenericType():base("!0")
        {

        }

        public TypeInfo RealType { get; private set; }

        public int Number { get; private set; }

        public static TypeInfo Get(int num)
        {
            return new GenericType(num);
        }

        public override Type Type { get; protected set; }

        public override List<ConstructorInfo> Constructors
        {
            get { return RealType.Constructors; }
        }

        public override List<MethodInfo> Methods
        {
            get { return RealType.Methods; }
        }

        public override List<VarInfo> Fields
        {
            get { return RealType.Fields; }
        }

        public override List<TypeInfo> Types
        {
            get { return RealType.Types; }
        }

        public override string LibName
        {
            get { return RealType.LibName; }
        }

        public override string Namespace
        {
            get { return RealType.Namespace; }
        }

        public override bool IsLibClass
        {
            get { return RealType.IsLibClass; }
        }

        public override bool CanBeAssignedWith(TypeInfo info)
        {
            return RealType.CanBeAssignedWith(info);
        }

        public override TypeInfo GetType(string typeName)
        {
            return RealType.GetType(typeName);
        }

        public override VarInfo GetField(string memberName)
        {
            return RealType.GetField(memberName);
        }

        public override MethodInfo GetMethod(string methodName, List<TypeInfo> args, bool isStatic)
        {
            return RealType.GetMethod(methodName, args, isStatic);
        }

        public override bool ContainsConstructor(List<TypeInfo> args)
        {
            return RealType.ContainsConstructor(args);
        }

        public override bool Equals(object obj)
        {
            return RealType.Equals(obj);
        }

        public override string ToString()
        {
            return RealType.ToString();
        }

        public override int GetHashCode()
        {
            return RealType.GetHashCode();
        }
    }
}
