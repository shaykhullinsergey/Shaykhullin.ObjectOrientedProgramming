using System;
using System.Linq;
using System.Collections.Generic;

using Shaykhullin.Tokens;
using Shaykhullin.Parsers;

namespace Shaykhullin
{
	public class ExpressionLexingInterpreter : ILexingContext
	{
		private Queue<Token> tokens;
		public IEnumerable<TokenParser> parsers;

		public ExpressionLexingInterpreter(string expression)
		{
      tokens = new Queue<Token>();
			parsers = typeof(TokenParser).Assembly.GetTypes()
				.Where(type => typeof(TokenParser).IsAssignableFrom(type))
				.Where(type => !type.IsAbstract)
				.Select(type => (TokenParser)Activator.CreateInstance(type))
				.ToList();
      Expression = expression;
		}

    public string Expression { get; private set; }
		public int Start { get; private set; }
		public int Caret { get; set; }
		public char Current => Expression.ElementAtOrDefault(Caret);
    public string SubExpression => 
      Caret > Expression.Length ? null : Expression.Substring(Start, Caret - Start);

		public Queue<Token> Interpret()
		{
      do
      {
        Start = Caret;

        var parser = parsers.SingleOrDefault(p => p.IsSatisfied(this));

        if(parser == null)
        {
          throw new InvalidOperationException($"Error in {Caret} symbol");
        }

        var token = parser.Parse(this);

        if(token != null && !(token is EmptyToken))
        {
          tokens.Enqueue(token);
        }

      } while (Caret < Expression.Length);

      return tokens;
		}
  }
}
