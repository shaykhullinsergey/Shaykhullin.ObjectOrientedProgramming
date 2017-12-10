namespace Shaykhullin.Operations
{
  public abstract class UnaryOperation : Operation
  {
    public abstract object ExecuteCore(object arg);
  }

  public abstract class UnaryOperation<TArgument, TReturn> : UnaryOperation
  {
    public sealed override object ExecuteCore(object arg)
    {
      return Calculate((TArgument)arg);
    }

    public abstract TReturn Calculate(TArgument arg);
  }
}
