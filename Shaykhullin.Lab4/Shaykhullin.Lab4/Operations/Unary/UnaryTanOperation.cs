using System;

namespace Shaykhullin.Operations
{
  public class UnaryTanOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Tan(arg);
    }
  }
}
