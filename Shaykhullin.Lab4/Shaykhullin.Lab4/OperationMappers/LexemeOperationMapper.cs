using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Operations;

namespace Shaykhullin.OperationMappers
{
  public abstract class LexemeOperationMapper
  {
    public abstract bool IsSatisfied(Lexeme Lexeme);
    public abstract Tree<Operation> Map(Stack<Tree<Operation>> operations);
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
}
