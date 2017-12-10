
using Shaykhullin.Operations;
using System;

namespace Shaykhullin
{
  public abstract class OperationExecutor
  {
    public abstract bool IsSatisfied(Operation operation);
    public abstract object ExecuteCore(
      Operation operation,
      Tree<Operation> node,
      Func<Tree<Operation>, object> executeRecursive);
  }

  public abstract class OperationExecutor<TOperation> : OperationExecutor
    where TOperation : Operation
  {
    public override bool IsSatisfied(Operation operation)
    {
      return operation is TOperation;
    }

    public sealed override object ExecuteCore(
      Operation operation, 
      Tree<Operation> node, 
      Func<Tree<Operation>, object> executeRecursive)
    {
      return Execute((TOperation)operation, node, executeRecursive);
    }

    public abstract object Execute(
      TOperation operation, 
      Tree<Operation> node, 
      Func<Tree<Operation>, object> executeRecursive);
  }
}
