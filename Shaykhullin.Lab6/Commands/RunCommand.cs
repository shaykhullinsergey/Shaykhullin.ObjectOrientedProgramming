using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.CodeAnalysis;
using Shaykhullin.RoslynWrapper;

namespace Shaykhullin.Lab6.Commands
{
  public class RunCommand : Command
  {
    public override Keys Key => Keys.F5;
    public override bool RequireControl => true;

    public override void Apply(RichTextBox code)
    {
      CodeEditor.OutputWindow.Text = "";
      CodeEditor.OutputWindow.Focus();
      CodeEditor.OutputWindow.Visible = true;
      RunProgressBar();

      var start = code.GetLineFromCharIndex(code.SelectionStart);
      var end = code.GetLineFromCharIndex(code.SelectionStart + code.SelectionLength);

      var executionCode = code.SelectionLength == 0
        ? code.Lines
        : code.Lines.Skip(start).Take(end - start + 1).ToArray();

      var assembly = new AssemblyComposer(
        new CSharpSyntaxTreeCompiler(
          syntaxTreeAnalyzer: new CSharpSyntaxTreeAnalyzer(GenerateTemplate(executionCode)),
          referencedAssemblies: new[]
          {
            typeof(System.Object).Assembly,
            typeof(System.Collections.Generic.IEnumerable<>).Assembly,
            typeof(System.ComponentModel.ArrayConverter).Assembly,
            typeof(System.Data.Constraint).Assembly,
            typeof(System.Drawing.Bitmap).Assembly,
            typeof(System.Linq.Enumerable).Assembly,
            typeof(System.Text.StringBuilder).Assembly,
            typeof(System.Threading.Tasks.Task).Assembly,
            typeof(System.Windows.Forms.Form).Assembly
          },
          optimizationLevel: OptimizationLevel.Debug))
        .ComposeAssembly();

      if(assembly.Success)
      {
        EvaluateMethod(assembly.Assembly);
      }
      else
      {
        EvaluateErrors(assembly.Errors);
      }
    }

    private void EvaluateMethod(Assembly assembly)
    {
      CodeEditor.OutputWindow.AppendText("Build success\n");

      var type = assembly.GetType("GeneratedNamespace.GeneratedClass");
      var method = type.GetMethod("GeneratedMethod", BindingFlags.Public | BindingFlags.Static);

      try
      {
        method.Invoke(null,
        new object[]
        {
          (Action<object>)(obj => CodeEditor.OutputWindow.AppendText(obj.ToString() + "\n")),
        });
      }
      catch (Exception e)
      {
        CodeEditor.OutputWindow.AppendText("Exception: " + e.InnerException.Message + "\n");
      }
    }

    private void EvaluateErrors(IEnumerable<Diagnostic> errors)
    {
      CodeEditor.OutputWindow.AppendText("Build failed\n");

      foreach (var error in errors)
      {
        var editor = CodeEditor.Editor;
        var selected = editor.SelectionStart;

        var normalizedStart = 0; //error.Location.SourceSpan.Start;

        editor.Select(normalizedStart, error.Location.SourceSpan.Length + 1);
        editor.SelectionFont = new Font(editor.SelectionFont, FontStyle.Underline);

        editor.Select(normalizedStart, error.Location.SourceSpan.Length + 1);
        editor.SelectionColor = Color.Red;

        editor.SelectionStart = selected;
        editor.SelectionFont = new Font(editor.SelectionFont, FontStyle.Regular);

        CodeEditor.OutputWindow.AppendText(error.ToString() + "\n");
      }
    }

    private string GenerateTemplate(string[] codeLines)
    {
      var template = File.ReadAllText(
        Path.Combine(Environment.CurrentDirectory, "template.cs"));

      var types = DetectTypes().ToList();
      var methods = codeLines.Except(types);

      template = template.Replace("/*METHODS*/", string.Join("\n", methods));
      template = template.Replace("/*TYPES*/", string.Join("\n", types));

      return template;

      IEnumerable<string> DetectTypes()
      {
        bool typeFound = false;
        int paranthesis = 0;

        for (int i = 0; i < codeLines.Length; i++)
        {
          var line = codeLines[i];

          if(line.Contains("delegate") 
            && !line.Contains("{")
            && i + 1 < codeLines.Length
            && !codeLines[i + 1].Contains("{"))
          {
            yield return line;
          }

          if (HasType(line))
          {
            typeFound = true;
          }

          if(typeFound)
          {
            var lineDifference = line.Where(x => x == '{').Count() 
              - line.Where(x => x == '}').Count();

            paranthesis += lineDifference;

            yield return line;

            if (!(HasType(line)) && paranthesis == 0)
            {
              typeFound = false;
            }
          }
        }

        bool HasType(string line) => 
          line.Contains("class")
            || line.Contains("interface")
            || line.Contains("enum")
            || line.Contains("struct");
      }
    }

    private void RunProgressBar()
    {
      Task.Run(() =>
      {
        for (int i = 0; i < 10; i++)
        {
          CodeEditor.ProgressBar.PerformStep();
          Thread.Sleep(50);
        }

        CodeEditor.ProgressBar.Value = 0;
      });
    }
  }
}
