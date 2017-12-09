using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.Lab4.Frontend.Views
{
  public partial class MainView : Form
  {
    public MainView()
    {
      InitializeComponent();
    }

    private void OnKeyUp(object sender, KeyEventArgs e)
    {
      e.Handled = true;

      if(e.KeyCode == Keys.Enter)
      {
        try
        {
          SuspendLayout();
          
          var interpreter = new ExpressionInterpreter(
            processor: new ExpressionSyntaxTreeProcessor(
              formatter: new ExpressionSyntaxTreeFormatter(
                sortProcessor: new ExpressionInfixSortStationProcessor(
                  lexingInterpreter: new ExpressionLexingInterpreter(input.Text)))));

          result.Text = interpreter.Interpret().ToString();
        }
        catch (Exception ex)
        {
          result.Text = ex.Message;
        }
        finally
        {
          ResumeLayout();
        }
      }
    }
  }
}
