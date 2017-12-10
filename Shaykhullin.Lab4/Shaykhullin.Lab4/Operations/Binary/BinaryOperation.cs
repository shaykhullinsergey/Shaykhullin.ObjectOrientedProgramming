namespace Shaykhullin.Operations
{
  public abstract class BinaryOperation : Operation
  {
    public abstract object ExecuteCore(object arg1, object arg2);
  }

  public abstract class BinaryOperation<TArgument, TReturn> : BinaryOperation
  {
    public sealed override object ExecuteCore(object arg1, object arg2)
    {
      return Calculate((TArgument)arg1, (TArgument)arg2);
    }

    public abstract TReturn Calculate(TArgument arg1, TArgument arg2);
  }
}
