namespace Shaykhullin.Operations
{
  public class BinaryModulusOperation 
    : BinaryOperation<double, double>
  {
    public override double Calculate(double arg1, double arg2)
    {
      return arg1 % arg2;
    }
  }
}
