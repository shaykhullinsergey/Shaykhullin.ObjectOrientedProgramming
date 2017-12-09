namespace Shaykhullin.Operations
{
  public class BinaryModulusOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return (double)args[0] % (double)args[1];
    }
  }
}
