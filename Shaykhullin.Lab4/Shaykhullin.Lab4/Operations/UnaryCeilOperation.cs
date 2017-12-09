using System;

namespace Shaykhullin.Operations
{
  public class UnaryCeilOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Ceiling((double)args[0]);
    }
  }
}
