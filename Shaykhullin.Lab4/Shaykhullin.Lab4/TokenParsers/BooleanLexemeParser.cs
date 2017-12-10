using Shaykhullin.Lexemes;

namespace Shaykhullin.Parsers
{
  public abstract class BooleanLexemeParser : LexemeParser<BooleanLexeme>
  {
    public override Lexeme Parse(ILexingContext context)
    {
      base.Parse(context);
      return new BooleanLexeme(Name);
    }
  }
}