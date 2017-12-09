using System.Collections.Generic;

using Shaykhullin.Tokens;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public class BooleanTokenOperationMapper
    : OperationMapper<BooleanToken, DoubleValue>
  {
    private Token token;

    public override bool IsSatisfied(Token token)
    {
      return base.IsSatisfied((this.token = token));
    }

    public override Tree<Operation> Parse(Stack<Tree<Operation>> operations)
    {
      return new Tree<Operation>
      {
        Operation = new BooleanValue(((BooleanToken)token).Value)
      };
    }
  }
}
