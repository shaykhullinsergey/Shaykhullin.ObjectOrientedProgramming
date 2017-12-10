using Shaykhullin.Lexemes;

namespace Shaykhullin.Parsers
{
  public class GreaterLexemeParser : LexemeParser<GreaterLexeme>
  {
    public override string Name => ">";

    public override bool IsSatisfied(ILexingContext context) =>
      base.IsSatisfied(context) && context.Expression[context.Caret + 1] != '=';
  }
}