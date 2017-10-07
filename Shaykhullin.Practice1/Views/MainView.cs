using System;
using System.Windows.Forms;

using Shaykhullin.Shared.Practice1;
using Shaykhullin.Injection;

namespace Shaykhullin.Practice1.Views
{
  public partial class MainView : Form
  {
    [Inject]
    private IService service;

    public MainView()
    {
      InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
      result.Text = service.Resolve<Fraction>(6, 9).ToString();

      var fraction3 = Fraction.Add(service.Resolve<Fraction>(2, 9), service.Resolve<Fraction>(1, 6));
      addResult.Text = fraction3.ToString();

      var result1 = Fraction.Substract(service.Resolve<Fraction>(1, 2), service.Resolve<Fraction>(1, 6));
      var result2 = Fraction.Substract(result1, service.Resolve<Fraction>(1, 3));
      var result3 = Fraction.Product(result2, service.Resolve<Fraction>(1, 20));
      expressionResult.Text = result3.ToString();
    }
  }
}
