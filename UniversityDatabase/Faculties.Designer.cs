namespace University
{
  partial class frmFaculties
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
      this.btnClose = new System.Windows.Forms.Button();
      this.tabCommon = new System.Windows.Forms.TabPage();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.edtHead = new System.Windows.Forms.TextBox();
      this.edtName = new System.Windows.Forms.TextBox();
      this.edtDesc = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabCommon.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(543, 370);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(118, 30);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Закрыть";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // tabCommon
      // 
      this.tabCommon.Controls.Add(this.btnAdd);
      this.tabCommon.Controls.Add(this.btnModify);
      this.tabCommon.Controls.Add(this.btnDelete);
      this.tabCommon.Controls.Add(this.label2);
      this.tabCommon.Controls.Add(this.edtHead);
      this.tabCommon.Controls.Add(this.edtName);
      this.tabCommon.Controls.Add(this.edtDesc);
      this.tabCommon.Controls.Add(this.label1);
      this.tabCommon.Location = new System.Drawing.Point(4, 22);
      this.tabCommon.Name = "tabCommon";
      this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
      this.tabCommon.Size = new System.Drawing.Size(352, 326);
      this.tabCommon.TabIndex = 0;
      this.tabCommon.Text = "Общие";
      this.tabCommon.UseVisualStyleBackColor = true;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(9, 286);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(104, 34);
      this.btnAdd.TabIndex = 7;
      this.btnAdd.Text = "Добавить";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnModify
      // 
      this.btnModify.Location = new System.Drawing.Point(241, 286);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(104, 34);
      this.btnModify.TabIndex = 6;
      this.btnModify.Text = "Изменить";
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(125, 286);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(104, 34);
      this.btnDelete.TabIndex = 5;
      this.btnDelete.Text = "Удалить";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 172);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Декан:";
      // 
      // edtHead
      // 
      this.edtHead.Location = new System.Drawing.Point(118, 169);
      this.edtHead.Name = "edtHead";
      this.edtHead.ReadOnly = true;
      this.edtHead.Size = new System.Drawing.Size(228, 20);
      this.edtHead.TabIndex = 3;
      // 
      // edtName
      // 
      this.edtName.BackColor = System.Drawing.SystemColors.Window;
      this.edtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.edtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.edtName.Location = new System.Drawing.Point(6, 15);
      this.edtName.Name = "edtName";
      this.edtName.ReadOnly = true;
      this.edtName.Size = new System.Drawing.Size(340, 22);
      this.edtName.TabIndex = 2;
      this.edtName.Text = "---";
      this.edtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // edtDesc
      // 
      this.edtDesc.Location = new System.Drawing.Point(118, 70);
      this.edtDesc.Multiline = true;
      this.edtDesc.Name = "edtDesc";
      this.edtDesc.ReadOnly = true;
      this.edtDesc.Size = new System.Drawing.Size(228, 93);
      this.edtDesc.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 70);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(116, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Сфера деятельности:";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabCommon);
      this.tabControl1.Location = new System.Drawing.Point(301, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(360, 352);
      this.tabControl1.TabIndex = 2;
      // 
      // frmFaculties
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(668, 405);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnClose);
      this.Name = "frmFaculties";
      this.Text = "Факультеты";
      this.Load += new System.EventHandler(this.frmFaculties_Load);
      this.tabCommon.ResumeLayout(false);
      this.tabCommon.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TabPage tabCommon;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox edtHead;
    private System.Windows.Forms.TextBox edtName;
    private System.Windows.Forms.TextBox edtDesc;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabControl tabControl1;


  }
}