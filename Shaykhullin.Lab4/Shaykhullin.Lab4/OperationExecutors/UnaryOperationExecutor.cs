
using Shaykhullin.Operations;
using System;

namespace Shaykhullin
{
  public class UnaryOperationExecutor : OperationExecutor<UnaryOperation>
  {
    public override object Execute(
      UnaryOperation operation,
      Tree<Operation> node,
      Func<Tree<Operation>, object> executeRecursive)
    {
      return operation.ExecuteCore(executeRecursive(node.Left ?? node.Right));
    }
  }
}
