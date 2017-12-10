namespace Shaykhullin.Operations
{
  public class BinaryAndOperation 
    : BinaryOperation<bool, bool>
  {
    public override bool Calculate(bool arg1, bool arg2)
    {
      return arg1 & arg2;
    }
  }
}
