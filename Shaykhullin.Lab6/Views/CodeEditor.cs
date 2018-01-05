using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

using Shaykhullin.Lab6.Core;
using Shaykhullin.Lab6.ViewModels;

namespace Shaykhullin.Lab6
{
  public partial class CodeEditor : ModelView<CodeEditorViewModel>
  {
    [DllImport("user32.dll")]
    public static extern bool LockWindowUpdate(IntPtr hWndLock);
    public static TextBox OutputWindow { get; private set; }
    public static RichTextBox Editor { get; private set; }
    public static ToolStripProgressBar ProgressBar { get; private set; }

    private string prevText;
    
    public CodeEditor()
    {
      InitializeComponent();
      OutputWindow = outputWindow;
      Editor = editor;
      ProgressBar = toolStripProgressBar1;
      model = new CodeEditorViewModel();
      OnTextChanged(null, null);
    }

    private void OnKeyDown(object sender, KeyEventArgs args)
    {
      model.UpdateState(args);

      LockWindowUpdate(editor.Handle);
      model.TryExecuteCommand(editor, args);
      LockWindowUpdate(IntPtr.Zero);
    }

    private void OnTextChanged(object sender, EventArgs e)
    {
      if (prevText == editor.Text) return;
      prevText = editor.Text;
      OnOutputDisable(sender, e);

      int selection = editor.SelectionStart;
      LockWindowUpdate(editor.Handle);

      model.SetAllTextToRegularFont(editor);
      model.ResetSelectionToStart(editor);

      while (editor.SelectionStart < editor.Text.Length)
      {
        if(model.TryExecuteHighlighter(editor, editor.Text, editor.SelectionStart))
        {
          model.SetNextSelectionAndColor(editor);
        }
        else
        {
          var current = editor.Text[editor.SelectionStart];

          while (char.IsLetterOrDigit(current) && editor.Text.Length - 1 != editor.SelectionStart)
          {
            current = editor.Text[++editor.SelectionStart];
          }
          editor.SelectionStart++;
        }
      }

      editor.SelectionStart = selection;
      LockWindowUpdate(IntPtr.Zero);
    }

    private void OnOutputDisable(object sender, EventArgs e)
    {
      outputWindow.Visible = false;
    }
  }
}
