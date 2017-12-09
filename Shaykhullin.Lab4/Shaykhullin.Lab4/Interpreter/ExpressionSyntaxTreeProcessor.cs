using System.Linq;
using System.Collections.Generic;

using Shaykhullin.Operations;

namespace Shaykhullin
{
  public class ExpressionSyntaxTreeProcessor
  {
    private readonly Tree<Operation> input;

    public ExpressionSyntaxTreeProcessor(ExpressionSyntaxTreeFormatter formatter)
    {
      input = formatter.CreateSyntaxTree();
    }

    public object CalcTree()
    {
      return CalcTreeRecursive(input);

      object CalcTreeRecursive(Tree<Operation> node)
      {
        return node.Operation.Calculate(CalcNodes().ToArray());

        IEnumerable<object> CalcNodes()
        {
          if (node.Left != null)
            yield return CalcTreeRecursive(node.Left);

          if (node.Right != null)
            yield return CalcTreeRecursive(node.Right);
        }
      }
    }
  }
}
