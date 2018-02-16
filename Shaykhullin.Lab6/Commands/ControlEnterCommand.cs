using System.Windows.Forms;

namespace Shaykhullin.Lab6.Commands
{
	public class ControlEnterCommand : Command
	{
		public override Keys Key => Keys.Enter;
		public override bool RequireControl => true;

		public override void Apply(RichTextBox code)
		{
			var shiftAmount = 0;

			for (var i = code.SelectionStart - 1; i > 0; i--)
			{
				if (code.Text[i] == '\n')
				{
					break;
				}

				shiftAmount++;
			}

			code.SelectionStart -= shiftAmount + 1;
		}
	}
}