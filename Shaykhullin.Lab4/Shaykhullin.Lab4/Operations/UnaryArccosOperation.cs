using System;

namespace Shaykhullin.Operations
{
  public class UnaryArccosOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return Math.Acos((double)args[0]);
    }
  }
}
