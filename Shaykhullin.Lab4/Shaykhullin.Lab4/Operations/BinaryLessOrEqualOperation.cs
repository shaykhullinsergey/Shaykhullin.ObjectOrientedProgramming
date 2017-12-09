﻿namespace Shaykhullin.Operations
{
  public class BinaryLessOrEqualOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return (double)args[0] <= (double)args[1];
    }
  }
}
