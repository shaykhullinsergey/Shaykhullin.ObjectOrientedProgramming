using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class RightBracketTokenParser : TokenParser<RightBracketToken>
  {
    public override string Name => ")";
  }
}