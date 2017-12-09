using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class OrTokenParser : TokenParser<OrToken>
  {
    public override string Name => "|";
  }
}