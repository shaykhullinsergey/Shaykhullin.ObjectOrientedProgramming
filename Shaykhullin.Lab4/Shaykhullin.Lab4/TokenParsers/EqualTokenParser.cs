using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class EqualTokenParser : TokenParser<EqualToken>
  {
    public override string Name => "==";
  }
}