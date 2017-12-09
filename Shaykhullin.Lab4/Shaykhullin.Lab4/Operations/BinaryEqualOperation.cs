namespace Shaykhullin.Operations
{
  public class BinaryEqualOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return args[0].Equals(args[1]);
    }
  }
}
