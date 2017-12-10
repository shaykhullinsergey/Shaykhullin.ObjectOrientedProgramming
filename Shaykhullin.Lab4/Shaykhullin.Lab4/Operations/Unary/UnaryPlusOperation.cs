namespace Shaykhullin.Operations
{
  public class UnaryPlusOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return arg;
    }
  }
}
