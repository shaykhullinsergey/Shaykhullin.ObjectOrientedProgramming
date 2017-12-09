namespace Shaykhullin.Operations
{
  public class BinaryNotEqualOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return !(args[0].Equals(args[1]));
    }
  }
}
