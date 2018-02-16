using System.Windows.Forms;

namespace Shaykhullin.Lab6.Commands
{
	public class LeftRoundBracketCommand : Command
	{
		public override Keys Key => Keys.D9;
		public override bool RequireShift => true;

		public override void Apply(RichTextBox code)
		{
			var selected = code.SelectionStart;
			code.Text = code.Text.Insert(code.SelectionStart, ")");
			code.SelectionStart = selected;
		}
	}
}