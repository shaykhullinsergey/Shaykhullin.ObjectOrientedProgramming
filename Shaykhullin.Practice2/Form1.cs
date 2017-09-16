using System;
using System.Windows.Forms;

using Shaykhullin.Models.Practice1;

namespace Shaykhullin.Practice2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
      if(double.TryParse(inputTextBox.Text, out var number))
      {
        var (integer, numerator, denominator) = Fraction.ToProperFraction(number);

        integerResult.Text = integer.ToString();
        numeratorResult.Text = numerator.ToString();
        denominatorResult.Text = denominator.ToString();
      }
      else
      {
        MessageBox.Show($"{inputTextBox.Text} is invalid double");
      }
    }
  }
}
