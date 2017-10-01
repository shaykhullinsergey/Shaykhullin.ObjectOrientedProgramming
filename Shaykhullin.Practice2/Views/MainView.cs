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
      long integer, numerator, denominator;

      if(double.TryParse(inputTextBox.Text, out var fraction))
      {
        (integer, numerator, denominator) = Fraction.ToProperFraction(fraction);
      }
      else if(double.TryParse(inputTextBox.Text.Replace("(", "").Replace(")", ""), out var periodicFraction))
      {
        (integer, numerator, denominator) = Fraction.FromPeriodicFraction(periodicFraction);
      }
      else
      {
        MessageBox.Show($"{inputTextBox.Text} is invalid double");
        return;
      }

      integerResult.Text = integer.ToString();
      numeratorResult.Text = numerator.ToString();
      denominatorResult.Text = denominator.ToString();
    }
  }
}
