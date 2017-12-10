namespace Shaykhullin.Operations
{
  public class UnaryNotOperation 
    : UnaryOperation<bool, bool>
  {
    public override bool Calculate(bool arg)
    {
      return !arg;
    }
  }
}
