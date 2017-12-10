using System;
using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Operations;
using OperationTree = Shaykhullin.Tree<Shaykhullin.Operations.Operation>;
using Shaykhullin.OperationMappers;
using System.Linq;

namespace Shaykhullin
{
  public class Tree<TData>
  {
    public TData Operation { get; set; }
    public Tree<TData> Left { get; set; }
    public Tree<TData> Right { get; set; }
  }

  public class ExpressionSyntaxTreeFormatter
  {
    private Queue<Lexeme> input;
    private Stack<Tree<Operation>> operations;
    private IEnumerable<LexemeOperationMapper> operationMappers;

    public ExpressionSyntaxTreeFormatter(ExpressionInfixSortStationProcessor sortProcessor)
    {
      input = sortProcessor.ToPostfixNotaition();

      operations = new Stack<Tree<Operation>>();
      operationMappers = typeof(LexemeOperationMapper).Assembly.GetTypes()
        .Where(type => typeof(LexemeOperationMapper).IsAssignableFrom(type))
        .Where(type => !type.IsAbstract)
        .Select(type => (LexemeOperationMapper)Activator.CreateInstance(type))
        .ToList();
    }

    public Tree<Operation> FormatOperation()
    {
      while (input.Count > 0)
      {
        var lexeme = input.Dequeue();

        var mapper = operationMappers.SingleOrDefault(s => s.IsSatisfied(lexeme))
          ?? throw new InvalidOperationException("Mapper not found");

        operations.Push(mapper.Map(operations));
      }

      if(operations.Count == 1)
      {
        return operations.Pop();
      }
      else if(operations.Count == 0)
      {
        throw new InvalidOperationException("Empty expression");
      }
      else
      {
        throw new InvalidOperationException("Syntax error");
      }
    }
  }
}
