using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Shaykhullin.Extensions;
using Shaykhullin.Shared.Lab1.Drawables;
using Shaykhullin.Shared.Lab1.ProcessingStrategies;

namespace Shaykhullin.Lab1.Views
{
  public partial class MainView : Form
  {
    private Dictionary<string, Type> drawables = new Dictionary<string, Type>
    {
      ["Star"] = typeof(StarDrawable),
      ["Hexagon"] = typeof(HexagonDrawable),
      ["Twenty Star"] = typeof(TwentyStarDrawable),
      ["Greek Cross"] = typeof(GreekCrossDrawable)
    };
    private IStateValueProcessingStrategy<Bitmap, DrawableBase, (int, int)> strategy;

    public MainView()
    {
      InitializeComponent();
      image.Image = new Bitmap(image.Width, image.Height);
      comboBox2.Items.AddRange(drawables.Keys.ToArray());
    }

    private void OnSelected(object sender, EventArgs e)
    {
      var instance = Activator.CreateInstance(drawables[(sender as ComboBox).Text], image.Image) as DrawableBase;

      strategy = strategy ?? new LoopProcessingStrategy(instance);
      strategy.State = instance;
      image.Image = strategy.Process();
    }

    private void OnValueChanged(object sender, EventArgs e)
    {
      if (strategy == null)
      {
        MessageBox.Show("Select figure!", "Figure not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      strategy.Value = (sender.ParseTag(), (sender as TrackBar).Value);
      image.Image = strategy.Process();
    }
  }
}
