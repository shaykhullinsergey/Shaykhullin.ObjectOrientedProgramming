﻿using System.Collections.Generic;

using Shaykhullin.Lexemes;

namespace Shaykhullin.LexemeSorters
{
  public class BooleanLexemeSorter : LexemeSorter<BooleanLexeme>
  {
    public override void Sort(Lexeme lexeme, Lexeme prevLexeme, Queue<Lexeme> input, Queue<Lexeme> output, Stack<Lexeme> stack)
    {
      output.Enqueue(lexeme);
    }
  }
}
