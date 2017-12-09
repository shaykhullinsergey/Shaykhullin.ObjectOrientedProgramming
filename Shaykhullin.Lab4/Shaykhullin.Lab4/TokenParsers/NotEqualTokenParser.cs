using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class NotEqualTokenParser : TokenParser<NotEqualToken>
  {
    public override string Name => "!=";
  }
}