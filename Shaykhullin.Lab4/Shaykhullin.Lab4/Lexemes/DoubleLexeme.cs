using System;

namespace Shaykhullin.Lexemes
{
  public class DoubleLexeme : ValueLexeme<double>
  {
    public DoubleLexeme(string value) : base(double.Parse(value))
    {
    }
  }
  public class TwelveLexeme : DoubleLexeme
  {
    public TwelveLexeme() : base("12")
    {
    }
  }
  public class ElevenLexeme : DoubleLexeme
  {
    public ElevenLexeme() : base("11")
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
