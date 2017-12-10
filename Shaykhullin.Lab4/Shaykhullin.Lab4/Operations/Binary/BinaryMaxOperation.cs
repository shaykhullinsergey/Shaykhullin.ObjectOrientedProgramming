﻿namespace Shaykhullin.Operations
{
  public class BinaryMaxOperation 
    : BinaryOperation<double, double>
  {
    public override double Calculate(double arg1, double arg2)
    {
      return arg1 > arg2 ? arg1 : arg2;
    }
  }
}
