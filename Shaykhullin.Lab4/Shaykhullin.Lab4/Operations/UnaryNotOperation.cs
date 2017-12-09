namespace Shaykhullin.Operations
{
  public class UnaryNotOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return !(bool)args[0];
    }
  }
}
