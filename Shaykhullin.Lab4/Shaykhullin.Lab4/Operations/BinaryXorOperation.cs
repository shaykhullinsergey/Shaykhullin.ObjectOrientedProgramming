namespace Shaykhullin.Operations
{
  public class BinaryXorOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return (bool)args[0] ^ (bool)args[1];
    }
  }
}
