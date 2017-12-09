using System.Collections.Generic;

using Shaykhullin.Tokens;

namespace Shaykhullin.TokenSorters
{
  public abstract class TokenSorter
  {
    public abstract bool IsSatisfied(Token token);
    public abstract void Sort(Token token, Token prevToken, Queue<Token> input, Queue<Token> output, Stack<Token> stack);
  }

  public abstract class TokenSorter<TToken> 
    : TokenSorter where TToken : Token
  {
    public override bool IsSatisfied(Token token)
    {
      return token is TToken;
    }
  }
}
