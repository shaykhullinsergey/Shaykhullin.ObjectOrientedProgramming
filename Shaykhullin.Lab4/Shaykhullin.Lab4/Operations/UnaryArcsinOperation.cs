using System;

namespace Shaykhullin.Operations
{
  public class UnaryArcsinOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Asin((double)args[0]);
    }
  }
}
