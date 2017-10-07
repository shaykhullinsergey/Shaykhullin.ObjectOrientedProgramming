using System;
using System.Windows.Forms;

using Shaykhullin.Lab1.Views;
using System.Collections.Generic;
using Shaykhullin.Shared.Lab1.Drawables;
using Shaykhullin.Shared.Lab1.ProcessingStrategies;
using System.Drawing;
using Shaykhullin.Shared.Lab1;
using Shaykhullin.Injection;

namespace Shaykhullin.Lab1
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var service = new AppServiceBuilder()
        .Register<MainView>()
          .AsSingleton()
        .Register<Dictionary<string, Type>>()
          .Returns(s => new Dictionary<string, Type>
          {
            ["Star"] = typeof(StarDrawable),
            ["Hexagon"] = typeof(HexagonDrawable),
            ["Twenty Star"] = typeof(TwentyStarDrawable),
            ["Greek Cross"] = typeof(GreekCrossDrawable)
          })
          .As<IReadOnlyDictionary<string, Type>>()
          .AsSingleton()
        .Register<IStateProcessingStrategy<Matrix3x3, int>[]>()
          .Returns(s => new IStateProcessingStrategy<Matrix3x3, int>[]
          {
            new RotationProcessingStrategy(),
            new ScaleProcessingStrategy(),
            new XShiftProcessingStrategy(),
            new YShiftProcessingStrategy()
          })
          .AsSingleton()
        .Register<LoopProcessingStrategy>()
          .As<IStateValueProcessingStrategy<Bitmap, DrawableBase, (int, int)>>()
          .AsSingleton()
        .Register<Bitmap>()
          .Returns(s => new Bitmap(1080, 617))
          .AsSingleton()
      .Service;

      Application.Run(service.Resolve<MainView>());
    }
  }
}
