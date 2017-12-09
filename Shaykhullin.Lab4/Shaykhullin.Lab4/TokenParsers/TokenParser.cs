using Shaykhullin.Tokens;

namespace Shaykhullin.Parsers
{
  public abstract class TokenParser
  {
    public virtual string Name { get; }
    public abstract Token Parse(ILexingContext context);
    public abstract bool IsSatisfied(ILexingContext context);
  }

  public abstract class TokenParser<TToken> : TokenParser
    where TToken : Token, new()
  {
    public override Token Parse(ILexingContext context)
    {
      context.Caret += Name.Length;
      return new TToken();
    }
    public override bool IsSatisfied(ILexingContext context)
    {
      if(context.Start + Name.Length > context.Expression.Length)
      {
        return false;
      }

      for (int index = context.Start; index < context.Start + Name.Length; index++)
      {
        if (char.ToLower(context.Expression[index]) != char.ToLower(Name[index - context.Start]))
        {
          return false;
        }
      }
      return true;
    }
  }
}