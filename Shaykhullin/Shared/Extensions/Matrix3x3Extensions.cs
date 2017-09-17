using Shaykhullin.Builders;
using Shaykhullin.Shared.Lab1;
using System;

namespace Shaykhullin.Extensions
{
  public static class Matrix3x3Extensions
  {
    public static Matrix3x3Builder AsFluent(this Matrix3x3 matrix)
    {
      return new Matrix3x3Builder(matrix);
    }

    public static Matrix3x3 Loop(this Matrix3x3 matrix, Action<Matrix3x3, int, int> selector)
    {
      for (int x = 0; x < Matrix3x3.Size; x++)
      {
        for (int y = 0; y < Matrix3x3.Size; y++)
        {
          selector(matrix, x, y);
        }
      }

      return matrix;
    }
  }
}
