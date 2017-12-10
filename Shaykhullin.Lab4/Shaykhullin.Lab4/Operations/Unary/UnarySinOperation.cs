using System;

namespace Shaykhullin.Operations
{
  public class UnarySinOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Sin(arg);
    }
  }
}
