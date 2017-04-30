using Antlr.Runtime.Tree;

namespace plsql_msil.Optimization
{
    internal interface IPass
    {

        void Check(CommonTree tree);
    }
}