using System.Collections.Generic;

using Shaykhullin.Tokens;

namespace Shaykhullin.TokenSorters
{
  public class MinusOperationTokenSorter : TokenSorter<MinusToken>
  {
    public override void Sort(Token token, Token prevToken, Queue<Token> input, Queue<Token> output, Stack<Token> stack)
    {
      if (!(prevToken is ValueToken || prevToken is RightBracketToken))
      {
        stack.Push(new UnaryMinusToken());
      }
      else
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

}
