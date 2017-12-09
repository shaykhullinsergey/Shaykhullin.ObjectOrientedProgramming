using System;

namespace Shaykhullin.Operations
{
  public class UnaryFloorOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Floor((double)args[0]);
    }
  }
}
