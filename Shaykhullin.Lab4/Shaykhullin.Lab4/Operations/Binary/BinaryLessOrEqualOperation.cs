﻿namespace Shaykhullin.Operations
{
  public class BinaryLessOrEqualOperation 
    : BinaryOperation<double, bool>
  {
    public override bool Calculate(double arg1, double arg2)
    {
      return arg1 <= arg2;
    }
  }
}
