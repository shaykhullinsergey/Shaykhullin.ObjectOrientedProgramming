using System;

namespace Shaykhullin.Tokens
{
  public abstract class Token
  {
    public abstract int Order { get; }
  }

  // value
  public abstract class ValueToken : Token
  {
    public override int Order => 2;
  }
  public class DoubleToken : ValueToken
  {
    public DoubleToken(string value) =>
      Value = double.Parse(value);
    public double Value { get; }
  }
  public class PiToken : DoubleToken
  {
    public PiToken() : base(Math.PI.ToString()) { }
  }
  public class ExpToken : DoubleToken
  {
    public ExpToken() : base(Math.E.ToString()) { }
  }
  public class BooleanToken : ValueToken
  {
    public BooleanToken()
    {
    }

    public BooleanToken(string value)
    {
      Value = bool.Parse(value);
    }

    public bool Value { get; }
  }

  // separator
  public class SeparatorToken : Token
  {
    public override int Order => 3;
  }
  public class EmptyToken : SeparatorToken { }
  public class CommaToken : SeparatorToken { }
  public class LeftBracketToken : SeparatorToken { }
  public class RightBracketToken : SeparatorToken { }

  //operation
  public class OperationToken : Token
  {
    public override int Order => 4;
  }
  public class PlusToken : OperationToken
  {
    public override int Order => 5;
  }
  public class MinusToken : OperationToken
  {
    public override int Order => 3;
  }
  public class UnaryPlusToken : OperationToken
  {
    public override int Order => 3;
  }
  public class UnaryMinusToken : OperationToken
  {
    public override int Order => 3;
  }
  public class MultiplyToken : OperationToken
  {
    public override int Order => 2;
  }
  public class DivideToken : OperationToken
  {
    public override int Order => 2;
  }
  public class ModulusToken : OperationToken
  {
    public override int Order => 2;
  }
  public class PowerToken : OperationToken
  {
    public override int Order => 3;
  }
  public class ComparisonOperationToken : OperationToken
  {
    public override int Order => 6;
  }
  public class EqualToken : ComparisonOperationToken
  {
  }
  public class GreaterToken : ComparisonOperationToken { }
  public class LessToken : ComparisonOperationToken { }
  public class GreaterOrEqualToken : ComparisonOperationToken { }
  public class LessOrEqualToken : ComparisonOperationToken { }
  public class NotEqualToken : ComparisonOperationToken { }
  public class AndToken : OperationToken { }
  public class OrToken : OperationToken { }
  public class XorToken : OperationToken { }
  public class NotToken : ComparisonOperationToken { }

  // function
  public class FunctionToken : Token
  {
    public override int Order => 4;
  }
  public class MinToken : FunctionToken { }
  public class MaxToken : FunctionToken { }
  public class RoundToken : FunctionToken { }
  public class TruncToken : FunctionToken { }
  public class FloorToken : FunctionToken { }
  public class CeilToken : FunctionToken { }
  public class SinToken : FunctionToken { }
  public class CosToken : FunctionToken { }
  public class TanToken : FunctionToken { }
  public class CotanToken : FunctionToken { }
  public class ArcsinToken : FunctionToken { }
  public class ArccosToken : FunctionToken { }
  public class ArctanToken : FunctionToken { }
  public class LnToken : FunctionToken { }
  public class AbsToken : FunctionToken { }
  public class SignToken : FunctionToken { }
  // DONE
}
