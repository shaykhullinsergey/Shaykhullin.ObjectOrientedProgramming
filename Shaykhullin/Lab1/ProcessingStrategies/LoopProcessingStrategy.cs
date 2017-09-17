﻿using System.Drawing;
using Shaykhullin.Shared.Lab1.Drawables;

namespace Shaykhullin.Shared.Lab1.ProcessingStrategies
{
  public class LoopProcessingStrategy 
    : IStateValueProcessingStrategy<Bitmap, DrawableBase, (int, int)>
  {
    public DrawableBase State { get; set; }
    public (int, int) Value { get; set; } = (-1, 0);
    private IStateProcessingStrategy<Matrix3x3, int>[] strategies;

    public LoopProcessingStrategy(DrawableBase drawable)
    {
      State = drawable;
      strategies = new IStateProcessingStrategy<Matrix3x3, int>[]
      {
        new XShiftProcessingStrategy(),
        new YShiftProcessingStrategy(),
        new RotationProcessingStrategy(),
        new ScaleProcessingStrategy()
      };
    }
    public Bitmap Process()
    {
      var matrix = Matrix3x3.Factory.Zero;

      for (int index = 0; index < strategies.Length; index++)
      {
        var strategy = strategies[index];

        if(Value.Item1 == index)
        {
          strategy.State = Value.Item2;
        }

        matrix += strategy.Process();
      }

      return State.Draw(matrix);
    }
  }
}
