using Shaykhullin.ColorLines.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.ColorLines.Models
{
  class Field
  {
    private Label score;
    private Column[] columns = new Column[10];

    public Field(MainView view)
    {
      view.GetType()
        .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
        .Where(button => button.Name.StartsWith("button"))
        .Select(button => new Tile
        {
          X = int.Parse(button.Name.Substring(6).Split('_')[0]),
          Y = int.Parse(button.Name.Substring(6).Split('_')[1]),
          Button = button.GetValue(view) as Button,
        })
        .ToList()
        .ForEach(button => this[button.X, button.Y] = button);

      score = view.GetType()
        .GetField("score", BindingFlags.NonPublic | BindingFlags.Instance)
        .GetValue(view) as Label;
    }

    public Tile this[Button button]
    {
      get
      {
        foreach (var column in columns)
        {
          var tile = column[button];

          if (tile != null)
            return tile;
        }

        throw new InvalidOperationException("Wrong button pressed");
      }
    }

    public Tile this[int x, int y]
    {
      get => columns[x - 1][y - 1];
      set 
      {
        if (columns[x - 1] == null)
          columns[x - 1] = new Column();

        columns[x - 1][y - 1] = value;
      }
    }
  }
}
