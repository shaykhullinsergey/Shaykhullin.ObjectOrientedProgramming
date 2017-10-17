using System;
using System.Windows.Forms;
using Shaykhullin.Injection;
using Shaykhullin.Lab2.Views;

namespace Shaykhullin.Lab2
{
  internal static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var service = new AppServiceBuilder()
        .Register<MainView>()
          .AsSingleton()
        .Service;

      Application.Run(service.Resolve<MainView>());
    }
  }
}
