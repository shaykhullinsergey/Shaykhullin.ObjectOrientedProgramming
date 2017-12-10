using System;
using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public abstract class BinaryLexemeOperationMapper<TLexeme, TOperation> 
    : LexemeOperationMapper<TLexeme, TOperation>
      where TLexeme : Lexeme
      where TOperation : BinaryOperation, new()
  {
    public override Tree<Operation> Map(Stack<Tree<Operation>> operations)
    {
      if(operations.Count < 2)
      {
        throw new InvalidOperationException("Invalid binary operation");
      }

      return new Tree<Operation>
      {
        Operation = new TOperation(),
        Right = operations.Pop(),
        Left = operations.Pop()
      };
    }
  }
}
