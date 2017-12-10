using Shaykhullin.Lexemes;

namespace Shaykhullin.Parsers
{
  public class LeftParenthesisLexemeParser : LexemeParser<LeftParenthesisLexeme>
  {
    public override string Name => "(";
  }
}