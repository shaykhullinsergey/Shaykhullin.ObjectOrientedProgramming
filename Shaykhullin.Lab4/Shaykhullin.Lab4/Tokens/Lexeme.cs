using System;

namespace Shaykhullin.Lexemes
{
  public abstract class Lexeme
  {
    public abstract int Order { get; }
  }

  // value
  public abstract class ValueLexeme : Lexeme
  {
    public override int Order => 2;
  }
  public class DoubleLexeme : ValueLexeme
  {
    public DoubleLexeme(string value) =>
      Value = double.Parse(value);
    public double Value { get; }
  }
  public class PiLexeme : DoubleLexeme
  {
    public PiLexeme() : base(Math.PI.ToString()) { }
  }
  public class ExpLexeme : DoubleLexeme
  {
    public ExpLexeme() : base(Math.E.ToString()) { }
  }
  public class BooleanLexeme : ValueLexeme
  {
    public BooleanLexeme()
    {
    }

    public BooleanLexeme(string value)
    {
      Value = bool.Parse(value);
    }

    public bool Value { get; }
  }

  // separator
  public class SeparatorLexeme : Lexeme
  {
    public override int Order => 3;
  }
  public class EmptyLexeme : SeparatorLexeme { }
  public class CommaLexeme : SeparatorLexeme { }
  public class LeftParenthesisLexeme : SeparatorLexeme { }
  public class RightParenthesisLexeme : SeparatorLexeme { }

  //operation
  public class OperationLexeme : Lexeme
  {
    public override int Order => 4;
  }
  public class PlusLexeme : OperationLexeme
  {
    public override int Order => 5;
  }
  public class MinusLexeme : OperationLexeme
  {
    public override int Order => 3;
  }
  public class UnaryPlusLexeme : OperationLexeme
  {
    public override int Order => 3;
  }
  public class UnaryMinusLexeme : OperationLexeme
  {
    public override int Order => 3;
  }
  public class MultiplyLexeme : OperationLexeme
  {
    public override int Order => 2;
  }
  public class DivideLexeme : OperationLexeme
  {
    public override int Order => 2;
  }
  public class ModulusLexeme : OperationLexeme
  {
    public override int Order => 2;
  }
  public class PowerLexeme : OperationLexeme
  {
    public override int Order => 3;
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
