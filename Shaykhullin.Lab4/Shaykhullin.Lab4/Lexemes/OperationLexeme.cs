namespace Shaykhullin.Lexemes
{
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
  public class AndLexeme : OperationLexeme { }
  public class OrLexeme : OperationLexeme { }
  public class XorLexeme : OperationLexeme { }
}
