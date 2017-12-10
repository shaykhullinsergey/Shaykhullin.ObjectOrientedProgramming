using System;
using System.Linq;
using System.Collections.Generic;

using Shaykhullin.Lexemes;
using Shaykhullin.Parsers;

namespace Shaykhullin
{
	public class ExpressionLexingInterpreter : ILexingContext
	{
		private Queue<Lexeme> lexemes;
		public IEnumerable<LexemeParser> lexemeParsers;

		public ExpressionLexingInterpreter(string expression)
		{
      lexemes = new Queue<Lexeme>();
			lexemeParsers = typeof(LexemeParser).Assembly.GetTypes()
				.Where(type => typeof(LexemeParser).IsAssignableFrom(type))
				.Where(type => !type.IsAbstract)
				.Select(type => (LexemeParser)Activator.CreateInstance(type))
        .OrderByDescending(parser => parser.Name?.Length)
				.ToList();
      Expression = expression;
		}

    public string Expression { get; private set; }
		public int Start { get; private set; }
		public int Caret { get; set; }
		public char Current => Expression.ElementAtOrDefault(Caret);
    public string SubExpression => 
      Caret > Expression.Length ? null : Expression.Substring(Start, Caret - Start);

		public Queue<Lexeme> LexExpression()
		{
      do
      {
        Start = Caret;

        var parser = lexemeParsers.FirstOrDefault(p => p.IsSatisfied(this))
          ?? throw new InvalidOperationException($"Error in {Caret} symbol");

        var lexeme = parser.Parse(this);

        if(lexeme != null && !(lexeme is EmptyLexeme))
        {
          lexemes.Enqueue(lexeme);
        }

      } while (Caret < Expression.Length);

      return lexemes;
		}
  }
}
