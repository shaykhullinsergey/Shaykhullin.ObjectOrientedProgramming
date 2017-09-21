using System.Drawing;
using Shaykhullin.Shared.Lab1.Drawables;
using Shaykhullin.DependencyInjection;

namespace Shaykhullin.Shared.Lab1.ProcessingStrategies
{
  public class LoopProcessingStrategy 
    : IStateValueProcessingStrategy<Bitmap, DrawableBase, (int, int)>
  {
    [Inject]
    private IStateProcessingStrategy<Matrix3x3, int>[] strategies;

    public DrawableBase State { get; set; }
    public (int, int) Value { get; set; } = (-1, 0);

    public Bitmap Process()
    {
      var matrix = Matrix3x3.Factory.Identity;
      var s = strategies[0];
      s.State = Value.Item2;

      matrix *= s.Process();

      return State.Draw(matrix);

      for (int i = 0; i < strategies.Length; i++)
      {
        var strategy = strategies[i];
        if (Value.Item1 == i)
        {
          strategy.State = Value.Item2;
        }
        matrix *= strategy.Process();
      }

    }
  }
}
