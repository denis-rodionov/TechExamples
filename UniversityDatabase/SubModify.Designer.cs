namespace University
{
  partial class frmSubModify
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
      this.edtName = new System.Windows.Forms.TextBox();
      this.edtDesc = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(258, 122);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(110, 34);
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "button1";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Название";
      // 
      // edtName
      // 
      this.edtName.Location = new System.Drawing.Point(69, 6);
      this.edtName.Name = "edtName";
      this.edtName.Size = new System.Drawing.Size(299, 20);
      this.edtName.TabIndex = 0;
      // 
      // edtDesc
      // 
      this.edtDesc.Location = new System.Drawing.Point(69, 32);
      this.edtDesc.Multiline = true;
      this.edtDesc.Name = "edtDesc";
      this.edtDesc.Size = new System.Drawing.Size(299, 84);
      this.edtDesc.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Описание";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(142, 122);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(110, 34);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmSubModify
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(370, 164);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.edtDesc);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.edtName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmSubModify";
      this.Text = "SubModify";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox edtName;
    private System.Windows.Forms.TextBox edtDesc;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnCancel;
  }
}