using System;
using System.Drawing;

namespace Shaykhullin.Shared.Lab1.Drawables
{
  public class StarDrawable : DrawableBase
  {
    protected override Pen Pen { get; } = new Pen(Color.FromArgb(255, 133, 52, 183), 5.0f);
    protected override Brush Brush { get; } = new SolidBrush(Color.FromArgb(255, 71, 5, 112));

    public StarDrawable() : base(pointsCount: 10)
    {
      for (int i = 0; i < Points.Length / 2; i++)
      {
        Points[i * 2] = Quaternion.Factory
          .With(Math.Cos(i * 72 * Math.PI / 180) * 100,
            Math.Sin(i * 72 * Math.PI / 180) * 100);
        Points[i * 2 + 1] = Quaternion.Factory
          .With(Math.Cos((i * 72 + 36) * Math.PI / 180) * 50,
            Math.Sin((i * 72 + 36) * Math.PI / 180) * 50);
      }
    }
  }
}
