using Shaykhullin.Lexemes;

namespace Shaykhullin.Parsers
{
  public class LessLexemeParser : LexemeParser<LessLexeme>
  {
    public override string Name => "<";

    public override bool IsSatisfied(ILexingContext context) =>
      base.IsSatisfied(context) && context.Expression[context.Caret + 1] != '=';
  }
}