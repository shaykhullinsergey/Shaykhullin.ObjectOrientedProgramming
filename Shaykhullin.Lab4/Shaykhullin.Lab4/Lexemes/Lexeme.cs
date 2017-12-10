using System;

namespace Shaykhullin.Lexemes
{
  public abstract class Lexeme
  {
    public abstract int Order { get; }
  }

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
  public class AndLexeme : OperationLexeme { }
  public class OrLexeme : OperationLexeme { }
  public class XorLexeme : OperationLexeme { }
  public class NotLexeme : ComparisonOperationLexeme { }

  // function
  public class FunctionLexeme : Lexeme
  {
    public override int Order => 4;
  }
  public class MinLexeme : FunctionLexeme { }
  public class MaxLexeme : FunctionLexeme { }
  public class RoundLexeme : FunctionLexeme { }
  public class TruncLexeme : FunctionLexeme { }
  public class FloorLexeme : FunctionLexeme { }
  public class CeilLexeme : FunctionLexeme { }
  public class SinLexeme : FunctionLexeme { }
  public class CosLexeme : FunctionLexeme { }
  public class TanLexeme : FunctionLexeme { }
  public class CotanLexeme : FunctionLexeme { }
  public class ArcsinLexeme : FunctionLexeme { }
  public class ArccosLexeme : FunctionLexeme { }
  public class ArctanLexeme : FunctionLexeme { }
  public class LnLexeme : FunctionLexeme { }
  public class AbsLexeme : FunctionLexeme { }
  public class SignLexeme : FunctionLexeme { }
  // DONE
}
