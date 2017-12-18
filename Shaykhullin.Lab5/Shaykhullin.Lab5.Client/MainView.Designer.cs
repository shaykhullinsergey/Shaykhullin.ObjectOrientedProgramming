namespace Shaykhullin.Lab5.Client
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
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.status = new System.Windows.Forms.Label();
      this.url = new System.Windows.Forms.TextBox();
      this.download = new System.Windows.Forms.Button();
      this.result = new System.Windows.Forms.TextBox();
      this.hexResult = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(12, 127);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(681, 23);
      this.progressBar.TabIndex = 0;
      // 
      // status
      // 
      this.status.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.status.Location = new System.Drawing.Point(12, 90);
      this.status.Name = "status";
      this.status.Size = new System.Drawing.Size(681, 34);
      this.status.TabIndex = 1;
      this.status.Text = "status";
      this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // url
      // 
      this.url.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.url.Location = new System.Drawing.Point(12, 13);
      this.url.Name = "url";
      this.url.Size = new System.Drawing.Size(569, 21);
      this.url.TabIndex = 2;
      // 
      // download
      // 
      this.download.Location = new System.Drawing.Point(587, 12);
      this.download.Name = "download";
      this.download.Size = new System.Drawing.Size(106, 23);
      this.download.TabIndex = 3;
      this.download.Text = "Download";
      this.download.UseVisualStyleBackColor = true;
      this.download.Click += new System.EventHandler(this.OnDownloadClick);
      // 
      // result
      // 
      this.result.Location = new System.Drawing.Point(12, 41);
      this.result.Name = "result";
      this.result.Size = new System.Drawing.Size(681, 20);
      this.result.TabIndex = 4;
      // 
      // hexResult
      // 
      this.hexResult.Location = new System.Drawing.Point(12, 67);
      this.hexResult.Name = "hexResult";
      this.hexResult.Size = new System.Drawing.Size(681, 20);
      this.hexResult.TabIndex = 5;
      // 
      // MainView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(705, 161);
      this.Controls.Add(this.hexResult);
      this.Controls.Add(this.result);
      this.Controls.Add(this.download);
      this.Controls.Add(this.url);
      this.Controls.Add(this.status);
      this.Controls.Add(this.progressBar);
      this.Name = "MainView";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.Label status;
    private System.Windows.Forms.TextBox url;
    private System.Windows.Forms.Button download;
    private System.Windows.Forms.TextBox result;
    private System.Windows.Forms.TextBox hexResult;
  }
}

