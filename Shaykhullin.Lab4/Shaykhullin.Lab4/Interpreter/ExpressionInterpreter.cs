using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
      return processor.CalcTree();
    }
  }
}
