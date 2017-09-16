using System;
using System.Collections.Generic;
using System.Text;

namespace Shaykhullin.Models.Lines
{
  public class Ball
  {
    public string Color { get; set; }

    public static Ball Red { get; } = new Ball { Color = "Red" };
    public static Ball Green { get; } = new Ball { Color = "Green" };
    public static Ball Blue { get; } = new Ball { Color = "Blue" };
    public static Ball Yellow { get; } = new Ball { Color = "Yellow" };
  }
}
