using System;

namespace Shaykhullin.Operations
{
  public class UnaryFloorOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Floor(arg);
    }
  }
}
