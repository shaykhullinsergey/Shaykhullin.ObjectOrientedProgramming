using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class DoubleTokenParser : TokenParser
  {
    public override bool IsSatisfied(ILexingContext context)
    {
      return char.IsDigit(context.Current) || context.Current == '.';
    }

    public override Token Parse(ILexingContext context)
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

      return new DoubleToken(context.SubExpression);
    }
  }
}