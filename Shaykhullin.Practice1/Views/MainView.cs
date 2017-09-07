using System;
using System.Windows.Forms;

using Shaykhullin.Models.Practice1;

namespace Shaykhullin.Practice1.Views
{
  public partial class MainView : Form
  {
    public MainView()
    {
      InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
      result.Text = new Fraction(6, 9).ToString();

      var fraction3 = Fraction.Add(new Fraction(2, 9), new Fraction(1, 6));
      addResult.Text = fraction3.ToString();

      var result1 = Fraction.Substract(new Fraction(1, 2), new Fraction(1, 6));
      var result2 = Fraction.Substract(result1, new Fraction(1, 3));
      var result3 = Fraction.Product(result2, new Fraction(1, 20));
      expressionResult.Text = result3.ToString();
    }
  }
}
