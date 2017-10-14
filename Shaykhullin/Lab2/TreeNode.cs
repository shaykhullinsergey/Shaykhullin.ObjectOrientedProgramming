using System;
using System.Collections;
using System.Collections.Generic;

namespace Shaykhullin.Lab2
{
  public class TreeNode<TData> : IEnumerable<TreeNode<TData>>
  {
    public TData Data { get; set; }
    public TreeNode<TData> Parent { get; set; }
    public IList<TreeNode<TData>> Children { get; set; }

    public TreeNode(TData data)
    {
      Data = data;
      Children = new List<TreeNode<TData>>();
    }

    public void AddTo(TreeNode<TData> parent)
    {
      if (Parent != null)
      {
        throw new InvalidOperationException($"TreeNode<TData> {Data} have already added to parent");
      }

      Parent = parent;
      Parent.Children.Add(this);
    }

    public void RemoveFromParent()
    {
      Parent?.Children.Remove(this);
      Parent = null;
    }

    public void RemoveAndMoveChildrenToParent()
    {
      if (Parent == null)
      {
        RemoveFromParent();
        return;
      }

      foreach (var child in Children)
      {
        child.Parent = null;
        child.AddTo(Parent);
      }

      RemoveFromParent();
    }

    public void MoveTo(TreeNode<TData> parent)
    {
      if (Parent == null)
      {
        throw new InvalidOperationException($"TreeNode<TData> {Data} have no parent");
      }

      RemoveFromParent();
      AddTo(parent);
    }

    public IEnumerator<TreeNode<TData>> GetEnumerator()
    {
      yield return this;

      foreach (var child in Children)
      {
        foreach (var data in child)
        {
          yield return data;
        }
      }
    }
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
}

