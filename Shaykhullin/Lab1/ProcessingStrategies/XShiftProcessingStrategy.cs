namespace Shaykhullin.Shared.Lab1.ProcessingStrategies
{
  public class XShiftProcessingStrategy : IStateProcessingStrategy<Matrix3x3, int>
  {
    public int State { get; set; } = 5;

    public Matrix3x3 Process()
    {
      return Matrix3x3.Factory.ToTranslational(shiftX: State * 20);
    }
  }
}
