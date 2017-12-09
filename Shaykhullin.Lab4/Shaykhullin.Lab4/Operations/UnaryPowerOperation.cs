using System;

namespace Shaykhullin.Operations
{
  public class UnaryPowerOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Pow((double)args[0], 2);
    }
  }
}
