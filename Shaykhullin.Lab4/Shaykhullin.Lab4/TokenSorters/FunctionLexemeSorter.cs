using System;
using System.Collections.Generic;

using Shaykhullin.Lexemes;

namespace Shaykhullin.LexemeSorters
{
  public class FunctionLexemeSorter : LexemeSorter<FunctionLexeme>
  {
    public override void Sort(Lexeme Lexeme, Lexeme prevLexeme, Queue<Lexeme> input, Queue<Lexeme> output, Stack<Lexeme> stack)
    {
      if (input.Count > 0 && input.Peek() is LeftParenthesisLexeme)
      {
        stack.Push(Lexeme);
      }
      else
      {
        throw new InvalidOperationException("Invalid Lexeme");
      }
    }
  }
}
