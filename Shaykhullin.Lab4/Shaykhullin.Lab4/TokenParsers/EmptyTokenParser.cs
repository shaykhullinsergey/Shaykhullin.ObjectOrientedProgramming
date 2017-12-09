using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class EmptyTokenParser : TokenParser<EmptyToken>
  {
    public override string Name => " ";
  }
}