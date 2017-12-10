using System;

namespace Shaykhullin.Operations
{
  public class UnaryCotanOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return 1d / Math.Tan(arg);
    }
  }
}
