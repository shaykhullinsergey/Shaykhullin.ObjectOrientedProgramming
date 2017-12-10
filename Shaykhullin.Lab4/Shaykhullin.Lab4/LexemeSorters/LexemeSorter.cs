using System.Collections.Generic;

using Shaykhullin.Lexemes;

namespace Shaykhullin.LexemeSorters
{
  public abstract class LexemeSorter
  {
    public abstract bool IsSatisfied(Lexeme Lexeme);
    public abstract void Sort(Lexeme Lexeme, Lexeme prevLexeme, Queue<Lexeme> input, Queue<Lexeme> output, Stack<Lexeme> stack);
  }

  public abstract class LexemeSorter<TLexeme> 
    : LexemeSorter where TLexeme : Lexeme
  {
    public override bool IsSatisfied(Lexeme Lexeme)
    {
      return Lexeme is TLexeme;
    }
  }
}
