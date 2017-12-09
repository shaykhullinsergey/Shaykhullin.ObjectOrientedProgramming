namespace Shaykhullin.Operations
{
  public class BinaryGreaterOrEqualOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return (double)args[0] >= (double)args[1];
    }
  }
}
