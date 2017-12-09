using System;

namespace Shaykhullin.Operations
{
  public class UnarySinOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Sin((double)args[0]);
    }
  }
}
