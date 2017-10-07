namespace Shaykhullin.Lab2.Views
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
      this.treeView = new System.Windows.Forms.TreeView();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // treeView
      // 
      this.treeView.Indent = 5;
      this.treeView.Location = new System.Drawing.Point(12, 12);
      this.treeView.Name = "treeView";
      this.treeView.Size = new System.Drawing.Size(489, 654);
      this.treeView.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(507, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(141, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Add";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(507, 41);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(141, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "AddToChildren";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(507, 70);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(141, 23);
      this.button3.TabIndex = 3;
      this.button3.Text = "Remove";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(507, 247);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(141, 23);
      this.button4.TabIndex = 4;
      this.button4.Text = "Render";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(507, 99);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(141, 23);
      this.button5.TabIndex = 5;
      this.button5.Text = "RemoveFromChildren";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(507, 218);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(141, 23);
      this.button6.TabIndex = 6;
      this.button6.Text = "MoveRoot";
      this.button6.UseVisualStyleBackColor = true;
      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(507, 128);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(141, 39);
      this.button7.TabIndex = 7;
      this.button7.Text = "RemoveAndMoveChildrenToParent";
      this.button7.UseVisualStyleBackColor = true;
      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(507, 173);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(141, 39);
      this.button8.TabIndex = 8;
      this.button8.Text = "RemoveFromChildrenAndMoveChildrenToParent";
      this.button8.UseVisualStyleBackColor = true;
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(660, 678);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.treeView);
      this.Name = "MainView";
      this.Text = "MainView";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TreeView treeView;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
  }
}