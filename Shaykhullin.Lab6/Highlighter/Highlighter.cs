using System.Drawing;
using System.Windows.Forms;

namespace Shaykhullin.Lab6
{
  public abstract class Highlighter
  {
    public abstract string Keyword { get; }
    public abstract Color Color { get; }

    public bool IsSatisfied(string keyword, int index)
    {
      for (int i = 0; i < Keyword.Length; i++)
      {
        if (index + i >= keyword.Length || keyword[index + i] != Keyword[i])
          return false;
      }

      return true;
    }

    public virtual void Apply(RichTextBox editor)
    {
      editor.SelectionLength = Keyword.Length;
      editor.SelectionColor = Color;
      editor.SelectionStart += Keyword.Length;
      editor.SelectionLength = 0;
    }
  }
}