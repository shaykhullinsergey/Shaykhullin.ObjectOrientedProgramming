using Shaykhullin.Lexemes;

namespace Shaykhullin.Parsers
{
  public abstract class LexemeParser
  {
    public virtual string Name { get; }
    public abstract Lexeme Parse(ILexingContext context);
    public abstract bool IsSatisfied(ILexingContext context);
  }

  public abstract class LexemeParser<TLexeme> : LexemeParser
    where TLexeme : Lexeme, new()
  {
    public override Lexeme Parse(ILexingContext context)
    {
      context.Caret += Name.Length;
      return new TLexeme();
    }
    public override bool IsSatisfied(ILexingContext context)
    {
      if(context.Start + Name.Length > context.Expression.Length)
      {
        return false;
      }

      for (int index = context.Start; index < context.Start + Name.Length; index++)
      {
        if (char.ToLower(context.Expression[index]) != char.ToLower(Name[index - context.Start]))
        {
          return false;
        }
      }
      return true;
    }
  }
}