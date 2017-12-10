using System;

namespace Shaykhullin.Lab4.Sandbox
{
  class Program
  {
    static void Main(string[] args)
    {
      var expression = "twelve";

      var result = new ExpressionInterpreter(
        processor: new ExpressionSyntaxTreeProcessor(
          formatter: new ExpressionSyntaxTreeFormatter(
            sortProcessor: new ExpressionInfixSortStationProcessor(
              lexingInterpreter: new ExpressionLexingInterpreter(expression)))))
                .Interpret();

      Console.WriteLine(result);
    }
  }
}
