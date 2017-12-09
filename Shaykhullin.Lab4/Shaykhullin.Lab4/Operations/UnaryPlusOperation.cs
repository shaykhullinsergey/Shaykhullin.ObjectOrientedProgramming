namespace Shaykhullin.Operations
{
  public class UnaryPlusOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return (double)args[0];
    }
  }
}
