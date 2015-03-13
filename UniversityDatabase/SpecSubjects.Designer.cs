namespace University
{
  partial class frmSpecSubjects
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
      this.btnOk = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.edtName = new System.Windows.Forms.TextBox();
      this.numHours = new System.Windows.Forms.NumericUpDown();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnChoose = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(250, 58);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(103, 34);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "ОК";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Название:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(101, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Количество часов:";
      // 
      // edtName
      // 
      this.edtName.Location = new System.Drawing.Point(124, 6);
      this.edtName.Name = "edtName";
      this.edtName.ReadOnly = true;
      this.edtName.Size = new System.Drawing.Size(229, 20);
      this.edtName.TabIndex = 3;
      this.edtName.Text = "---";
      // 
      // numHours
      // 
      this.numHours.Location = new System.Drawing.Point(124, 32);
      this.numHours.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numHours.Name = "numHours";
      this.numHours.Size = new System.Drawing.Size(229, 20);
      this.numHours.TabIndex = 4;
      this.numHours.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(139, 58);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(105, 34);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnChoose
      // 
      this.btnChoose.Location = new System.Drawing.Point(2, 58);
      this.btnChoose.Name = "btnChoose";
      this.btnChoose.Size = new System.Drawing.Size(131, 34);
      this.btnChoose.TabIndex = 6;
      this.btnChoose.Text = "Выбрать дисциплину";
      this.btnChoose.UseVisualStyleBackColor = true;
      this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
      // 
      // frmSpecSubjects
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(359, 99);
      this.Controls.Add(this.btnChoose);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.numHours);
      this.Controls.Add(this.edtName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmSpecSubjects";
      this.Text = "Добавление дисциплины";
      ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox edtName;
    private System.Windows.Forms.NumericUpDown numHours;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnChoose;
  }
}