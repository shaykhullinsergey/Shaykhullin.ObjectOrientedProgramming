using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Shaykhullin.Lab2.Views
{
  partial class AddView
  {
    private IContainer components = null;

    private void InitializeComponent()
    {
      button1 = new Button();
      textBox1 = new TextBox();
      label1 = new Label();
      SuspendLayout();
      
      // 
      // button1
      // 
      button1.Location = new Point(317, 11);
      button1.Name = "button1";
      button1.Size = new Size(75, 23);
      button1.TabIndex = 1;
      button1.Text = "OK";
      button1.UseVisualStyleBackColor = true;
      // 
      // textBox1
      // 
      textBox1.Location = new Point(12, 12);
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(299, 20);
      textBox1.TabIndex = 0;
      // 
      // label1
      // 
      label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
      label1.Location = new Point(8, 35);
      label1.Name = "label1";
      label1.Size = new Size(384, 23);
      label1.TabIndex = 9;
      label1.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // AddView
      // 
      AutoScaleDimensions = new SizeF(6F, 13F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(404, 67);
      Controls.Add(label1);
      Controls.Add(textBox1);
      Controls.Add(button1);
      Name = "AddView";
      Text = "AddView";
      ResumeLayout(false);
      PerformLayout();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }
    
    public Button button1;
    public TextBox textBox1;
    public Label label1;
  }
}