using System;
using System.Windows.Forms;

using Shaykhullin.Shared.Practice1;

namespace Shaykhullin.Practice2
{
  public partial class MainView : Form
  {
    public MainView()
    {
      InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
      var result = Fraction.ParseToProperFraction(inputTextBox.Text);

      if(!result.HasValue)
      {
        MessageBox.Show($"{inputTextBox.Text} is invalid double");
        return;
      }

      integerResult.Text = result.Value.Integer.ToString();
      numeratorResult.Text = result.Value.Numerator.ToString();
      denominatorResult.Text = result.Value.Denominator.ToString();
    }
  }
}
