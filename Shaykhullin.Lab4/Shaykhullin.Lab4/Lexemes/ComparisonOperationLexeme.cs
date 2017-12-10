namespace Shaykhullin.Lexemes
{
  public class ComparisonOperationLexeme : OperationLexeme
  {
    public override int Order => 6;
  }
  public class EqualLexeme : ComparisonOperationLexeme
  {
  }
  public class GreaterLexeme : ComparisonOperationLexeme { }
  public class LessLexeme : ComparisonOperationLexeme { }
  public class GreaterOrEqualLexeme : ComparisonOperationLexeme { }
  public class LessOrEqualLexeme : ComparisonOperationLexeme { }
  public class NotEqualLexeme : ComparisonOperationLexeme { }
  public class NotLexeme : ComparisonOperationLexeme { }
}
