using System;
using System.Collections.Generic;
using System.Text;
using plsql_msil.Types;

namespace plsql_msil.Codegeneration.Builders
{
    class ModuleBuilder : Builder
    {

        public ModuleBuilder(List<LibraryInfo> libs)
        {
            BuildAssemblies(libs);
        }

        private MethodBuilder entryPoint;

        private string assemblyTemplate =
@"
.assembly extern {__name}
{
  .ver {__version}
}
";
        private StringBuilder template = new StringBuilder(
@"
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 4:0:0:0
}
{__assemblies}
.assembly commands
{
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 31 36 00 00 )                            //  2016..
  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 08 63 6F 6D 6D 61 6E 64 73 00 00 )          // ...commands..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 08 63 6F 6D 6D 61 6E 64 73 00 00 )          // ...commands..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1A 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 35 01 00 54   // ,Version=v4.5..T
                                                                                                        0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C   // ..FrameworkDispl
                                                                                                        61 79 4E 61 6D 65 12 2E 4E 45 54 20 46 72 61 6D   // ayName..NET Fram
                                                                                                        65 77 6F 72 6B 20 34 2E 35 )                      // ework 4.5
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 31 31 38 63 66 61 30 38 2D 38 30 39 63   // ..$118cfa08-809c
                                                                                                  2D 34 39 35 66 2D 62 31 30 65 2D 31 65 31 38 33   // -495f-b10e-1e183
                                                                                                  30 66 39 39 64 66 35 00 00 )                      // 0f99df5..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.
  .permissionset reqmin
             = {[mscorlib]System.Security.Permissions.SecurityPermissionAttribute = {property bool 'SkipVerification' = bool(true)}}
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module commands.exe
// MVID: {D3F04551-31AA-4598-A1F6-9D39F2DA4BCD}
.custom instance void [mscorlib]System.Security.UnverifiableCodeAttribute::.ctor() = ( 01 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x00870000

{__classes}
");
        private void BuildAssemblies(List<LibraryInfo> libs)
        {
            var res = new StringBuilder();

            foreach(var item in libs)
            {
                var builder = new StringBuilder(assemblyTemplate);

                builder.Replace("{__name}", item.LibName);
                builder.Replace("{__version}", item.Version.Replace('.', ':'));

                res.AppendLine(builder.ToString());
            }

            template.Replace("{__assemblies}", res.ToString());
        }

        public ClassBuilder BuildClass(ClassType classType)
        {
            var classBuilder = new ClassBuilder(classType);
            builders.Add(classBuilder);

            return classBuilder;
        }
        public PackageBuilder BuildPackage(PackageType packageType)
        {
            var packageBuilder = new PackageBuilder(packageType);
            builders.Add(packageBuilder);

            return packageBuilder;
        }

        public MethodBuilder BuildEntryPoint(List<VarInfo> localVars)
        {
            if(entryPoint != null)
            {
                throw new Exception("Точка входа уже определена");
            }

            var methodInfo = new MethodInfo("main", TypeInfo.Void, true, null);

            foreach(var item in localVars)
            {
                methodInfo.AddVar(item.Name, item.Type);
            }

            entryPoint = new EntryPointBuilder(methodInfo);

            builders.Add(entryPoint);

            return entryPoint;
        }

        public override string Generate()
        {
            string classes =  base.Generate();

            template.Replace("{__classes}", classes);

            return template.ToString();
        }
    }
}
