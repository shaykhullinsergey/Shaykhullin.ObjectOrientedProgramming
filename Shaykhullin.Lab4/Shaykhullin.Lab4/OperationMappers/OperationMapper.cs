using System.Collections.Generic;

using Shaykhullin.Tokens;
using Shaykhullin.Operations;
using System;

namespace Shaykhullin.OperationMappers
{
  public abstract class OperationMapper
  {
    public abstract bool IsSatisfied(Token token);
    public abstract Tree<Operation> Parse(Stack<Tree<Operation>> operations);
  }

  public abstract class OperationMapper<TToken, TOperation> : OperationMapper
    where TToken : Token
    where TOperation : Operation
  {
    public override bool IsSatisfied(Token token)
    {
      return token is TToken;
    }
  }

  public abstract class BinaryOperationMapper<TToken, TOperation> 
    : OperationMapper<TToken, TOperation>
      where TToken : Token
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

  public abstract class UnaryOperationMapper<TToken, TOperation>
    : OperationMapper<TToken, TOperation>
      where TToken : Token
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
