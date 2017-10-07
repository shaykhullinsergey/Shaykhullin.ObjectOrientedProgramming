using Shaykhullin.Injection;
using Shaykhullin.Practice1.Views;
using Shaykhullin.Shared.Practice1;
using System;
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
          .AsTransient()
        .Service;

      Application.Run(service.Resolve<MainView>());
    }
  }
}
