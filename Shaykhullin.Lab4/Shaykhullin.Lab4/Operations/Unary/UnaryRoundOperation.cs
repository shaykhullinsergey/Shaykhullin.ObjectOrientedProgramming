using System;

namespace Shaykhullin.Operations
{
  public class UnaryRoundOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Round(arg);
    }
  }
}
