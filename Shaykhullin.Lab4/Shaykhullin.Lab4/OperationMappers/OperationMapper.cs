using System;
using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public abstract class LexemeOperationMapper
  {
    public abstract bool IsSatisfied(Lexeme Lexeme);
    public abstract Tree<Operation> Parse(Stack<Tree<Operation>> operations);
  }

  public abstract class LexemeOperationMapper<TLexeme, TOperation> : LexemeOperationMapper
    where TLexeme : Lexeme
    where TOperation : Operation
  {
    public override bool IsSatisfied(Lexeme Lexeme)
    {
      return Lexeme is TLexeme;
    }
  }

  public abstract class BinaryLexemeOperationMapper<TLexeme, TOperation> 
    : LexemeOperationMapper<TLexeme, TOperation>
      where TLexeme : Lexeme
      where TOperation : Operation, new()
  {
    public override Tree<Operation> Parse(Stack<Tree<Operation>> operations)
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

  public abstract class UnaryLexemeOperationMapper<TLexeme, TOperation>
    : LexemeOperationMapper<TLexeme, TOperation>
      where TLexeme : Lexeme
      where TOperation : Operation, new()
  {
    public override Tree<Operation> Parse(Stack<Tree<Operation>> operations)
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
