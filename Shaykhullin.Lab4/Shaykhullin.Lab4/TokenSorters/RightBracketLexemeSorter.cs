using System;
using System.Collections.Generic;

using Shaykhullin.Lexemes;

namespace Shaykhullin.LexemeSorters
{
  public class RightParenthesisLexemeSorter : LexemeSorter<RightParenthesisLexeme>
  {
    public override void Sort(Lexeme Lexeme, Lexeme prevLexeme, Queue<Lexeme> input, Queue<Lexeme> output, Stack<Lexeme> stack)
    {
      while (stack.Count > 0 && !(stack.Peek() is LeftParenthesisLexeme))
        output.Enqueue(stack.Pop());
      if (stack.Count > 0)
        stack.Pop();
      else
        throw new InvalidOperationException("Closing Parenthesis");
      if (stack.Count > 0 && stack.Peek() is FunctionLexeme)
        output.Enqueue(stack.Pop());
    }
  }
}
