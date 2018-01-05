using Shaykhullin.Lab6.Commands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shaykhullin.Lab6.ViewModels
{
  public class CodeEditorViewModel
  {
    private KeyState state;
    private IEnumerable<Command> commands;
    private IEnumerable<Highlighter> highlighters;

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

    public void UpdateState(KeyEventArgs args) => state.Update(args);

    public void TryExecuteCommand(RichTextBox editor, KeyEventArgs args) => commands
      .FirstOrDefault(c => c.IsSatisfied(args.KeyCode, state))
      ?.Apply(editor);

    public bool TryExecuteHighlighter(RichTextBox editor, string keyword, int index)
    {
      var highlighter = highlighters.FirstOrDefault(h => h.IsSatisfied(keyword, index));
      highlighter?.Apply(editor);

      return highlighter != null;
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
