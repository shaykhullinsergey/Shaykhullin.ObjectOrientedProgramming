using System;

namespace Shaykhullin.Operations
{
  public class UnaryTruncOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Truncate((double)args[0]);
    }
  }
}
