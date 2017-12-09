using System;
using System.Collections.Generic;

using Shaykhullin.Tokens;

namespace Shaykhullin.TokenSorters
{
  public class CommaTokenSorter : TokenSorter<CommaToken>
  {
    public override void Sort(Token token, Token prevToken, Queue<Token> input, Queue<Token> output, Stack<Token> stack)
    {
      if(!(prevToken is ValueToken || prevToken is RightBracketToken))
      {
        throw new InvalidOperationException("Invalid token");
      }
    }
  }
}
