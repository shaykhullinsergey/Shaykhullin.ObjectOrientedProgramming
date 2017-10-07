using System.Windows.Forms;

namespace Shaykhullin.Lab2.Views
{
  public partial class MainView : Form
  {
    public MainView()
    {
      InitializeComponent();
    }

    private void OnAddClicked(object sender, System.EventArgs e)
    {
      treeView.SelectedNode?.Nodes.Add(new TreeNode("WORKS!"));
    }

    private void OnAddToChildrenClicked(object sender, System.EventArgs e)
    {
      foreach (TreeNode childNode in treeView.SelectedNode?.Nodes)
      {
        childNode.Nodes.Add(new TreeNode("WORKS!"));
      }
    }

    private void OnRemoveClicked(object sender, System.EventArgs e)
    {
      var selected = treeView.SelectedNode;

      selected?.Parent?.Nodes.Remove(selected);
    }

    private void OnRemoveFromChildrenClicked(object sender, System.EventArgs e)
    {
      
    }

    private void OnRemoveAndMoveChildrenToParentClicked(object sender, System.EventArgs e)
    {
      var selected = treeView.SelectedNode;

      if(selected == null)
      {
        return;
      }
      var parent = selected.Parent;

      if(parent == null)
      {
        return;
      }

      parent.Nodes.Remove(selected);

      foreach (TreeNode child in selected.Nodes)
      {
        parent.Nodes.Add(child);
      }
    }

    private void OnRemoveFromChldrenAndMoveChildrenToParentClicked(object sender, System.EventArgs e)
    {

    }

    private void OnChangeNodeClicked(object sender, System.EventArgs e)
    {

    }

    private void OnRenderClicked(object sender, System.EventArgs e)
    {

    }
  }
}
