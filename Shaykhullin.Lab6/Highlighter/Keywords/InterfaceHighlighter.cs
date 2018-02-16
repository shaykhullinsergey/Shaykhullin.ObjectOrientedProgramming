using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shaykhullin.Lab6
{
	public class InterfaceHighlighter : KeywordHighlighter
	{
		public override string Keyword => "interface";

		public override void Apply(RichTextBox editor)
		{
			base.Apply(editor);

			var count = editor.Text.Substring(editor.SelectionStart)
				.TakeWhile(x => x != ' ' && x != ':' && x != '\n' && x != '{' && x != '<')
				.Count();

			editor.SelectionLength = count;
			editor.SelectionColor = Color.FromArgb(245, 255, 158);
			editor.SelectionStart += count;
			editor.SelectionLength = 0;
		}
	}
}