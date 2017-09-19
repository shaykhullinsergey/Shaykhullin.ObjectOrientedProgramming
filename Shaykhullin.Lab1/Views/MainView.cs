using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Shaykhullin.Extensions;
using Shaykhullin.Shared.Lab1.Drawables;
using Shaykhullin.Shared.Lab1.ProcessingStrategies;
using Shaykhullin.DependencyInjection;
using Shaykhullin.DependencyInjection.Abstraction;

namespace Shaykhullin.Lab1.Views
{
  public partial class MainView : Form
  {
    [Inject]
    private IService service;
    [Inject]
    private IReadOnlyDictionary<string, Type> drawables;
    [Inject]
    private IStateValueProcessingStrategy<Bitmap, DrawableBase, (int, int)> strategy;
    [Inject]
    private Bitmap bitmap;

    public MainView()
    {
      InitializeComponent();
    }

    private void OnLoad(object sender, EventArgs e)
    {
      image.Image = bitmap;
    }

    private void OnSelected(object sender, EventArgs e)
    {
      strategy.State = service.Create<DrawableBase>(drawables[(sender as ComboBox).Text]);
      image.Image = strategy.Process();
    }

    private void OnValueChanged(object sender, EventArgs e)
    {
      if (strategy.State == null)
      {
        MessageBox.Show("Select figure!", "Figure not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }

      strategy.Value = (sender.ParseTag(), (sender as TrackBar).Value);
      image.Image = strategy.Process();
    }
  }
}
