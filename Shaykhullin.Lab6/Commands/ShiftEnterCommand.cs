using System.Windows.Forms;

namespace Shaykhullin.Lab6.Commands
{
	public class ShiftEnterCommand : Command
	{
		public override Keys Key => Keys.Enter;
		public override bool RequireShift => true;

		public override void Apply(RichTextBox code)
		{
			var shiftAmount = 0;

			for (var i = code.SelectionStart; i < code.Text.Length; i++)
			{
				if (code.Text[i] == '\n')
				{
					break;
				}

				shiftAmount++;
			}

			code.SelectionStart += shiftAmount;
		}
	}
}