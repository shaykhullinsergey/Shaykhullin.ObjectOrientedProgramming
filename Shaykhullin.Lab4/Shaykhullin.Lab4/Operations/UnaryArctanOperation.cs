using System;

namespace Shaykhullin.Operations
{
  public class UnaryArctanOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Atan((double)args[0]);
    }
  }
}
