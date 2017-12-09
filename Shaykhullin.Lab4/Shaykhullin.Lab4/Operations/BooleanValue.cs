namespace Shaykhullin.Operations
{
  public class BooleanValue : Operation
  {
    private bool value;

    public BooleanValue(bool value)
    {
      this.value = value;
    }

    public override object Calculate(object[] args)
    {
      return value;
    }
  }
}
