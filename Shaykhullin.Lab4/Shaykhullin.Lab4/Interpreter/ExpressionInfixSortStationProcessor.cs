﻿using System;
using System.Collections.Generic;
using System.Linq;

using Shaykhullin.Lexemes;
using Shaykhullin.LexemeSorters;

namespace Shaykhullin
{
  public class ExpressionInfixSortStationProcessor
  {
    private Queue<Lexeme> input;
    private Queue<Lexeme> output;
    private Stack<Lexeme> stack;
    private IEnumerable<LexemeSorter> lexemeSorters;

    public ExpressionInfixSortStationProcessor(ExpressionLexingInterpreter lexingInterpreter)
    {
      input = lexingInterpreter.LexExpression();
      output = new Queue<Lexeme>();
      stack = new Stack<Lexeme>();

      lexemeSorters = typeof(LexemeSorter).Assembly.GetTypes()
        .Where(type => typeof(LexemeSorter).IsAssignableFrom(type))
        .Where(type => !type.IsAbstract)
        .Select(type => (LexemeSorter)Activator.CreateInstance(type))
        .ToList();
    }

    public Queue<Lexeme> ToPostfixNotaition()
    {
      Lexeme prevLexeme = null;

      while (input.Count > 0)
      {
        Lexeme Lexeme = input.Dequeue();

        var sorter = lexemeSorters.SingleOrDefault(s => s.IsSatisfied(Lexeme))
          ?? throw new InvalidOperationException("Sorter not found");
        
        sorter.Sort(Lexeme, prevLexeme, input, output, stack);

        prevLexeme = Lexeme;
      }

      while (stack.Count > 0)
      {
        if (stack.Peek() is LeftParenthesisLexeme)
          throw new InvalidOperationException("RIGHT Parenthesis");

        output.Enqueue(stack.Pop());
      }

      return output;
    }
  }
}
