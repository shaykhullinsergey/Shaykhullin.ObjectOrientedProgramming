using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Shaykhullin.Lab2
{
  public static class Extensions
  {
    public static TreeNode Render(this BinaryTreeNode<TreeNode> tree)
    {
      return new TreeNode(tree.Data.Text,
        new[] { tree.Left, tree.Right }
          .Where(x => x != null)
          .Select(x => x.Render()).ToArray())
      {
        Tag = tree.Data.Tag
      };
    }
  }

  public class BinaryTreeNode<TData> : IEnumerable<BinaryTreeNode<TData>>
  {
    public TData Data { get; set; }
    public BinaryTreeNode<TData> Parent { get; set; }
    public BinaryTreeNode<TData> Left { get; set; }
    public BinaryTreeNode<TData> Right { get; set; }

    public BinaryTreeNode(TData data)
    {
      Data = data;
    }

    public void Remove()
    {
      if (Parent?.Left == this)
      {
        Parent.Left = null;
      }
      else if(Parent?.Right == this)
      {
        Parent.Right = null;
      }
    }

    public IEnumerator<BinaryTreeNode<TData>> GetEnumerator()
    {
      foreach (var node in Left ?? Enumerable.Empty<BinaryTreeNode<TData>>())
      {
        yield return node;
      }

      yield return this;

      foreach (var node in Right ?? Enumerable.Empty<BinaryTreeNode<TData>>())
      {
        yield return node;
      }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
}
