using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shaykhullin.Lab6
{
	public class ClassHighlighter : KeywordHighlighter
	{
		public override string Keyword => "class ";

		public override void Apply(RichTextBox editor)
		{
			base.Apply(editor);

			var count = editor.Text.Substring(editor.SelectionStart)
				.TakeWhile(x => x != ' ' && x != ':' && x != '\n' && x != '{' && x != '<')
				.Count();

			editor.SelectionLength = count;
			editor.SelectionColor = Color.MediumAquamarine;
			editor.SelectionStart += count;
			editor.SelectionLength = 0;
		}
	}
}