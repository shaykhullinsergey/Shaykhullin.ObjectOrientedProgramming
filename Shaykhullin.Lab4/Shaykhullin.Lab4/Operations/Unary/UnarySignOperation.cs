﻿using System;

namespace Shaykhullin.Operations
{
  public class UnarySignOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return Math.Sign(arg);
    }
  }
}
