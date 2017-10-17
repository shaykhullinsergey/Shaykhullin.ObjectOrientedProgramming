using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaykhullin.Lab2.Views
{
  public partial class MainView : Form
  {
    private TreeNode prevNode;
    private Tree<TreeNode> tree;
    private BinaryTree<TreeNode> binaryTree;

    public MainView()
    {
      InitializeComponent();
    }

    private void OnAddClicked(object sender, EventArgs a)
    {
      var node = leftTree.SelectedNode;
      
      if(node == null)
      {
        if(tree == null)
        {
          var selected = new AddView();
          selected.button1.Click += (s, e) =>
          {
            if (string.IsNullOrWhiteSpace(selected.textBox1.Text))
            {
              selected.label1.Text = "Enter a node name!";
            }
            else
            {
              tree = new Tree<TreeNode>(new TreeNode(selected.textBox1.Text));
              leftTree.Nodes.Add(tree.Data);
              treeStatus.Text = $"Added: {tree.Data.Text}";
              selected.Hide();
            }
          };
          selected.ShowDialog();
        }
        else
        {
          treeStatus.Text = "Select node!";
        }
      }
      else
      {
        var selected = new AddView();
        selected.button1.Click += (s, e) =>
        {
          if (string.IsNullOrWhiteSpace(selected.textBox1.Text))
          {
            selected.label1.Text = "Enter a node name!";
          }
          else
          {
            var treeNode = new TreeNode<TreeNode>(new TreeNode(selected.textBox1.Text));
            var parent = tree.Single(t => t.Data == node);
            treeNode.AddTo(parent);
            node.Nodes.Add(treeNode.Data);
            node.Expand();

            treeStatus.Text = $"Added: {treeNode.Data.Text}";
            selected.Hide();
          }
        };
        selected.ShowDialog();
      }
    }

    private void OnRemoveClicked(object sender, EventArgs e)
    {
      var node = leftTree.SelectedNode;

      if(node == null)
      {
        treeStatus.Text = "Select node!";
        return;
      }

      var treeNode = tree.Single(t => t.Data == node);
      if(treeNode is Tree<TreeNode>)
      {
        tree = null;
      }
      treeNode.RemoveFromParent();
      leftTree.Nodes.Remove(node);

      treeStatus.Text = $"Removed: {node.Text}";

      leftTree.SelectedNode = null;
    }

    private void OnRemoveAndMoveChildrenClicked(object sender, EventArgs e)
    {
      var node = leftTree.SelectedNode;
      if (node == null)
      {
        treeStatus.Text = "Select node!";
        return;
      }

      var treeNode = tree.Single(t => t.Data == node);
      if (treeNode is Tree<TreeNode>)
      {
        tree = null;
      }
      
      treeNode.RemoveAndMoveChildrenToParent();
      if(node.Parent != null)
      {
        if(node.Nodes.Count == 0)
        {
          treeStatus.Text = $"Removed: {node.Text} no children";
        }
        else
        {
          for (var i = node.Nodes.Count - 1; i >= 0; i--)
          {
            var child = node.Nodes[i];

            node.Nodes.Remove(child);
            node.Parent.Nodes.Add(child);
          }
          treeStatus.Text = $"Removed: {node.Text} with move children to parent {node.Parent.Text}";
        }
      }
      else
      {
        treeStatus.Text = $"Removed: {node.Text}";
      }
      leftTree.Nodes.Remove(node);

      leftTree.SelectedNode = null;
    }

    private void OnMoveClicked(object sender, EventArgs e)
    {
      var node = leftTree.SelectedNode;

      if(node == null)
      {
        treeStatus.Text = "Select node!";
        return;
      }

      if(prevNode == null)
      {
        prevNode = node;
        treeStatus.Text = $"Selected: {prevNode.Text} to move";
        return;
      }

      if(prevNode == node)
      {
        treeStatus.Text = "Can't move equal nodes!";
        return;
      }

      var treeNode = tree.Single(t => t.Data == prevNode);
      var parent = tree.Single(t => t.Data == node);
      tree.Move(treeNode, parent);

      prevNode.Parent.Nodes.Remove(prevNode);
      node.Nodes.Add(prevNode);
      node.Expand();

      treeStatus.Text = $"Moved: {prevNode.Text} to {node.Text}";

      prevNode = null;
    }

    private async void OnNodeSelected(object sender, MouseEventArgs e)
    {
      await Task.Delay(150);
      treeStatus.Text = $"Selected: {leftTree.SelectedNode?.Text}";
    }
    private void OnLocalStateClicked(object sender, EventArgs e)
    {
      rightTree.Nodes.Clear();
      rightTree.Nodes.Add((TreeNode)tree.Data.Clone());
      rightTree.ExpandAll();
    }

    private void OnBinaryAddClicked(object sender, EventArgs a)
    {
      if (binaryTree == null)
      {
        var selected = new AddView();
        selected.button1.Click += (s, e) =>
        {
          if (!int.TryParse(selected.textBox1.Text, out var _))
          {
            selected.label1.Text = "Node must be a number!";
          }
          else
          {
            binaryTree = new BinaryTree<TreeNode>(new TreeNode(selected.textBox1.Text),
              (t1, t2) => int.Parse(t1.Text) < int.Parse(t2.Text))
            {
              Data =
              {
                Tag = Guid.NewGuid()
              }
            };

            binaryTreeView.Nodes.Add(binaryTree.Data);
            binaryTreeStatus.Text = $"Added: {binaryTree.Data.Text}";
            selected.Hide();
          }
        };
        selected.ShowDialog();
      }
      else
      {
        var selected = new AddView();
        selected.button1.Click += (s, e) =>
        {
          if (!int.TryParse(selected.textBox1.Text, out var _))
          {
            selected.label1.Text = "Node must be a number!";
          }
          else
          {
            var treeNode = new BinaryTreeNode<TreeNode>(new TreeNode(selected.textBox1.Text))
            {
              Data =
              {
                Tag = Guid.NewGuid()
              }
            };
            binaryTree.Add(treeNode);

            binaryTreeView.Nodes.Clear();
            binaryTreeView.Nodes.Add(binaryTree.Render());
            binaryTreeView.ExpandAll();

            binaryTreeStatus.Text = $"Added: {treeNode.Data.Text}";
            selected.Hide();
          }
        };
        selected.ShowDialog();
      }
    }

    private void OnBinaryRemoveClicked(object sender, EventArgs e)
    {
      var node = binaryTreeView.SelectedNode;

      if(node == null)
      {
        binaryTreeStatus.Text = "Select node!";
        return;
      }

      var treeNode = binaryTree.First(t => t.Data.Tag == node.Tag);
      if(treeNode is BinaryTree<TreeNode>)
      {
        binaryTree = null;
      }

      if(binaryTree != null)
      {
        treeNode.Remove();
        binaryTreeView.Nodes.Clear();
        binaryTreeView.Nodes.Add(binaryTree.Render());
        binaryTreeView.ExpandAll();
      }
      else
      {
        binaryTreeView.Nodes.Clear();
      }

      binaryTreeStatus.Text = $"Removed: {treeNode.Data.Text}";
    }

    private async void OnBinaryNodeSelected(object sender, MouseEventArgs e)
    {
      await Task.Delay(150);
      binaryTreeStatus.Text = $"Selected: {binaryTreeView.SelectedNode?.Text}";
    }

    private void OnRenderButtonClicked(object sender, EventArgs e)
    {
      renderListView.Items.Clear();
      renderListView.Items.AddRange(tree.Select(x => x.Data.Text).ToArray());
    }
  }
}
