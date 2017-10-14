namespace Shaykhullin.Lab2
{
  public class Tree<TData> : TreeNode<TData>
  {
    public Tree(TData data) : base(data)
    {
    }
    
    public void Add(TreeNode<TData> parent, TreeNode<TData> child)
    {
      child.AddTo(parent);
    }

    public void Remove(TreeNode<TData> node)
    {
      node.RemoveFromParent();
    }

    public void RemoveAndMoveChildrenToParent(TreeNode<TData> node)
    {
      node.RemoveAndMoveChildrenToParent();
    }

    public void Move(TreeNode<TData> node, TreeNode<TData> parent)
    {
      node.MoveTo(parent);
    }

    public virtual TreeNode<TData> Create(TData data)
    {
      return new TreeNode<TData>(data);
    }
  }
}
