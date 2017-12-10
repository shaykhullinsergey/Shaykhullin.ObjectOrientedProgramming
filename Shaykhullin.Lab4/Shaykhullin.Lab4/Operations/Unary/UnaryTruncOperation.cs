using System;

namespace Shaykhullin.Operations
{
  public class UnaryTruncOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Truncate(arg);
    }
  }
}
