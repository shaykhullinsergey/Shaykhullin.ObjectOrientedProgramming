namespace Shaykhullin.Operations
{
  public class UnaryMinusOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return -(double)args[0];
    }
  }
}
