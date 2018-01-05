using System.Windows.Forms;

namespace Shaykhullin.Lab6.Commands
{
  public abstract class Command
  {
    public virtual bool RequireControl { get; }
    public virtual bool RequireShift { get; }
    public virtual bool RequireAlt { get; }
    public abstract Keys Key { get; }

    public bool IsSatisfied(Keys key, KeyState state)
    {
      return Key == key
        && RequireControl == state.ControlPressed
        && RequireShift == state.ShiftPressed
        && RequireAlt == state.AltPressed;
    }

    public abstract void Apply(RichTextBox code);
  }
}
