using System;

namespace Shaykhullin.Lab2
{
  public class BinaryTree<TData> : BinaryTreeNode<TData>
  {
    public Func<TData, TData, bool> Comparer { get; set; }

    public BinaryTree(TData data, Func<TData, TData, bool> comparer) : base(data)
    {
      Comparer = comparer ?? throw new ArgumentNullException(nameof(comparer));
    }

    public void Add(BinaryTreeNode<TData> node)
    {
      AddRecursive(this, node);
    }

    private void AddRecursive(BinaryTreeNode<TData> parent, BinaryTreeNode<TData> node)
    {
      if (Comparer(node.Data, parent.Data))
      {
        if (parent.Left == null)
        {
          parent.Left = node;
          node.Parent = parent;
        }
        else
        {
          AddRecursive(parent.Left, node);
        }
      }
      else
      {
        if (parent.Right == null)
        {
          parent.Right = node;
          node.Parent = parent;
        }
        else
        {
          AddRecursive(parent.Right, node);
        }
      }
    }

    public void Remove(BinaryTreeNode<TData> node)
    {
      node.Remove();
    }
  }
}
