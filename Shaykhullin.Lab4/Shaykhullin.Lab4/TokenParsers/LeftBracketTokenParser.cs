using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class LeftBracketTokenParser : TokenParser<LeftBracketToken>
  {
    public override string Name => "(";
  }
}