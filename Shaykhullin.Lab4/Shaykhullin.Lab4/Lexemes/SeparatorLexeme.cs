namespace Shaykhullin.Lexemes
{
  // separator
  public class SeparatorLexeme : Lexeme
  {
    public override int Order => 3;
  }

  public class EmptyLexeme : SeparatorLexeme { }
  public class CommaLexeme : SeparatorLexeme { }
  public class LeftParenthesisLexeme : SeparatorLexeme { }
  public class RightParenthesisLexeme : SeparatorLexeme { }
}
