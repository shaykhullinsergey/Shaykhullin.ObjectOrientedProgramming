using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public class MultiplyTokenParser : TokenParser<MultiplyToken>
  {
    public override string Name => "*";

    public override bool IsSatisfied(ILexingContext context) =>
      base.IsSatisfied(context) && context.Expression[context.Caret + 1] != '*';
  }
}