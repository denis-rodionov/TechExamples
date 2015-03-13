namespace University
{
  partial class frmStartImage
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
        this.components = new System.ComponentModel.Container();
        this.imgMain = new System.Windows.Forms.PictureBox();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.imgMain)).BeginInit();
        this.SuspendLayout();
        // 
        // imgMain
        // 
        this.imgMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.imgMain.Image = global::University.Properties.Resources._1_0;
        this.imgMain.Location = new System.Drawing.Point(0, 0);
        this.imgMain.Name = "imgMain";
        this.imgMain.Size = new System.Drawing.Size(500, 350);
        this.imgMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        this.imgMain.TabIndex = 0;
        this.imgMain.TabStop = false;
        this.imgMain.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.imgMain_LoadCompleted);
        // 
        // timer1
        // 
        this.timer1.Enabled = true;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // frmStartImage
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 350);
        this.Controls.Add(this.imgMain);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "frmStartImage";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "StartImage";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStartImage_FormClosing);
        this.Load += new System.EventHandler(this.frmStartImage_Load);
        this.Shown += new System.EventHandler(this.frmStartImage_Shown);
        ((System.ComponentModel.ISupportInitialize)(this.imgMain)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox imgMain;
    private System.Windows.Forms.Timer timer1;
  }
}