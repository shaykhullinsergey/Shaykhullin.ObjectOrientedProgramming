namespace Shaykhullin.Operations
{
  public class BinaryEqualOperation 
    : BinaryOperation<object, bool>
  {
    public override bool Calculate(object arg1, object arg2)
    {
      return arg1.Equals(arg2);
    }
  }
}
