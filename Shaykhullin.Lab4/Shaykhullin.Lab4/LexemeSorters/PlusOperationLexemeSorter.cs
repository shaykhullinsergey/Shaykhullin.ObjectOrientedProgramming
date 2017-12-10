using System.Collections.Generic;

using Shaykhullin.Lexemes;

namespace Shaykhullin.LexemeSorters
{
  public class PlusOperationLexemeSorter : LexemeSorter<PlusLexeme>
  {
    public override void Sort(Lexeme lexeme, Lexeme prevLexeme, Queue<Lexeme> input, Queue<Lexeme> output, Stack<Lexeme> stack)
    {
      if(!(prevLexeme is ValueLexeme || prevLexeme is RightParenthesisLexeme))
      {
        stack.Push(new UnaryPlusLexeme());
      }
      else
      {
        while (stack.Count > 0 && stack.Peek() is OperationLexeme)
        {
          if (stack.Peek().Order >= lexeme.Order)
            break;

          output.Enqueue(stack.Pop());
        }

        stack.Push(lexeme);
      }
    }
  }

}
