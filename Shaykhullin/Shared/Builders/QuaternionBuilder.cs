using Shaykhullin.Shared.Lab1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaykhullin.Builders
{
  public class QuaternionBuilder
  {
    private double x, y, degree = 1;

    public Quaternion Quaternion =>
      Quaternion.Factory.WithDegree(x, y, degree);

    public QuaternionBuilder WithX(double x)
    {
      this.x = x;
      return this;
    }

    public QuaternionBuilder WithY(double y)
    {
      this.y = y;
      return this;
    }

    public QuaternionBuilder WithDegree(double degree)
    {
      this.degree = degree;
      return this;
    }
  }
}
