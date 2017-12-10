using System.Collections.Generic;

using Shaykhullin.Lexemes;

namespace Shaykhullin.LexemeSorters
{
  public class MinusOperationLexemeSorter : LexemeSorter<MinusLexeme>
  {
    public override void Sort(Lexeme Lexeme, Lexeme prevLexeme, Queue<Lexeme> input, Queue<Lexeme> output, Stack<Lexeme> stack)
    {
      if (!(prevLexeme is ValueLexeme || prevLexeme is RightParenthesisLexeme))
      {
        stack.Push(new UnaryMinusLexeme());
      }
      else
      {
        while (stack.Count > 0 && stack.Peek() is OperationLexeme)
        {
          if (stack.Peek().Order >= Lexeme.Order)
            break;

          output.Enqueue(stack.Pop());
        }

        stack.Push(Lexeme);
      }
    }
  }

}
