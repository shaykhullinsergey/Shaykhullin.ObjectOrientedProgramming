namespace Shaykhullin.Operations
{
  public abstract class ValueOperation<TValue> : Operation
  {
    private TValue value;

    protected ValueOperation(TValue value)
    {
      this.value = value;
    }

    public sealed override object Calculate(object[] args)
    {
      return value;
    }
  }
}
