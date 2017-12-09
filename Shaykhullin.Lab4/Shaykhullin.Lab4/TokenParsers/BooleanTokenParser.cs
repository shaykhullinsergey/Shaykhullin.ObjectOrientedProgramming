using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public abstract class BooleanTokenParser : TokenParser<BooleanToken>
  {
    public override Token Parse(ILexingContext context)
    {
      base.Parse(context);
      return new BooleanToken(Name);
    }
  }
}