using System;
using System.Collections.Generic;

using Shaykhullin.Tokens;

namespace Shaykhullin.TokenSorters
{
  public class RightBracketTokenSorter : TokenSorter<RightBracketToken>
  {
    public override void Sort(Token token, Token prevToken, Queue<Token> input, Queue<Token> output, Stack<Token> stack)
    {
      while (stack.Count > 0 && !(stack.Peek() is LeftBracketToken))
        output.Enqueue(stack.Pop());
      if (stack.Count > 0)
        stack.Pop();
      else
        throw new InvalidOperationException("Closing bracket");
      if (stack.Count > 0 && stack.Peek() is FunctionToken)
        output.Enqueue(stack.Pop());
    }
  }
}
