using System;

namespace Shaykhullin.Operations
{
  public class UnaryCosOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Cos((double)args[0]);
    }
  }
}
