using System;
using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public abstract class UnaryLexemeOperationMapper<TLexeme, TOperation>
    : LexemeOperationMapper<TLexeme, TOperation>
      where TLexeme : Lexeme
      where TOperation : UnaryOperation, new()
  {
    public override Tree<Operation> Map(Stack<Tree<Operation>> operations)
    {
      if (operations.Count < 1)
      {
        throw new InvalidOperationException("Invalid unary operation");
      }

      return new Tree<Operation>
      {
        Operation = new TOperation(),
        Right = operations.Pop()
      };
    }
  }
}
