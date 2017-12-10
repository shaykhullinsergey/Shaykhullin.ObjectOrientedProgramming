﻿using System.Collections.Generic;

using Shaykhullin.Lexemes;

namespace Shaykhullin.LexemeSorters
{
  public class OperationLexemeSorter : LexemeSorter<OperationLexeme>
  {
    public override bool IsSatisfied(Lexeme Lexeme)
    {
      return base.IsSatisfied(Lexeme) && !(Lexeme is PlusLexeme || Lexeme is MinusLexeme);
    }

    public override void Sort(Lexeme Lexeme, Lexeme prevLexeme, Queue<Lexeme> input, Queue<Lexeme> output, Stack<Lexeme> stack)
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
