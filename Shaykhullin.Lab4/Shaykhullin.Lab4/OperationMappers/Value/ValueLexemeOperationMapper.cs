using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public abstract class ValueLexemeOperationMapper<TLexeme, TOperation>
    : LexemeOperationMapper<TLexeme, TOperation>
    where TLexeme : Lexeme
    where TOperation : ValueOperation, new()
  {
    public override Tree<Operation> Map(Stack<Tree<Operation>> operations)
    {
      return new Tree<Operation>
      {
        Operation = new TOperation()
      };
    }
  }
}
