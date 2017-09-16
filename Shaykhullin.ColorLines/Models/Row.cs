using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.ColorLines.Models
{
  class Column
  {
    private Tile[] tiles = new Tile[10];

    public Tile this[Button button] => 
      tiles.FirstOrDefault(x => x.Button == button);

    public Tile this[int y]
    {
      get => tiles[y];
      set => tiles[y] = value;
    }
  }
}
