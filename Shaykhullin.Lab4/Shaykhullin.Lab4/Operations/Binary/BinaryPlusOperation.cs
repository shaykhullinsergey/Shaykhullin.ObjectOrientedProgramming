namespace Shaykhullin.Operations
{
  public class BinaryPlusOperation 
    : BinaryOperation<double, double>
  {
    public override double Calculate(double arg1, double arg2)
    {
      return arg1 + arg2;
    }
  }
}
