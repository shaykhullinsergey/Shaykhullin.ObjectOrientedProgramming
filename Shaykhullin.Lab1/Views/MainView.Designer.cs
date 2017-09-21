namespace Shaykhullin.Lab1.Views
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
      this.image = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.shiftX = new System.Windows.Forms.TrackBar();
      this.shiftY = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.trackBar3 = new System.Windows.Forms.TrackBar();
      this.label4 = new System.Windows.Forms.Label();
      this.trackBar4 = new System.Windows.Forms.TrackBar();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.shiftX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.shiftY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
      this.SuspendLayout();
      // 
      // image
      // 
      resources.ApplyResources(this.image, "image");
      this.image.Name = "image";
      this.image.TabStop = false;
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      // 
      // comboBox2
      // 
      resources.ApplyResources(this.comboBox2, "comboBox2");
      this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3")});
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.OnSelected);
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      // 
      // shiftX
      // 
      resources.ApplyResources(this.shiftX, "shiftX");
      this.shiftX.Name = "shiftX";
      this.shiftX.Tag = "2";
      this.shiftX.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.shiftX.Value = 5;
      this.shiftX.ValueChanged += new System.EventHandler(this.OnValueChanged);
      // 
      // shiftY
      // 
      resources.ApplyResources(this.shiftY, "shiftY");
      this.shiftY.Name = "shiftY";
      this.shiftY.Tag = "3";
      this.shiftY.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.shiftY.Value = 5;
      this.shiftY.ValueChanged += new System.EventHandler(this.OnValueChanged);
      // 
      // label3
      // 
      resources.ApplyResources(this.label3, "label3");
      this.label3.Name = "label3";
      // 
      // trackBar3
      // 
      resources.ApplyResources(this.trackBar3, "trackBar3");
      this.trackBar3.Name = "trackBar3";
      this.trackBar3.Tag = "0";
      this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.trackBar3.ValueChanged += new System.EventHandler(this.OnValueChanged);
      // 
      // label4
      // 
      resources.ApplyResources(this.label4, "label4");
      this.label4.Name = "label4";
      // 
      // trackBar4
      // 
      resources.ApplyResources(this.trackBar4, "trackBar4");
      this.trackBar4.Name = "trackBar4";
      this.trackBar4.Tag = "1";
      this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.Both;
      this.trackBar4.ValueChanged += new System.EventHandler(this.OnValueChanged);
      // 
      // label5
      // 
      resources.ApplyResources(this.label5, "label5");
      this.label5.Name = "label5";
      // 
      // MainView
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.trackBar4);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.trackBar3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.shiftY);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.shiftX);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.image);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Name = "MainView";
      this.Load += new System.EventHandler(this.OnLoad);
      ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.shiftX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.shiftY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox image;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar shiftX;
    private System.Windows.Forms.TrackBar shiftY;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar trackBar3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TrackBar trackBar4;
    private System.Windows.Forms.Label label5;
  }
}