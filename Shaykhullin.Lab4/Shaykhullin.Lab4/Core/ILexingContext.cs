namespace Shaykhullin.Parsers
{
  public interface ILexingContext
	{
    int Start { get; }
		int Caret { get; set; }
    char Current { get; }
    string Expression { get; }
		string SubExpression { get; }
	}
}
