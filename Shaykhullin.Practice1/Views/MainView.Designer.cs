namespace Shaykhullin.Practice1.Views
{
  partial class MainView
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
      this.result = new System.Windows.Forms.Label();
      this.addResult = new System.Windows.Forms.Label();
      this.expressionResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // result
      // 
      this.result.AutoSize = true;
      this.result.Location = new System.Drawing.Point(207, 196);
      this.result.Name = "result";
      this.result.Size = new System.Drawing.Size(25, 13);
      this.result.TabIndex = 0;
      this.result.Text = "123";
      // 
      // addResult
      // 
      this.addResult.AutoSize = true;
      this.addResult.Location = new System.Drawing.Point(207, 225);
      this.addResult.Name = "addResult";
      this.addResult.Size = new System.Drawing.Size(25, 13);
      this.addResult.TabIndex = 1;
      this.addResult.Text = "123";
      // 
      // expressionResult
      // 
      this.expressionResult.AutoSize = true;
      this.expressionResult.Location = new System.Drawing.Point(207, 251);
      this.expressionResult.Name = "expressionResult";
      this.expressionResult.Size = new System.Drawing.Size(25, 13);
      this.expressionResult.TabIndex = 2;
      this.expressionResult.Text = "123";
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(484, 461);
      this.Controls.Add(this.expressionResult);
      this.Controls.Add(this.addResult);
      this.Controls.Add(this.result);
      this.Name = "MainView";
      this.Text = "MainView";
      this.Load += new System.EventHandler(this.OnLoad);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label result;
    private System.Windows.Forms.Label addResult;
    private System.Windows.Forms.Label expressionResult;
  }
}