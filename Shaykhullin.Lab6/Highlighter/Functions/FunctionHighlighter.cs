using System.Drawing;

namespace Shaykhullin.Lab6
{
  public abstract class FunctionHighlighter : Highlighter
  {
    public override Color Color => Color.Fuchsia;
  }

  public class WriteLineHighlighter : FunctionHighlighter
  {
    public override string Keyword => "WriteLine";
  }
}
