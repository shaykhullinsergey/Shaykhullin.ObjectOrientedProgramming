using System.Drawing;
using System.Linq;

namespace Shaykhullin.Shared.Lab1.Drawables
{
  public class GreekCrossDrawable : DrawableBase
  {
    protected override Pen Pen { get; } = new Pen(Color.Black, 6.0f);
    protected override Brush Brush { get; } = new SolidBrush(Color.Silver);

    private int size = 30;

    public GreekCrossDrawable() =>
      Points = Quaternion.Factory.AsFluent(prop => prop - size * 1.5)
        .With(size, 0)
        .With(size, size)
        .With(0, size)
        .With(0, 2 * size)
        .With(size, 2 * size)
        .With(size, 3 * size)
        .With(2 * size, 3 * size)
        .With(2 * size, 2 * size)
        .With(3 * size, 2 * size)
        .With(3 * size, 1 * size)
        .With(2 * size, 1 * size)
        .With(2 * size, 0)
      .ToArray();

  }
}
