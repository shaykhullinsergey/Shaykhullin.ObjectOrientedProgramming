using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shaykhullin.Lab2
{
  public abstract class Tree<TData>
  {
    public TData Data { get; set; }
    public Tree<TData> Parent { get; private set; }
    public IList<Tree<TData>> Children { get; private set; }

    public Tree(TData data)
    {
      Data = data;
      Children = new List<Tree<TData>>();
    }

    public abstract TData Render();

    public abstract Tree<TData> Find(TData data);

    public virtual void AddTo(Tree<TData> node)
    {
      node.Children.Add(this);
      Parent = node;
    }

    public virtual void AddToChildren(Tree<TData> node)
    {
      foreach (var child in node.Children)
      {
        AddTo(child);
      }
    }

    public virtual void Remove()
    {
      if (Parent == null)
      {
        return;
      }

      foreach (var child in Children)
      {
        child.AddTo(Parent);
      }

      Parent.Children.Remove(this);
    }

    public void DropTree() => Parent?.Children.Remove(this);
  }
}
