using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.Lab6.Commands
{
  public class BuildCommand : Command
  {
    public override Keys Key => Keys.B;
    public override bool RequireControl => true;
    public override bool RequireShift => true;

    public override void Apply(RichTextBox code)
    {
      MessageBox.Show("Building");
    }
  }
}
