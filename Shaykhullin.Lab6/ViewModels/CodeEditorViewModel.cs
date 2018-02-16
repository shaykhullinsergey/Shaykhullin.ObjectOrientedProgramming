using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Shaykhullin.Lab6.Commands;

namespace Shaykhullin.Lab6.ViewModels
{
	public class CodeEditorViewModel
	{
		private readonly IList<Command> commands;
		private readonly IList<Highlighter> highlighters;
		private readonly KeyState state;

		public CodeEditorViewModel()
		{
			commands = typeof(Command).Assembly.GetTypes()
				.Where(type => !type.IsAbstract)
				.Where(type => typeof(Command).IsAssignableFrom(type))
				.Select(type => (Command)Activator.CreateInstance(type))
				.ToList();

			highlighters = typeof(Highlighter).Assembly.GetTypes()
				.Where(type => !type.IsAbstract)
				.Where(type => typeof(Highlighter).IsAssignableFrom(type))
				.Select(type => (Highlighter)Activator.CreateInstance(type))
				.OrderByDescending(h => h.Keyword.Length)
				.ToList();

			state = new KeyState();
		}

		public void UpdateState(KeyEventArgs args)
		{
			state.Update(args);
		}

		public void TryExecuteCommand(RichTextBox editor, KeyEventArgs args)
		{
			for (var i = 0; i < commands.Count; i++)
			{
				if (commands[i].IsSatisfied(args.KeyCode, state))
				{
					commands[i].Apply(editor);
					return;
				}
			}
		}

		public bool TryExecuteHighlighter(RichTextBox editor, string keyword, int index)
		{
			for (var i = 0; i < highlighters.Count; i++)
			{
				if (highlighters[i].IsSatisfied(keyword, index))
				{
					highlighters[i].Apply(editor);
					return true;
				}
			}

			return false;
		}

		public void ResetSelectionToStart(RichTextBox editor)
		{
			editor.SelectionStart = editor.SelectionLength = 0;
		}

		public void SetNextSelectionAndColor(RichTextBox editor)
		{
			editor.SelectionLength = 1;
			editor.SelectionColor = Color.WhiteSmoke;
			editor.SelectionStart++;
			editor.SelectionLength = 0;
		}

		public void SetAllTextToRegularFont(RichTextBox editor)
		{
			editor.SelectAll();
			editor.SelectionFont = new Font(editor.SelectionFont, FontStyle.Regular);
		}

		public void SetSelectedUnderscoreFont(RichTextBox editor)
		{
		}
	}
}