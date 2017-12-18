using System;

namespace Shaykhullin.Lexemes
{
  public class DoubleLexeme : ValueLexeme<double>
  {
    public DoubleLexeme(string value) : base(double.Parse(value))
    {
    }
  }
  public class PiLexeme : DoubleLexeme
  {
    public PiLexeme() : base(Math.PI.ToString()) { }
  }
  public class ExpLexeme : DoubleLexeme
  {
    public ExpLexeme() : base(Math.E.ToString()) { }
  }
}
