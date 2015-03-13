namespace University
{
  partial class frmFacModify
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
      this.btnSelectHead = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.edtName = new System.Windows.Forms.TextBox();
      this.edtDesc = new System.Windows.Forms.TextBox();
      this.edtHead = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(281, 139);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(92, 38);
      this.btnOk.TabIndex = 4;
      this.btnOk.Text = "button1";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnSelectHead
      // 
      this.btnSelectHead.Location = new System.Drawing.Point(12, 139);
      this.btnSelectHead.Name = "btnSelectHead";
      this.btnSelectHead.Size = new System.Drawing.Size(165, 38);
      this.btnSelectHead.TabIndex = 3;
      this.btnSelectHead.Text = "Выбрать декана кафедры";
      this.btnSelectHead.UseVisualStyleBackColor = true;
      this.btnSelectHead.Click += new System.EventHandler(this.btnSelectHead_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(183, 139);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(92, 38);
      this.btnCancel.TabIndex = 5;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // edtName
      // 
      this.edtName.Location = new System.Drawing.Point(130, 16);
      this.edtName.Name = "edtName";
      this.edtName.Size = new System.Drawing.Size(243, 20);
      this.edtName.TabIndex = 0;
      // 
      // edtDesc
      // 
      this.edtDesc.Location = new System.Drawing.Point(130, 42);
      this.edtDesc.Multiline = true;
      this.edtDesc.Name = "edtDesc";
      this.edtDesc.Size = new System.Drawing.Size(243, 65);
      this.edtDesc.TabIndex = 1;
      // 
      // edtHead
      // 
      this.edtHead.Location = new System.Drawing.Point(130, 113);
      this.edtHead.Name = "edtHead";
      this.edtHead.ReadOnly = true;
      this.edtHead.Size = new System.Drawing.Size(243, 20);
      this.edtHead.TabIndex = 2;
      this.edtHead.Text = "Не задан";
      this.edtHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Название:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(116, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Сфера деятельности:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 116);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(43, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Декан:";
      // 
      // frmFacModify
      // 
      this.AcceptButton = this.btnOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(385, 187);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.edtHead);
      this.Controls.Add(this.edtDesc);
      this.Controls.Add(this.edtName);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSelectHead);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmFacModify";
      this.Text = "FacModify";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnSelectHead;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TextBox edtName;
    private System.Windows.Forms.TextBox edtDesc;
    private System.Windows.Forms.TextBox edtHead;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
  }
}