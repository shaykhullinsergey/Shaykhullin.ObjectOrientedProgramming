using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public class BooleanLexemeOperationMapper
    : LexemeOperationMapper<BooleanLexeme, DoubleValue>
  {
    private Lexeme Lexeme;

    public override bool IsSatisfied(Lexeme Lexeme)
    {
      return base.IsSatisfied((this.Lexeme = Lexeme));
    }

    public override Tree<Operation> Map(Stack<Tree<Operation>> operations)
    {
      return new Tree<Operation>
      {
        Operation = new BooleanValue(((BooleanLexeme)Lexeme).Value)
      };
    }
  }
}
