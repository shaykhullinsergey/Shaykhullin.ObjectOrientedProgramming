using System;
using System.Linq;
using FormsTreeNode = System.Windows.Forms.TreeNode;

namespace Shaykhullin.Lab2
{
  public class FormTree : Tree<FormsTreeNode>
  {
    public FormTree(FormsTreeNode data) : base(data)
    {
      data.Name = Guid.NewGuid().ToString();
    }

    public override Tree<FormsTreeNode> Find(FormsTreeNode data)
    {
      if(data == null)
      {
        return null;
      }

      if (Data.Name == data.Name)
      {
        return this;
      }

      foreach (var child in Children)
      {
        var found = child.Find(data);
        if(found != null)
        {
          return child;
        }
      }

      return null;
    }

    public override FormsTreeNode Render()
    {
      var node = new FormsTreeNode(Data.Text)
      {
        Name = Data.Name
      };
      node.Nodes.AddRange(Children.Select(child => child.Render()).ToArray());
      node.ExpandAll();
      return node;
    }
  }
}
