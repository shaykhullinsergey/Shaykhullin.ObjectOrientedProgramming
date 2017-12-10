namespace Shaykhullin.Lexemes
{
  public class BooleanLexeme : ValueLexeme<bool>
  {
    public BooleanLexeme() : base(false)
    {
    }

    public BooleanLexeme(string value) : base(bool.Parse(value))
    {
    }
  }
  // DONE
}
