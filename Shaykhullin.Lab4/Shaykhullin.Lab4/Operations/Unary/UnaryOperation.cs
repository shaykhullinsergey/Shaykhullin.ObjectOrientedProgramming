namespace Shaykhullin.Operations
{
  public abstract class UnaryOperation<TArgument, TReturn> : Operation
  {
    public sealed override object Calculate(object[] args)
    {
      return Calculate((TArgument)args[0]);
    }

    public abstract TReturn Calculate(TArgument arg);
  }
}
