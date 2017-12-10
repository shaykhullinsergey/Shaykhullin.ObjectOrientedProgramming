namespace Shaykhullin.Operations
{
  public abstract class UnaryOperation : Operation { }

  public abstract class UnaryOperation<TArgument, TReturn> : UnaryOperation
  {
    public sealed override object Calculate(object[] args)
    {
      return Calculate((TArgument)args[0]);
    }

    public abstract TReturn Calculate(TArgument arg);
  }
}
