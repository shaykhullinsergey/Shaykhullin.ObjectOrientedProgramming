using Shaykhullin.Shared.Lab1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaykhullin.Builders
{
  public class Matrix3x3Builder
  {
    public Matrix3x3 Matrix { get; }

    public Matrix3x3Builder(Matrix3x3 matrix)
    {
      this.Matrix = matrix ?? throw new ArgumentNullException(nameof(matrix));
    }

    public Matrix3x3BuilderElement In(int x, int y)
    {
      return new Matrix3x3BuilderElement(this, x, y);
    }

    public class Matrix3x3BuilderElement
    {
      private Matrix3x3Builder builder;
      private int x, y;

      public Matrix3x3BuilderElement(Matrix3x3Builder builder, int x, int y)
      {
        this.builder = builder ?? throw new ArgumentNullException(nameof(builder));
        this.x = x;
        this.y = y;
      }

      public Matrix3x3Builder Has(double? value)
      {
        builder.Matrix[x, y] = value ?? 0;

        return builder;
      }
    }
  }
}
