using System;

namespace Shaykhullin.Operations
{
  public class UnaryArctanOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Atan(arg);
    }
  }
}
