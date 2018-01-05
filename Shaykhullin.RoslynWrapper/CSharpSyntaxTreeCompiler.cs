using System.IO;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Shaykhullin.RoslynWrapper
{
  public class CSharpSyntaxTreeCompiler
  {
    private SyntaxTree syntaxTree;
    private IEnumerable<Assembly> referencedAssemblies;
    private OptimizationLevel optimizationLevel;

    public CSharpSyntaxTreeCompiler(CSharpSyntaxTreeAnalyzer syntaxTreeAnalyzer, 
      IEnumerable<Assembly> referencedAssemblies = null,
      OptimizationLevel optimizationLevel = OptimizationLevel.Debug)
    {
      syntaxTree = syntaxTreeAnalyzer.CreateSyntaxTree();
      this.referencedAssemblies = referencedAssemblies;
      this.optimizationLevel = optimizationLevel;
    }

    public CSharpCompilation CompileSyntaxTree()
    {
      return CSharpCompilation.Create(
        assemblyName: Path.GetRandomFileName(),
        syntaxTrees: new[] { syntaxTree },
        references: referencedAssemblies?.Select(assembly =>
          MetadataReference.CreateFromFile(assembly.Location)),
        options: new CSharpCompilationOptions(
          outputKind: OutputKind.DynamicallyLinkedLibrary,
          allowUnsafe: true,
          optimizationLevel: optimizationLevel));
    }
  }
}