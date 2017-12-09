namespace Shaykhullin.Operations
{
  public class DoubleValue : Operation
  {
    private double value;

    public DoubleValue(double value)
    {
      this.value = value;
    }

    public override object Calculate(object[] args)
    {
      return value;
    }
  }
}
