﻿namespace Shaykhullin.Operations
{
  public abstract class BinaryOperation : Operation { }

  public abstract class BinaryOperation<TArgument, TReturn> : BinaryOperation
  {
    public sealed override object Calculate(object[] args)
    {
      return Calculate((TArgument)args[0], (TArgument)args[1]);
    }

    public abstract TReturn Calculate(TArgument arg1, TArgument arg2);
  }
}
