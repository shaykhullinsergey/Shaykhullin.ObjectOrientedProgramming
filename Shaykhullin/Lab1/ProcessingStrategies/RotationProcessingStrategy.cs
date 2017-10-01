namespace Shaykhullin.Shared.Lab1.ProcessingStrategies
{
  public class RotationProcessingStrategy : IStateProcessingStrategy<Matrix3x3, int>
  {
    public int State { get; set; }

    public Matrix3x3 Process()
    {
      return Matrix3x3.Factory.ToRotational(State * 4);
    }
  }
}
