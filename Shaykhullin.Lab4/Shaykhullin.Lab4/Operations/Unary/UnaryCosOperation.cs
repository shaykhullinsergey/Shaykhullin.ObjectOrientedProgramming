using System;

namespace Shaykhullin.Operations
{
  public class UnaryCosOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Cos(arg);
    }
  }
}
