namespace Shaykhullin.Practice2
{
  partial class Form1
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
      this.inputTextBox = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.integerResult = new System.Windows.Forms.Label();
      this.numeratorResult = new System.Windows.Forms.Label();
      this.denominatorResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // inputTextBox
      // 
      this.inputTextBox.Location = new System.Drawing.Point(12, 12);
      this.inputTextBox.Name = "inputTextBox";
      this.inputTextBox.Size = new System.Drawing.Size(260, 20);
      this.inputTextBox.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(104, 38);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Calculate";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.OnCalculateClicked);
      // 
      // integerResult
      // 
      this.integerResult.AutoSize = true;
      this.integerResult.Location = new System.Drawing.Point(101, 128);
      this.integerResult.Name = "integerResult";
      this.integerResult.Size = new System.Drawing.Size(0, 13);
      this.integerResult.TabIndex = 2;
      // 
      // numeratorResult
      // 
      this.numeratorResult.AutoSize = true;
      this.numeratorResult.Location = new System.Drawing.Point(135, 115);
      this.numeratorResult.Name = "numeratorResult";
      this.numeratorResult.Size = new System.Drawing.Size(0, 13);
      this.numeratorResult.TabIndex = 3;
      // 
      // denominatorResult
      // 
      this.denominatorResult.AutoSize = true;
      this.denominatorResult.Location = new System.Drawing.Point(135, 143);
      this.denominatorResult.Name = "denominatorResult";
      this.denominatorResult.Size = new System.Drawing.Size(0, 13);
      this.denominatorResult.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.denominatorResult);
      this.Controls.Add(this.numeratorResult);
      this.Controls.Add(this.integerResult);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.inputTextBox);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox inputTextBox;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label integerResult;
    private System.Windows.Forms.Label numeratorResult;
    private System.Windows.Forms.Label denominatorResult;
  }
}

