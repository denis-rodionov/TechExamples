namespace University
{
  partial class frmCathModify
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.edtName = new System.Windows.Forms.TextBox();
      this.edtDesc = new System.Windows.Forms.TextBox();
      this.edtIndex = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.cmbFacs = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.edtHead = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(306, 206);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(109, 34);
      this.btnOk.TabIndex = 5;
      this.btnOk.Text = "Лады";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(191, 206);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(109, 34);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // edtName
      // 
      this.edtName.Location = new System.Drawing.Point(134, 12);
      this.edtName.Name = "edtName";
      this.edtName.Size = new System.Drawing.Size(277, 20);
      this.edtName.TabIndex = 0;
      // 
      // edtDesc
      // 
      this.edtDesc.Location = new System.Drawing.Point(134, 64);
      this.edtDesc.Multiline = true;
      this.edtDesc.Name = "edtDesc";
      this.edtDesc.Size = new System.Drawing.Size(277, 83);
      this.edtDesc.TabIndex = 2;
      // 
      // edtIndex
      // 
      this.edtIndex.Location = new System.Drawing.Point(134, 38);
      this.edtIndex.Name = "edtIndex";
      this.edtIndex.Size = new System.Drawing.Size(277, 20);
      this.edtIndex.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Название";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Индекс";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(113, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Сфера деятельности";
      // 
      // cmbFacs
      // 
      this.cmbFacs.FormattingEnabled = true;
      this.cmbFacs.Location = new System.Drawing.Point(134, 153);
      this.cmbFacs.Name = "cmbFacs";
      this.cmbFacs.Size = new System.Drawing.Size(277, 21);
      this.cmbFacs.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 156);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Факультет";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 183);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(72, 13);
      this.label5.TabIndex = 10;
      this.label5.Text = "Заведующий";
      // 
      // edtHead
      // 
      this.edtHead.Location = new System.Drawing.Point(134, 180);
      this.edtHead.Name = "edtHead";
      this.edtHead.ReadOnly = true;
      this.edtHead.Size = new System.Drawing.Size(277, 20);
      this.edtHead.TabIndex = 7;
      this.edtHead.Text = "Не выбран";
      this.edtHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(12, 206);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(173, 34);
      this.button3.TabIndex = 4;
      this.button3.Text = "Выбрать заведеющего кафедрой";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // frmCathModify
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(423, 249);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.edtHead);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cmbFacs);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.edtIndex);
      this.Controls.Add(this.edtDesc);
      this.Controls.Add(this.edtName);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmCathModify";
      this.Text = "CathModify";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TextBox edtName;
    private System.Windows.Forms.TextBox edtDesc;
    private System.Windows.Forms.TextBox edtIndex;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbFacs;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox edtHead;
    private System.Windows.Forms.Button button3;
  }
}