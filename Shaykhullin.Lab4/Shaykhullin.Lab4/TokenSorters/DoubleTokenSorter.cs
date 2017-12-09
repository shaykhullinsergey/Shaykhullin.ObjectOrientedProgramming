using System.Collections.Generic;

using Shaykhullin.Tokens;

namespace Shaykhullin.TokenSorters
{
  public class DoubleTokenSorter : TokenSorter<DoubleToken>
  {
    public override void Sort(Token token, Token prevToken, Queue<Token> input, Queue<Token> output, Stack<Token> stack)
    {
      output.Enqueue(token);
    }
  }
}
