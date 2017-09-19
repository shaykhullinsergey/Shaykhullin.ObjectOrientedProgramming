﻿using System;
using System.Windows.Forms;

using Shaykhullin.Lab1.Views;
using Shaykhullin.DependencyInjection.App;
using System.Collections.Generic;
using System.Reflection;
using Shaykhullin.Shared.Lab1.Drawables;
using Shaykhullin.Shared.Lab1.ProcessingStrategies;
using System.Drawing;
using Shaykhullin.Shared.Lab1;

namespace Shaykhullin.Lab1
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var service = new AppServiceBuilder()
        .Register<MainView>()
          .AsSingleton()
        .Register<Dictionary<string, Type>>()
          .Returns(new Dictionary<string, Type>
          {
            ["Star"] = typeof(StarDrawable),
            ["Hexagon"] = typeof(HexagonDrawable),
            ["Twenty Star"] = typeof(TwentyStarDrawable),
            ["Greek Cross"] = typeof(GreekCrossDrawable)
          })
          .As<IReadOnlyDictionary<string, Type>>()
          .AsSingleton()
        .Register<IStateProcessingStrategy<Matrix3x3, int>[]>()
          .Returns(new IStateProcessingStrategy<Matrix3x3, int>[]
          {
            new XShiftProcessingStrategy(),
            new YShiftProcessingStrategy(),
            new RotationProcessingStrategy(),
            new ScaleProcessingStrategy()
          })
          .AsSingleton()
        .Register<LoopProcessingStrategy>()
          .As<IStateValueProcessingStrategy<Bitmap, DrawableBase, (int, int)>>()
          .AsSingleton()
        .Register<Bitmap>()
          .Returns(new Bitmap(1080, 617))
          .AsSingleton()
      .Service;

      Application.Run(service.Resolve<MainView>());
    }
  }
}
