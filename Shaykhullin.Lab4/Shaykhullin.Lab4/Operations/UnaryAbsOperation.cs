using System;

namespace Shaykhullin.Operations
{
  public class UnaryAbsOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Abs((double)args[0]);
    }
  }
}
