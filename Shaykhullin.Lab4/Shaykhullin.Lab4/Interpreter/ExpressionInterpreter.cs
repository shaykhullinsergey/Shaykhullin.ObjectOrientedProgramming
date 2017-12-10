namespace Shaykhullin
{
  public class ExpressionInterpreter
  {
    private readonly ExpressionSyntaxTreeProcessor processor;

    public ExpressionInterpreter(ExpressionSyntaxTreeProcessor processor)
    {
      this.processor = processor;
    }

    public object Interpret()
    {
      return processor.ExecuteOperaion();
    }
  }
}
