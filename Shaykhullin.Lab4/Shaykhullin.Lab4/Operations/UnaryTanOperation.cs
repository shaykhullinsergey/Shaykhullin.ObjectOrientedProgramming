using System;

namespace Shaykhullin.Operations
{
  public class UnaryTanOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Tan((double)args[0]);
    }
  }
}
