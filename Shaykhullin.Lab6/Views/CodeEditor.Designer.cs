﻿namespace Shaykhullin.Lab6
{
  partial class CodeEditor
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditor));
      this.editor = new System.Windows.Forms.RichTextBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
      this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
      this.outputWindow = new System.Windows.Forms.TextBox();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // editor
      // 
      this.editor.AcceptsTab = true;
      this.editor.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
      this.editor.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.editor.Font = new System.Drawing.Font("DejaVu Sans Mono", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.editor.ForeColor = System.Drawing.SystemColors.MenuBar;
      this.editor.ImeMode = System.Windows.Forms.ImeMode.On;
      this.editor.Location = new System.Drawing.Point(1, -2);
      this.editor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
      this.editor.MaximumSize = new System.Drawing.Size(2333, 2000);
      this.editor.MinimumSize = new System.Drawing.Size(583, 500);
      this.editor.Name = "editor";
      this.editor.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.editor.ShowSelectionMargin = true;
      this.editor.Size = new System.Drawing.Size(1790, 993);
      this.editor.TabIndex = 0;
      this.editor.TabStop = false;
      this.editor.Text = "int a = 10;\nint b = 10;\n\nWriteLine(a + b);";
      this.editor.Click += new System.EventHandler(this.OnOutputDisable);
      this.editor.TextChanged += new System.EventHandler(this.OnTextChanged);
      this.editor.Enter += new System.EventHandler(this.OnOutputDisable);
      this.editor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
      // 
      // statusStrip1
      // 
      this.statusStrip1.AllowMerge = false;
      this.statusStrip1.AutoSize = false;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripProgressBar1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 991);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(16, 0, 1, 0);
      this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.statusStrip1.Size = new System.Drawing.Size(1790, 22);
      this.statusStrip1.SizingGrip = false;
      this.statusStrip1.Stretch = false;
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripDropDownButton2
      // 
      this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
      this.toolStripDropDownButton2.Size = new System.Drawing.Size(13, 20);
      this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
      // 
      // toolStripProgressBar1
      // 
      this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.toolStripProgressBar1.Margin = new System.Windows.Forms.Padding(1400, 3, 1, 3);
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new System.Drawing.Size(117, 16);
      // 
      // outputWindow
      // 
      this.outputWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.outputWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.outputWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.outputWindow.Font = new System.Drawing.Font("DejaVu Sans Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.outputWindow.ForeColor = System.Drawing.SystemColors.Window;
      this.outputWindow.Location = new System.Drawing.Point(0, 776);
      this.outputWindow.Multiline = true;
      this.outputWindow.Name = "outputWindow";
      this.outputWindow.ReadOnly = true;
      this.outputWindow.ShortcutsEnabled = false;
      this.outputWindow.Size = new System.Drawing.Size(1790, 212);
      this.outputWindow.TabIndex = 3;
      this.outputWindow.TabStop = false;
      this.outputWindow.Visible = false;
      this.outputWindow.Leave += new System.EventHandler(this.OnOutputDisable);
      // 
      // CodeEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
      this.ClientSize = new System.Drawing.Size(1790, 1013);
      this.Controls.Add(this.outputWindow);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.editor);
      this.DoubleBuffered = true;
      this.Font = new System.Drawing.Font("DejaVu Sans Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "CodeEditor";
      this.Text = "Shaykhullin";
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox editor;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
    private System.Windows.Forms.TextBox outputWindow;
    private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
  }
}