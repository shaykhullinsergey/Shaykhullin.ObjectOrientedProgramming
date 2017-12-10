
using Shaykhullin.Operations;
using System;

namespace Shaykhullin
{
  public class BinaryOperationExecutor : OperationExecutor<BinaryOperation>
  {
    public override object Execute(
      BinaryOperation operation, 
      Tree<Operation> node,
      Func<Tree<Operation>, object> executeRecursive)
    {
      return operation.ExecuteCore(executeRecursive(node.Left), executeRecursive(node.Right));
    }
  }
}
