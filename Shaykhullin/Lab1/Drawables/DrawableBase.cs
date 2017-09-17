using System.Linq;
using System.Drawing;

namespace Shaykhullin.Shared.Lab1.Drawables
{
  public abstract class DrawableBase : IDrawable<Bitmap, Matrix3x3>
  {
    protected Bitmap Bitmap { get; }
    protected Quaternion[] Points { get; set; }
    protected abstract Pen Pen { get; }
    protected abstract Brush Brush { get; }

    public DrawableBase(Bitmap bitmap)
    {
      Bitmap = bitmap;
    }
    public DrawableBase(Bitmap bitmap, int pointsCount) : this(bitmap)
    {
      this.Points = new Quaternion[pointsCount];
    }
    public Bitmap Draw(Matrix3x3 matrix)
    {
      var graphics = Graphics.FromImage(Bitmap);
      graphics.FillRectangle(Brush, 0, 0, Bitmap.Width, Bitmap.Height);
      graphics.DrawPolygon(Pen, (Points * matrix)
        .Select(point => new Point((int)point.X + 300, (int)point.Y + 200))
        .ToArray());

      return Bitmap;
    }
  }
}
