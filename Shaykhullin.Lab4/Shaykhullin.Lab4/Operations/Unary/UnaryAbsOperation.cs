using System;

namespace Shaykhullin.Operations
{
  public class UnaryAbsOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Abs(arg);
    }
  }
}
