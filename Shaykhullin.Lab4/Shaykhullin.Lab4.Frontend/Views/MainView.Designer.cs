namespace Shaykhullin.Lab4.Frontend.Views
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
      this.input = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // result
      // 
      this.result.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.result.Font = new System.Drawing.Font("Microsoft YaHei Light", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.result.Location = new System.Drawing.Point(12, 116);
      this.result.Name = "result";
      this.result.Size = new System.Drawing.Size(1732, 153);
      this.result.TabIndex = 1;
      this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // input
      // 
      this.input.BackColor = System.Drawing.SystemColors.ControlLight;
      this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.input.Font = new System.Drawing.Font("Microsoft YaHei Light", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
      this.input.Location = new System.Drawing.Point(12, 12);
      this.input.Name = "input";
      this.input.Size = new System.Drawing.Size(1732, 101);
      this.input.TabIndex = 3;
      this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(1756, 267);
      this.Controls.Add(this.input);
      this.Controls.Add(this.result);
      this.Name = "MainView";
      this.Text = "Шайхуллин Сергей Исбо-11-16";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label result;
    private System.Windows.Forms.TextBox input;
  }
}