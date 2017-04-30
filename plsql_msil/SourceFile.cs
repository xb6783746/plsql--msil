using Antlr.Runtime.Tree;

namespace plsql_msil
{
    class SourceFile
    {
        public SourceFile(string fileName, CommonTree tree)
        {
            this.FileName = fileName;
            this.Tree = tree;
        }

        public string FileName { get; private set; }
        public CommonTree Tree { get; private set; }
    }
}