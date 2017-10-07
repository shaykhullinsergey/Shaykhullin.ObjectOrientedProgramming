using System.Collections;
using System.Collections.Generic;

namespace Shaykhullin.Lab2
{
  public class TreeNode<TData> : IEnumerable<TData>
  {
    public TData Data { get; }
    public IList<TreeNode<TData>> Children { get; }
    public TreeNode<TData> Parent { get; private set; }

    public TreeNode()
    {
      Children = new List<TreeNode<TData>>();
    }

    public TreeNode(TData data) : this()
    {
      Data = data;
    }

    public void AddTo(TreeNode<TData> parent)
    {
      Parent = parent;  
      parent.Children.Add(this);
    }

    // AddToChildrenOf

    public void RemoveFrom(TreeNode<TData> parent)
    {
      parent.Children.Remove(this);
    }

    // RemoveFromChildrenOf

    public void RemoveWithMoveFrom(TreeNode<TData> node)
    {
      RemoveFrom(node);

      foreach (var child in Children)
      {
        child.AddTo(node);
      }
    }

    //RemoveWithMoveFromChildrenOf

    public void MoveParent(TreeNode<TData> newParent)
    {
      Parent?.Children.Remove(this);

      Parent = newParent;
      Parent.Children.Add(this);
    }

    public IEnumerator<TData> GetEnumerator()
    {
      yield return Data;

      foreach (var child in Children)
      {
        foreach (var childData in child)
        {
          yield return childData;
        }
      }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
}
