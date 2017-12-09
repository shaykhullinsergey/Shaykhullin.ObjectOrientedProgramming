using System.Collections.Generic;

using Shaykhullin.Tokens;

namespace Shaykhullin.TokenSorters
{
  public class OperationTokenSorter : TokenSorter<OperationToken>
  {
    public override bool IsSatisfied(Token token)
    {
      return base.IsSatisfied(token) && !(token is PlusToken || token is MinusToken);
    }

    public override void Sort(Token token, Token prevToken, Queue<Token> input, Queue<Token> output, Stack<Token> stack)
    {
      while (stack.Count > 0 && stack.Peek() is OperationToken)
      {
        if (stack.Peek().Order >= token.Order)
          break;

        output.Enqueue(stack.Pop());
      }

      stack.Push(token);
    }
  }
}
