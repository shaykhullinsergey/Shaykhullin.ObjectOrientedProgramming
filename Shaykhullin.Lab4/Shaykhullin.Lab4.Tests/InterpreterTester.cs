namespace Shaykhullin.Tests
{
  public class InterpreterTester
  {
    public TResult Interpret<TResult>(string expression)
    {
      return (TResult) new ExpressionInterpreter(
        processor: new ExpressionSyntaxTreeProcessor(
          formatter: new ExpressionSyntaxTreeFormatter(
            sortProcessor: new ExpressionInfixSortStationProcessor(
              lexingInterpreter: new ExpressionLexingInterpreter(expression)))))
      .Interpret();
    }
  }
}
