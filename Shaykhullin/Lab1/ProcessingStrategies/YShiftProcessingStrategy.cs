namespace Shaykhullin.Shared.Lab1.ProcessingStrategies
{
  public class YShiftProcessingStrategy : IStateProcessingStrategy<Matrix3x3, int>
  {
    public int State { get; set; } = 5;

    public Matrix3x3 Process()
    {
      return Matrix3x3.Factory.ToTranslational(0, State * 20);
    }
  }
}
