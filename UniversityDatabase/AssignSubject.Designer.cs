namespace University
{
  partial class frmAssignSubject
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
      this.label3 = new System.Windows.Forms.Label();
      this.edtSubject = new System.Windows.Forms.TextBox();
      this.edtGroup = new System.Windows.Forms.TextBox();
      this.edtTeach = new System.Windows.Forms.TextBox();
      this.btnSubject = new System.Windows.Forms.Button();
      this.btnGroup = new System.Windows.Forms.Button();
      this.btnTeach = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(491, 43);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(107, 33);
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
      this.label1.Size = new System.Drawing.Size(73, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Дисциплина:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 34);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Группа:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(89, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Преподаватель:";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // edtSubject
      // 
      this.edtSubject.Location = new System.Drawing.Point(110, 6);
      this.edtSubject.Name = "edtSubject";
      this.edtSubject.ReadOnly = true;
      this.edtSubject.Size = new System.Drawing.Size(241, 20);
      this.edtSubject.TabIndex = 5;
      // 
      // edtGroup
      // 
      this.edtGroup.Location = new System.Drawing.Point(110, 31);
      this.edtGroup.Name = "edtGroup";
      this.edtGroup.ReadOnly = true;
      this.edtGroup.Size = new System.Drawing.Size(241, 20);
      this.edtGroup.TabIndex = 6;
      // 
      // edtTeach
      // 
      this.edtTeach.Location = new System.Drawing.Point(110, 56);
      this.edtTeach.Name = "edtTeach";
      this.edtTeach.ReadOnly = true;
      this.edtTeach.Size = new System.Drawing.Size(241, 20);
      this.edtTeach.TabIndex = 7;
      this.edtTeach.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
      // 
      // btnSubject
      // 
      this.btnSubject.Location = new System.Drawing.Point(357, 6);
      this.btnSubject.Name = "btnSubject";
      this.btnSubject.Size = new System.Drawing.Size(128, 20);
      this.btnSubject.TabIndex = 8;
      this.btnSubject.Text = "Назначить";
      this.btnSubject.UseVisualStyleBackColor = true;
      this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
      // 
      // btnGroup
      // 
      this.btnGroup.Location = new System.Drawing.Point(357, 31);
      this.btnGroup.Name = "btnGroup";
      this.btnGroup.Size = new System.Drawing.Size(128, 20);
      this.btnGroup.TabIndex = 9;
      this.btnGroup.Text = "Назначить";
      this.btnGroup.UseVisualStyleBackColor = true;
      this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
      // 
      // btnTeach
      // 
      this.btnTeach.Location = new System.Drawing.Point(357, 56);
      this.btnTeach.Name = "btnTeach";
      this.btnTeach.Size = new System.Drawing.Size(128, 20);
      this.btnTeach.TabIndex = 10;
      this.btnTeach.Text = "Назначить";
      this.btnTeach.UseVisualStyleBackColor = true;
      this.btnTeach.Click += new System.EventHandler(this.button5_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(491, 6);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(107, 33);
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmAssignSubject
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(608, 83);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnTeach);
      this.Controls.Add(this.btnGroup);
      this.Controls.Add(this.btnSubject);
      this.Controls.Add(this.edtTeach);
      this.Controls.Add(this.edtGroup);
      this.Controls.Add(this.edtSubject);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmAssignSubject";
      this.Text = "Назначение дисциплины группе";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox edtSubject;
    private System.Windows.Forms.TextBox edtGroup;
    private System.Windows.Forms.TextBox edtTeach;
    private System.Windows.Forms.Button btnSubject;
    private System.Windows.Forms.Button btnGroup;
    private System.Windows.Forms.Button btnTeach;
    private System.Windows.Forms.Button btnCancel;
  }
}