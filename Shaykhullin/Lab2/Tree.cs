using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shaykhullin.Lab2
{
  public class Tree<TData>
  {
    public TreeNode<TData> Root { get; }

    public virtual TreeNode<TData> Create(TData data)
    {
      return new TreeNode<TData>(data);
    }
  }
}
