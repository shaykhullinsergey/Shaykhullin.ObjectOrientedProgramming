using System;

namespace Shaykhullin.Operations
{
  public class UnaryRoundOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Round((double)args[0]);
    }
  }
}
