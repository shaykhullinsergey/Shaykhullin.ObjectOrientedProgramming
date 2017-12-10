using System;

namespace Shaykhullin.Operations
{
  public class UnaryCeilOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Ceiling(arg);
    }
  }
}
