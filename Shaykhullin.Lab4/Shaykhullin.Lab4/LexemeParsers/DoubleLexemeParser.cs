using Shaykhullin.Lexemes;

namespace Shaykhullin.Parsers
{
  public class DoubleLexemeParser : LexemeParser
  {
    public override bool IsSatisfied(ILexingContext context)
    {
      return char.IsDigit(context.Current) || context.Current == '.';
    }

    public override Lexeme Parse(ILexingContext context)
    {
      var hasSeparator = false;
      var hasExp = false;

      while (char.IsDigit(context.Current) 
        || (context.Current == '.' && !hasSeparator)
        || ((context.Current == 'e' || context.Current == 'E') && !hasExp)
        || context.Current == '-' && hasExp)
      {
        if (context.Current == '.' && !hasSeparator)
          hasSeparator = true;

        if ((context.Current == 'e' || context.Current == 'E') && !hasExp)
          hasExp = true;

        context.Caret++;
      }

      return new DoubleLexeme(context.SubExpression);
    }
  }
}