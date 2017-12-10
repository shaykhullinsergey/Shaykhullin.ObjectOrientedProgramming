using System;

namespace Shaykhullin.Operations
{
  public class UnaryArccosOperation : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Acos(arg);
    }
  }
}
