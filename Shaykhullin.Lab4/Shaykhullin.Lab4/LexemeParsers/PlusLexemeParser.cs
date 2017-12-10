using Shaykhullin.Lexemes;

namespace Shaykhullin.Parsers
{
  public class PlusLexemeParser : LexemeParser<PlusLexeme>
  {
    public override string Name => "+";
  }

  public class TwelveLexemeParser : LexemeParser<TwelveLexeme>
  {
    public override string Name => "twelve";
  }
}