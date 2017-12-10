using System;

namespace Shaykhullin.Operations
{
  public class UnaryLnOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Log(arg);
    }
  }
}
