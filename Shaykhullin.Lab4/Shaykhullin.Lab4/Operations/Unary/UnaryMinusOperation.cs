namespace Shaykhullin.Operations
{
  public class UnaryMinusOperation 
    : UnaryOperation<double, double>
  {
    public override double Calculate(double arg)
    {
      return -arg;
    }
  }
}
