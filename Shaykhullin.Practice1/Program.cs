using Shaykhullin.DependencyInjection.App;
using Shaykhullin.Practice1.Views;
using Shaykhullin.Shared.Practice1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.Practice1
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
        .Register<Fraction>()
          .Returns(new Fraction(12, 12))
          .AsTransient()
        .Service;

      Application.Run(service.Resolve<MainView>());
    }
  }
}
