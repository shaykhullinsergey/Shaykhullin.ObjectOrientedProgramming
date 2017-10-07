using Shaykhullin.DependencyInjection.App;
using Shaykhullin.Lab2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.Lab2
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
        .Register<FormTree>()
          .Returns(new FormTree(new TreeNode("Root")))
          .AsSingleton()
      .Service;

      Application.Run(service.Resolve<MainView>());
    }
  }
}
