using Shaykhullin.ColorLines.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.ColorLines.Views
{
  public partial class MainView : Form
  {
    private Game game;

    public MainView()
    {
      InitializeComponent();
      game = new Game(this);
    }

    private void OnMouseClicked(object sender, MouseEventArgs e)
    {
      game.ButtonClicked(sender as Button);
    }
  }
}
