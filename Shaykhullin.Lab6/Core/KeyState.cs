using System.Windows.Forms;

namespace Shaykhullin.Lab6
{
	public class KeyState
	{
		public bool ControlPressed { get; private set; }
		public bool ShiftPressed { get; private set; }
		public bool AltPressed { get; private set; }

		public void Update(KeyEventArgs keyArgs)
		{
			ControlPressed = keyArgs.Control;
			AltPressed = keyArgs.Alt;
			ShiftPressed = keyArgs.Shift;
		}
	}
}