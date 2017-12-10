using System;
using System.Linq;
using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Parsers;

namespace Shaykhullin
{
	public class ExpressionLexingInterpreter : ILexingContext
	{
		private Queue<Lexeme> Lexemes;
		public IEnumerable<LexemeParser> parsers;

		public ExpressionLexingInterpreter(string expression)
		{
      Lexemes = new Queue<Lexeme>();
			parsers = typeof(LexemeParser).Assembly.GetTypes()
				.Where(type => typeof(LexemeParser).IsAssignableFrom(type))
				.Where(type => !type.IsAbstract)
				.Select(type => (LexemeParser)Activator.CreateInstance(type))
				.ToList();
      Expression = expression;
		}

    public string Expression { get; private set; }
		public int Start { get; private set; }
		public int Caret { get; set; }
		public char Current => Expression.ElementAtOrDefault(Caret);
    public string SubExpression => 
      Caret > Expression.Length ? null : Expression.Substring(Start, Caret - Start);

		public Queue<Lexeme> Interpret()
		{
      do
      {
        Start = Caret;

        var parser = parsers.SingleOrDefault(p => p.IsSatisfied(this));

        if(parser == null)
        {
          throw new InvalidOperationException($"Error in {Caret} symbol");
        }

        var Lexeme = parser.Parse(this);

        if(Lexeme != null && !(Lexeme is EmptyLexeme))
        {
          Lexemes.Enqueue(Lexeme);
        }

      } while (Caret < Expression.Length);

      return Lexemes;
		}
  }
}
