namespace Shaykhullin.Shared.Lab1.ProcessingStrategies
{
  public class ScaleProcessingStrategy : IStateProcessingStrategy<Matrix3x3, int>
  {
    public int State { get; set; }

    public Matrix3x3 Process()
    {
      return Matrix3x3.Factory.ToScalable(State + 1, State + 1);
    }
  }
}
