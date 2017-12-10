namespace Shaykhullin.Lexemes
{
  // value
  public abstract class ValueLexeme : Lexeme
  {
    public object Value { get; }
    public override int Order => 2;

    protected ValueLexeme(object value)
    {
      Value = value;
    }
  }

  public abstract class ValueLexeme<TValue> : ValueLexeme
  {
    public new TValue Value => (TValue)base.Value;

    protected ValueLexeme(TValue value) : base(value)
    {
    }
  }
}
