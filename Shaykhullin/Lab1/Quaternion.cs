using System;
using System.Collections;
using System.Collections.Generic;

namespace Shaykhullin.Shared.Lab1
{
  public struct Quaternion
  {
    public static QuaternionFactory Factory { get; } = new QuaternionFactory();

    public double X { get; }
    public double Y { get; }
    public double Degree { get; }

    private Quaternion(double x, double y) : this(x, y, 1.0)
    {
    }
    private Quaternion(double x, double y, double degree)
    {
      X = x;
      Y = y;
      Degree = degree;
    }

    public static Quaternion operator +(Quaternion a, Quaternion b) =>
      a.Degree == b.Degree
        ? Factory.WithDegree(a.X + b.X, a.Y + b.Y, a.Degree)
        : Factory.With(a.X / a.Degree + b.X / a.Degree, a.Y / b.Degree + b.Y / b.Degree);

    public static Quaternion operator -(Quaternion a, Quaternion b) =>
      a.Degree == b.Degree
        ? Factory.WithDegree(a.X - b.X, a.Y - b.Y, a.Degree)
        : Factory.With(a.X / a.Degree - b.X / a.Degree, a.Y / b.Degree - b.Y / b.Degree);

    public static Quaternion operator *(Quaternion a, Quaternion b) =>
      a.Degree == b.Degree
        ? Factory.WithDegree(a.X * b.X, a.Y * b.Y, a.Degree)
        : Factory.With(a.X / a.Degree * b.X / a.Degree, a.Y / b.Degree * b.Y / b.Degree);

    public class QuaternionFactory
    {
      public QuaternionFlientFactory AsFluent(Func<double, double> selector = null) =>
        new QuaternionFlientFactory(selector ?? (p => p));

      public Quaternion With(double x, double y) => new Quaternion(x, y);

      public Quaternion WithDegree(double x, double y, double degree) => new Quaternion(x, y, degree);

      public class QuaternionFlientFactory : IEnumerable<Quaternion>
      {
        private Func<double, double> selector;
        private List<Quaternion> quaternionList = new List<Quaternion>();

        public QuaternionFlientFactory(Func<double, double> selector)
        {
          this.selector = selector;
        }

        public QuaternionFlientFactory With(double x, double y)
        {
          quaternionList.Add(new Quaternion(selector(x), selector(y)));
          return this;
        }
        public QuaternionFlientFactory WithDegree(double x, double y, double degree)
        {
          quaternionList.Add(new Quaternion(selector(x), selector(y), degree));
          return this;
        }

        public IEnumerator<Quaternion> GetEnumerator()
        {
          foreach (var quaternion in quaternionList)
          {
            yield return quaternion;
          }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
      }
    }
  }
}
