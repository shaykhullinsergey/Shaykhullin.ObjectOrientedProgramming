using System;
using System.Collections.Generic;
using System.Linq;

using Shaykhullin.Extensions;

namespace Shaykhullin.Shared.Lab1
{
  public class Matrix3x3
  {
    public const int Size = 3;
    public static Matrix3x3Factory Factory { get; } = new Matrix3x3Factory();
    private double[,] matrix = new double[Size, Size];

    public double this[int x, int y]
    {
      get
      {
        if (x.IsInRange(0, 2).And(y, 0, 2))
        {
          return matrix[x, y];
        }

        throw new InvalidOperationException($"X and Y must be in range 0-{Size}");
      }
      set
      {
        if (x.IsInRange(0, 2).And(y, 0, 2))
        {
          matrix[x, y] = value;
        }
        else
        {
          throw new InvalidOperationException($"X and Y must be in range 0-{Size}");
        }
      }
    }

    public static Matrix3x3 operator +(Matrix3x3 a, Matrix3x3 b) =>
      Factory.Zero
        .Loop((matrix, x, y) => matrix[x, y] = a[x, y] + b[x, y]);

    public static Matrix3x3 operator -(Matrix3x3 a, Matrix3x3 b) =>
      Factory.Zero
        .Loop((matrix, x, y) => matrix[x, y] = a[x, y] - b[x, y]);

    public static Matrix3x3 operator *(Matrix3x3 a, Matrix3x3 b) =>
      Factory.Zero.AsFluent()
        .In(0, 0).Has(a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0] + a[0, 2] * b[2, 0])
        .In(0, 1).Has(a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1] + a[0, 2] * b[2, 1])
        .In(0, 2).Has(a[0, 0] * b[0, 2] + a[0, 1] * b[1, 2] + a[0, 2] * b[2, 2])
        .In(1, 0).Has(a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0] + a[1, 2] * b[2, 0])
        .In(1, 1).Has(a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1] + a[1, 2] * b[2, 1])
        .In(1, 2).Has(a[1, 0] * b[0, 2] + a[1, 1] * b[1, 2] + a[1, 2] * b[2, 2])
        .In(2, 0).Has(a[2, 0] * b[0, 0] + a[2, 1] * b[1, 0] + a[2, 2] * b[2, 0])
        .In(2, 1).Has(a[2, 0] * b[0, 1] + a[2, 1] * b[1, 1] + a[2, 2] * b[2, 1])
        .In(2, 2).Has(a[2, 0] * b[0, 2] + a[2, 1] * b[1, 2] + a[2, 2] * b[2, 2])
      .Matrix;

    public static Quaternion operator *(Matrix3x3 matrix, Quaternion quaternion) =>
      Quaternion.Factory.AsSeparate()
        .WithX(matrix[0, 0] * quaternion.X + matrix[0, 1] * quaternion.Y + matrix[0, 2] * quaternion.Degree)
        .WithY(matrix[1, 0] * quaternion.X + matrix[1, 1] * quaternion.Y + matrix[1, 2] * quaternion.Degree)
        .WithDegree(matrix[2, 0] * quaternion.X + matrix[2, 1] * quaternion.Y + matrix[2, 2] * quaternion.Degree)
      .Quaternion;

    public static Quaternion operator *(Quaternion quaternion, Matrix3x3 matrix) =>
      Quaternion.Factory.AsSeparate()
        .WithX(quaternion.X * matrix[0, 0] + quaternion.Y * matrix[1, 0] + quaternion.Degree * matrix[2, 0])
        .WithY(quaternion.X * matrix[0, 1] + quaternion.Y * matrix[1, 1] + quaternion.Degree * matrix[2, 1])
        .WithDegree(quaternion.X * matrix[0, 2] + quaternion.Y * matrix[1, 2] + quaternion.Degree * matrix[2, 2])
      .Quaternion;

    public static IEnumerable<Quaternion> operator *(Matrix3x3 matrix, IEnumerable<Quaternion> quaternions) =>
      quaternions.Select(quaternion => matrix * quaternion);

    public static IEnumerable<Quaternion> operator *(IEnumerable<Quaternion> quaternions, Matrix3x3 matrix) =>
      quaternions.Select(quaternion => quaternion * matrix);

    public static Matrix3x3 operator !(Matrix3x3 other) =>
      Factory.Zero.Loop((matrix, x, y) => matrix[x, y] = other[y, x]);

    public class Matrix3x3Factory
    {
      public Matrix3x3 Zero => new Matrix3x3();

      public Matrix3x3 Identity => 
        Factory.Zero.AsFluent()
          .In(0, 0).Has(1)
          .In(1, 1).Has(1)
          .In(2, 2).Has(1)
        .Matrix;

      public Matrix3x3 ToTranslational(double? shiftX = null, double? shiftY = null) => 
        Factory.Identity.AsFluent()
          .In(2, 0).Has(shiftX) // 2 0
          .In(2, 1).Has(shiftY) // 2 1
        .Matrix;

      public Matrix3x3 ToRotational(double angle) => 
        Factory.Identity.AsFluent()
          .In(0, 0).Has(Math.Cos(angle))
          .In(1, 1).Has(Math.Cos(angle))
          .In(0, 1).Has(-Math.Sin(angle))
          .In(1, 0).Has(Math.Sin(angle))
        .Matrix;

      public Matrix3x3 ToScalable(double scaleX, double scaleY) =>
        Factory.Identity.AsFluent()
          .In(0, 0).Has(scaleX)
          .In(1, 1).Has(scaleY)
        .Matrix;
    }
  }
}
