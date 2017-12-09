using System;

namespace Shaykhullin.Operations
{
  public class UnarySignOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return (double)Math.Sign((double)args[0]);
    }
  }
}
