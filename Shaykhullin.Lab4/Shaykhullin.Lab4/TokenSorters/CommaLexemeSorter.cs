using System;
using System.Collections.Generic;

using Shaykhullin.Lexemes;

namespace Shaykhullin.LexemeSorters
{
  public class CommaLexemeSorter : LexemeSorter<CommaLexeme>
  {
    public override void Sort(Lexeme Lexeme, Lexeme prevLexeme, Queue<Lexeme> input, Queue<Lexeme> output, Stack<Lexeme> stack)
    {
      if(!(prevLexeme is ValueLexeme || prevLexeme is RightParenthesisLexeme))
      {
        throw new InvalidOperationException("Invalid Lexeme");
      }
    }
  }
}
