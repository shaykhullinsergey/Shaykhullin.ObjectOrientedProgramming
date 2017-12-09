namespace Shaykhullin.Operations
{
  public class BinaryMaxOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      var a = (double)args[0];
      var b = (double)args[1];

      return a > b ? a : b;
    }
  }
}
