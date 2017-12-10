namespace Shaykhullin.Operations
{
  public abstract class ValueOperation : Operation
  {
    public abstract object ExecuteCore();
  }

  public abstract class ValueOperation<TValue> : ValueOperation
  {
    private TValue value;

    protected ValueOperation(TValue value)
    {
      this.value = value;
    }

    public sealed override object ExecuteCore()
    {
      return Calculate();
    }

    public TValue Calculate()
    {
      return value;
    }
  }
}
