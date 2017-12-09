namespace Shaykhullin.Operations
{
  public class BinaryLessOperation : Operation
  {
    public override object Calculate(object[] args)
    {
      return (double)args[0] < (double)args[1];
    }
  }
}
