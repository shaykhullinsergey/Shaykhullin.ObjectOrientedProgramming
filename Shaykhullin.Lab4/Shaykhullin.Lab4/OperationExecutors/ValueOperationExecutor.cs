
using Shaykhullin.Operations;
using System;

namespace Shaykhullin
{
  public class ValueOperationExecutor 
    : OperationExecutor<ValueOperation>
  {
    public override object Execute(
      ValueOperation operation,
      Tree<Operation> node,
      Func<Tree<Operation>, object> executeRecursive)
    {
      return operation.ExecuteCore();
    }
  }
}
