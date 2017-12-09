using System;
using System.Collections.Generic;
using System.Linq;
using Shaykhullin.Tokens;
using Shaykhullin.TokenSorters;

namespace Shaykhullin
{
  public class ExpressionInfixSortStationProcessor
  {
    private Queue<Token> input;
    private Queue<Token> output;
    private Stack<Token> stack;
    private IEnumerable<TokenSorter> tokenSorters;

    public ExpressionInfixSortStationProcessor(ExpressionLexingInterpreter lexingInterpreter)
    {
      input = lexingInterpreter.Interpret();
      output = new Queue<Token>();
      stack = new Stack<Token>();

      tokenSorters = typeof(TokenSorter).Assembly.GetTypes()
        .Where(type => typeof(TokenSorter).IsAssignableFrom(type))
        .Where(type => !type.IsAbstract)
        .Select(type => (TokenSorter)Activator.CreateInstance(type))
        .ToList();
    }

    public Queue<Token> SortStation()
    {
      Token prevToken = null;

      while (input.Count > 0)
      {
        Token token = input.Dequeue();

        var sorter = tokenSorters.SingleOrDefault(s => s.IsSatisfied(token))
          ?? throw new InvalidOperationException("Sorter not found");
        
        sorter.Sort(token, prevToken, input, output, stack);

        prevToken = token;
      }

      while (stack.Count > 0)
      {
        if (stack.Peek() is LeftBracketToken)
          throw new InvalidOperationException("RIGHT BRACKET");

        output.Enqueue(stack.Pop());
      }

      return output;
    }
  }
}
