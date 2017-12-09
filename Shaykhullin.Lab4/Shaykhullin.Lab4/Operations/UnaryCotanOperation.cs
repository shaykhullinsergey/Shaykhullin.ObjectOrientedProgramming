using System;

namespace Shaykhullin.Operations
{
  public class UnaryCotanOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return 1d / Math.Tan((double)args[0]);
    }
  }
}
