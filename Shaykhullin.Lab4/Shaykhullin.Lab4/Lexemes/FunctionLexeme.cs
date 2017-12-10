namespace Shaykhullin.Lexemes
{
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
}
