namespace Shaykhullin.Operations
{
  public class BinaryNotEqualOperation 
    : BinaryOperation<object, bool>
  {
    public override bool Calculate(object arg1, object arg2)
    {
      return !(arg1.Equals(arg2));
    }
  }
}
