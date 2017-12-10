using System;

namespace Shaykhullin.Operations
{
  public class UnaryArcsinOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Asin(arg);
    }
  }
}
