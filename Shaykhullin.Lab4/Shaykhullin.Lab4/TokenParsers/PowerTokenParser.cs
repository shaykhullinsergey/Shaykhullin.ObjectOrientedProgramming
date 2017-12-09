using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class PowerTokenParser : TokenParser<PowerToken>
  {
    public override string Name => "**";
  }
}