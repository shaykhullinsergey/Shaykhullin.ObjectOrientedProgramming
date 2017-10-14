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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.treeStatus = new System.Windows.Forms.Label();
      this.button5 = new System.Windows.Forms.Button();
      this.rightTree = new System.Windows.Forms.TreeView();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.leftTree = new System.Windows.Forms.TreeView();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.binaryTreeStatus = new System.Windows.Forms.Label();
      this.button9 = new System.Windows.Forms.Button();
      this.button10 = new System.Windows.Forms.Button();
      this.binaryTreeView = new System.Windows.Forms.TreeView();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(636, 654);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.treeStatus);
      this.tabPage1.Controls.Add(this.button5);
      this.tabPage1.Controls.Add(this.rightTree);
      this.tabPage1.Controls.Add(this.button4);
      this.tabPage1.Controls.Add(this.button3);
      this.tabPage1.Controls.Add(this.button2);
      this.tabPage1.Controls.Add(this.button1);
      this.tabPage1.Controls.Add(this.leftTree);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(628, 628);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Tree";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // treeStatus
      // 
      this.treeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.treeStatus.Location = new System.Drawing.Point(6, 572);
      this.treeStatus.Name = "treeStatus";
      this.treeStatus.Size = new System.Drawing.Size(616, 23);
      this.treeStatus.TabIndex = 8;
      this.treeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(512, 602);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(110, 23);
      this.button5.TabIndex = 7;
      this.button5.Text = "LocalState";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.OnLocalStateClicked);
      // 
      // rightTree
      // 
      this.rightTree.Location = new System.Drawing.Point(331, 5);
      this.rightTree.Name = "rightTree";
      this.rightTree.Size = new System.Drawing.Size(291, 564);
      this.rightTree.TabIndex = 6;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(396, 602);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(110, 23);
      this.button4.TabIndex = 5;
      this.button4.Text = "Move";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.OnMoveClicked);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(238, 602);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(152, 23);
      this.button3.TabIndex = 4;
      this.button3.Text = "RemoveAndMoveChildren";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.OnRemoveAndMoveChildrenClicked);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(122, 602);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(110, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Remove";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.OnRemoveClicked);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(6, 602);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Add";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.OnAddClicked);
      // 
      // leftTree
      // 
      this.leftTree.Location = new System.Drawing.Point(6, 6);
      this.leftTree.Name = "leftTree";
      this.leftTree.Size = new System.Drawing.Size(291, 563);
      this.leftTree.TabIndex = 0;
      this.leftTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnNodeSelected);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.binaryTreeStatus);
      this.tabPage2.Controls.Add(this.button9);
      this.tabPage2.Controls.Add(this.button10);
      this.tabPage2.Controls.Add(this.binaryTreeView);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(628, 628);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "BinaryTree";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // binaryTreeStatus
      // 
      this.binaryTreeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.binaryTreeStatus.Location = new System.Drawing.Point(6, 571);
      this.binaryTreeStatus.Name = "binaryTreeStatus";
      this.binaryTreeStatus.Size = new System.Drawing.Size(616, 23);
      this.binaryTreeStatus.TabIndex = 16;
      this.binaryTreeStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(308, 601);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(110, 23);
      this.button9.TabIndex = 11;
      this.button9.Text = "Remove";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.OnBinaryRemoveClicked);
      // 
      // button10
      // 
      this.button10.Location = new System.Drawing.Point(192, 601);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(110, 23);
      this.button10.TabIndex = 10;
      this.button10.Text = "Add";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new System.EventHandler(this.OnBinaryAddClicked);
      // 
      // binaryTreeView
      // 
      this.binaryTreeView.Location = new System.Drawing.Point(6, 5);
      this.binaryTreeView.Name = "binaryTreeView";
      this.binaryTreeView.Size = new System.Drawing.Size(616, 563);
      this.binaryTreeView.TabIndex = 9;
      this.binaryTreeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnBinaryNodeSelected);
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(660, 678);
      this.Controls.Add(this.tabControl1);
      this.Name = "MainView";
      this.Text = "MainView";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TreeView leftTree;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TreeView rightTree;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Label treeStatus;
    private System.Windows.Forms.Label binaryTreeStatus;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.TreeView binaryTreeView;
  }
}