using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Shaykhullin.RoslynWrapper
{
  public class CSharpSyntaxTreeAnalyzer
  {
    private readonly string source;

    public CSharpSyntaxTreeAnalyzer(string source)
    {
      this.source = source;
    }

    public SyntaxTree CreateSyntaxTree()
    {
      return CSharpSyntaxTree.ParseText(source);
    }
  }
}