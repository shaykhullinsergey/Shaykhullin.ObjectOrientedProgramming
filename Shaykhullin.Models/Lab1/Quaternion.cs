namespace Shaykhullin.Models.Lab1
{
  public class Quaternion
  {
    public static QuaternionFactory Factory { get; } = new QuaternionFactory();

    public double X { get; set; }
    public double Y { get; set; }
    public double Degree { get; set; }

    private Quaternion(double x, double y) : this(x, y, 1.0)
    {
    }
    private Quaternion(double x, double y, double degree)
    {
      X = x;
      Y = y;
      Degree = degree;
    }

    public static Quaternion operator +(Quaternion a, Quaternion b)
    {
      if (a.Degree == b.Degree)
      {
        return Factory.WithDegree(a.X + b.X, a.Y + b.Y, a.Degree);
      }

      a.X /= a.Degree;
      a.Y /= a.Degree;
      b.X /= b.Degree;
      b.Y /= b.Degree;
      return Factory.With(a.X + b.X, a.Y + b.Y);
    }
    public static Quaternion operator -(Quaternion a, Quaternion b)
    {
      if (a.Degree == b.Degree)
      {
        return Factory.WithDegree(a.X - b.X, a.Y - b.Y, a.Degree);
      }

      a.X /= a.Degree;
      a.Y /= a.Degree;
      b.X /= b.Degree;
      b.Y /= b.Degree;
      return Factory.With(a.X - b.X, a.Y - b.Y);
    }
    public static Quaternion operator *(Quaternion a, Quaternion b)
    {
      if (a.Degree == b.Degree)
      {
        return Factory.WithDegree(a.X * b.X, a.Y * b.Y, a.Degree);
      }

      a.X /= a.Degree;
      a.Y /= a.Degree;
      b.X /= b.Degree;
      b.Y /= b.Degree;
      return Factory.With(a.X * b.X, a.Y * b.Y);
    }

    public class QuaternionFactory
    {
      public Quaternion With(double x, double y)
      {
        return new Quaternion(x, y);
      }
      public Quaternion WithDegree(double x, double y, double degree)
      {
        return new Quaternion(x, y, degree);
      }
    }
  }
}
