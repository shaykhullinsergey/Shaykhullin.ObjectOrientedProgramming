using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Shaykhullin.Lab6.Commands
{
  public class ControlXCommand : Command
  {
    public override Keys Key => Keys.X;
    public override bool RequireControl => true;

    public override void Apply(RichTextBox code)
    {
      var lineNumber = code.GetLineFromCharIndex(code.SelectionStart);

      var selection = code.SelectionStart;
      code.Lines = ExceptIndex().ToArray();
      code.SelectionStart = selection;

      IEnumerable<string> ExceptIndex()
      {
        for (int i = 0; i < code.Lines.Length; i++)
        {
          if(i != lineNumber)
          {
            yield return code.Lines[i];
          }
        }
      }
    }
  }
}
