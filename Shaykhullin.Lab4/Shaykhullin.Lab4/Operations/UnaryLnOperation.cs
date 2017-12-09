using System;

namespace Shaykhullin.Operations
{
  public class UnaryLnOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Log((double)args[0]);
    }
  }
}
