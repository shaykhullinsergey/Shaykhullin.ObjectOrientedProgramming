using System;
using System.Windows.Forms;

namespace Shaykhullin.Shared.Lines
{
  public class FieldCell
  {
    public int X { get; set; }
    public int Y { get; set; }
    public Button Button { get; set; }

    private Ball ball;
    public Ball Ball
    {
      get => ball;
      set
      {
        ball = value;
        Button.Text = ball?.Color ?? "";
      }
    }

    public void GenerateBall(Random rnd)
    {
      if (Ball != null)
      {
        throw new InvalidOperationException("Ball already created");
      }

      var type = rnd.Next(0, 4);
      switch (type)
      {
        case 0: Ball = Ball.Red; break;
        case 1: Ball = Ball.Green; break;
        case 2: Ball = Ball.Blue; break;
        case 3: Ball = Ball.Yellow; break;
      }
    }
  }
}
