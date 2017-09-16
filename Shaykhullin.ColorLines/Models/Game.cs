using Shaykhullin.ColorLines.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.ColorLines.Models
{
  class Game
  {
    private Field field;

    public Game(MainView view)
    {
      field = new Field(view);
    }

    public void ButtonClicked(Button button)
    {
      // field.ActionStrategy = SelectTile, EndTurn
      var tile = field[button];
      tile.Button.Text = "asd";
    }
  }
}
