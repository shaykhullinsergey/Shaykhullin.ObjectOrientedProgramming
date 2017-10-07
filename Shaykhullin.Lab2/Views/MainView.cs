using Shaykhullin.Injection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.Lab2.Views
{
  public partial class MainView : Form
  {
    [Inject]
    private FormTree tree;

    public TreeNode CurrentNode => treeView.SelectedNode;

    public MainView()
    {
      InitializeComponent();
    }

    private void OnFormLoaded(object sender, EventArgs e)
    {
      var node = new FormTree(new TreeNode("WORKS!"));

      node.AddTo(tree);

      RenderView();
    }

    private void OnAddClicked(object sender, EventArgs e)
    {
      var treeNode = tree.Find(CurrentNode);

      if(treeNode == null)
      {
        return;
      }

      var node = new FormTree(new TreeNode("Works!"));
      node.AddTo(treeNode);

      RenderView();
    }

    private void OnAddToChildrenClicked(object sender, EventArgs e)
    {

    }

    private void OnRemoveClicked(object sender, EventArgs e)
    {

    }

    private void OnDropTreeClicked(object sender, EventArgs e)
    {

    }

    private void RenderView()
    {
      treeView.BeginUpdate();
      treeView.Nodes.Clear();
      treeView.Nodes.Add(tree.Render());
      treeView.EndUpdate();
    }
  }
}
