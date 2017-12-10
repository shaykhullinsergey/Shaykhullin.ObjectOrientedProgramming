namespace Shaykhullin.Operations
{
  public class BinaryGreaterOrEqualOperation 
    : BinaryOperation<double, bool>
  {
    public override bool Calculate(double arg1, double arg2)
    {
      return arg1 >= arg2;
    }
  }
}
