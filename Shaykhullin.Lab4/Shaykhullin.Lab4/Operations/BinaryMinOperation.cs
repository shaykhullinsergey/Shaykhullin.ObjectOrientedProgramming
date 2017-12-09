namespace Shaykhullin.Operations
{
  public class BinaryMinOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      var a = (double)args[0];
      var b = (double)args[1];

      return a > b ? b : a;
    }
  }
}
