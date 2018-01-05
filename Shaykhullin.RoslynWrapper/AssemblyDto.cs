using System.Reflection;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;

namespace Shaykhullin.RoslynWrapper
{
  public class AssemblyDto
  {
    public Assembly Assembly { get; set; }
    public bool Success { get; set; }
    public IEnumerable<Diagnostic> Errors { get; set; }
  }
}