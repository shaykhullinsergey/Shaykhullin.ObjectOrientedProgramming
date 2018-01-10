using System.Windows.Forms;

namespace Shaykhullin.Lab6.Commands
{
  public class LeftCurlyBracketCommand : Command
  {
    public override Keys Key => Keys.OemOpenBrackets;
    public override bool RequireShift => true;

    public override void Apply(RichTextBox code)
    {
      var selected = code.SelectionStart;
      code.Text = code.Text.Insert(code.SelectionStart, "}");
      code.SelectionStart = selected;
    }
  }
}
