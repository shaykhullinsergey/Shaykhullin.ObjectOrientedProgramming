using System;
using System.Drawing;

namespace Shaykhullin.Shared.Lab1.Drawables
{
  public class HexagonDrawable : DrawableBase
  {
    protected override Pen Pen { get; } = new Pen(Color.FromArgb(255, 202, 44, 226), 3.0f);
    protected override Brush Brush { get; } = new SolidBrush(Color.FromArgb(255, 123, 7, 141));

    public HexagonDrawable() : base(6)
    {
      for (int i = 0; i < Points.Length; i++)
      {
        Points[i] = Quaternion.Factory.With(
          Math.Cos(i * 60 * Math.PI / 180) * 100,
          Math.Sin(i * 60 * Math.PI / 180) * 100);
      }
    }
  }
}
