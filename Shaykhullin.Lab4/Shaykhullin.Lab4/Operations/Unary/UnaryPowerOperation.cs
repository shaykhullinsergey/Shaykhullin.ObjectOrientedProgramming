using System;

namespace Shaykhullin.Operations
{
  public class UnaryPowerOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Pow(arg, 2);
    }
  }
}
