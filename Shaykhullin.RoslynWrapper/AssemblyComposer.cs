using System.IO;
using System.Linq;
using System.Reflection;

using Microsoft.CodeAnalysis;

namespace Shaykhullin.RoslynWrapper
{
  public class AssemblyComposer
  {
    private Compilation compiledSyntaxTree;

    public AssemblyComposer(CSharpSyntaxTreeCompiler syntaxTreeCompiler)
    {
      compiledSyntaxTree = syntaxTreeCompiler.CompileSyntaxTree();
    }

    public AssemblyDto ComposeAssembly()
    {
      using (var stream = new MemoryStream())
      {
        var result = compiledSyntaxTree.Emit(stream);
        var assemblyDto = new AssemblyDto
        {
          Success = result.Success
        };

        if (result.Success)
        {
          stream.Seek(0, SeekOrigin.Begin);
          assemblyDto.Assembly = Assembly.Load(stream.ToArray());
        }
        else
        {
          assemblyDto.Errors = result.Diagnostics.Where(diagnostic =>
          diagnostic.IsWarningAsError ||
          diagnostic.Severity == DiagnosticSeverity.Error);
        }

        return assemblyDto;
      }
    }
  }
}