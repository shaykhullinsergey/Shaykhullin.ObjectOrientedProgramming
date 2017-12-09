using System;
using System.Windows.Forms;
using Shaykhullin.Lab4.Frontend.Views;

namespace Shaykhullin.Lab4.Frontend
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainView());
    }
  }
}
