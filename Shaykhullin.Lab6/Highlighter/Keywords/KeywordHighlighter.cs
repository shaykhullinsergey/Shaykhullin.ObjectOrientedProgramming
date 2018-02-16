using System.Drawing;

namespace Shaykhullin.Lab6
{
	public abstract class KeywordHighlighter : Highlighter
	{
		public sealed override Color Color { get; } = Color.FromArgb(59, 131, 247);
	}
}