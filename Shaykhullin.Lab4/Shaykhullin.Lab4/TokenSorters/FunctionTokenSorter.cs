using System;
using System.Collections.Generic;

using Shaykhullin.Tokens;

namespace Shaykhullin.TokenSorters
{
  public class FunctionTokenSorter : TokenSorter<FunctionToken>
  {
    public override void Sort(Token token, Token prevToken, Queue<Token> input, Queue<Token> output, Stack<Token> stack)
    {
      if (input.Count > 0 && input.Peek() is LeftBracketToken)
      {
        stack.Push(token);
      }
      else
      {
        throw new InvalidOperationException("Invalid token");
      }
    }
  }
}
