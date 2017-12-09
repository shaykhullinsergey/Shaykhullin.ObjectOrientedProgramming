namespace Shaykhullin.Operations
{
  public class BinaryDivideOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return (double)args[0] / (double)args[1];
    }
  }
}
