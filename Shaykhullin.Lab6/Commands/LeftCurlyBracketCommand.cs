using System;
using System.Threading;
using System.Threading.Tasks;
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

  public class EnterBracketCommand : Command
  {
    public override Keys Key => Keys.Enter;

    public override void Apply(RichTextBox code)
    {
      var selected = code.SelectionStart;
      if(code.Text.Length != selected 
        && code.Text[selected - 1] == '{' 
        && code.Text[selected] == '}')
      {
        Task.Run(() =>
        {
          CodeEditor.LockWindowUpdate(code.Handle);
          Thread.Sleep(70);
          code.Text = code.Text.Insert(selected + 1, "\t\n");
          code.SelectionStart = selected + 2;
          CodeEditor.LockWindowUpdate(IntPtr.Zero);
        });
      }
    }
  }
}
