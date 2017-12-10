using System;
using System.Linq;
using System.Collections.Generic;

using Shaykhullin.Operations;

namespace Shaykhullin
{
  public class ExpressionSyntaxTreeProcessor
  {
    private readonly Tree<Operation> input;
    private readonly IEnumerable<OperationExecutor> operationExecutors;

    public ExpressionSyntaxTreeProcessor(ExpressionSyntaxTreeFormatter formatter)
    {
      input = formatter.FormatOperation();

      operationExecutors = typeof(OperationExecutor).Assembly.GetTypes()
        .Where(t => typeof(OperationExecutor).IsAssignableFrom(t))
        .Where(t => !t.IsAbstract)
        .Select(t => (OperationExecutor)Activator.CreateInstance(t))
        .ToArray();
    }

    public object ExecuteOperaion()
    {
      return ExecuteOperationRecursive(input);

      object ExecuteOperationRecursive(Tree<Operation> node)
      {
        var executor = operationExecutors.SingleOrDefault(ex => ex.IsSatisfied(node.Operation))
          ?? throw new InvalidOperationException("Invalid operation");

        return executor.ExecuteCore(node.Operation, node, ExecuteOperationRecursive);
      }
    }
  }
}
