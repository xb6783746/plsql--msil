using System.Collections.Generic;

namespace plsql_msil
{
    class CompilerArgs
    {
        public CompilerArgs(List<string> libs, List<string> sourceFiles, 
            bool printTree, string printTreeFile, string outFile, bool all)
        {
            this.Libs = libs;
            this.SourceFiles = sourceFiles;
            this.PrintTree = printTree;
            this.PrintTreeFile = printTreeFile;
            this.OutFile = outFile;
            this.All = all;
        }

        public List<string> Libs { get; private set; }
        public List<string> SourceFiles { get; private set; }
        public bool PrintTree { get; private set; }
        public string PrintTreeFile { get; private set; }
        public string OutFile { get; private set; }
        public bool All { get; private set; }
    }
}