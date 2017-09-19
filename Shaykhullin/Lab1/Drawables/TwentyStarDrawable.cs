using System;
using System.Drawing;

namespace Shaykhullin.Shared.Lab1.Drawables
{
  public class TwentyStarDrawable : DrawableBase
  {
    protected override Pen Pen { get; } = new Pen(Color.FromArgb(255, 247, 219, 187), 3.0f);
    protected override Brush Brush { get; } = new SolidBrush(Color.FromArgb(255, 143, 25, 35));

    public TwentyStarDrawable() : base(40)
    {
      for (int i = 0; i < Points.Length / 2; i++)
      {
        Points[i * 2] = Quaternion.Factory
          .With(Math.Cos(i * 18 * Math.PI / 180) * 100,
            Math.Sin(i * 18 * Math.PI / 180) * 100);
        Points[i * 2 + 1] = Quaternion.Factory
          .With(Math.Cos((i * 18 + 11) * Math.PI / 180) * 50,
            Math.Sin((i * 18 + 11) * Math.PI / 180) * 50);
      }
    }
  }
}
