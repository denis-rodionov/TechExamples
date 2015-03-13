namespace University
{
  partial class frmSubjects
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
      this.edtDesc = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.edtName = new System.Windows.Forms.TextBox();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.cmbGroups = new System.Windows.Forms.ComboBox();
      this.radGroup = new System.Windows.Forms.RadioButton();
      this.btnSelect = new System.Windows.Forms.Button();
      this.cmbCaths = new System.Windows.Forms.ComboBox();
      this.cmbTeachs = new System.Windows.Forms.ComboBox();
      this.radCaths = new System.Windows.Forms.RadioButton();
      this.radTeach = new System.Windows.Forms.RadioButton();
      this.radAll = new System.Windows.Forms.RadioButton();
      this.btnClose = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(311, 5);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(318, 369);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.edtDesc);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.edtName);
      this.tabPage1.Controls.Add(this.btnDelete);
      this.tabPage1.Controls.Add(this.btnModify);
      this.tabPage1.Controls.Add(this.btnAdd);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(310, 343);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Инфо";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // edtDesc
      // 
      this.edtDesc.Location = new System.Drawing.Point(69, 73);
      this.edtDesc.Multiline = true;
      this.edtDesc.Name = "edtDesc";
      this.edtDesc.Size = new System.Drawing.Size(234, 225);
      this.edtDesc.TabIndex = 5;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 76);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Описание";
      // 
      // edtName
      // 
      this.edtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.edtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.edtName.Location = new System.Drawing.Point(6, 6);
      this.edtName.Multiline = true;
      this.edtName.Name = "edtName";
      this.edtName.Size = new System.Drawing.Size(297, 61);
      this.edtName.TabIndex = 3;
      this.edtName.Text = "---";
      this.edtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(208, 304);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(95, 33);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "Удалить";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnModify
      // 
      this.btnModify.Location = new System.Drawing.Point(107, 304);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(95, 33);
      this.btnModify.TabIndex = 1;
      this.btnModify.Text = "Изменить";
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(6, 304);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(95, 33);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Добавить";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.cmbGroups);
      this.tabPage2.Controls.Add(this.radGroup);
      this.tabPage2.Controls.Add(this.btnSelect);
      this.tabPage2.Controls.Add(this.cmbCaths);
      this.tabPage2.Controls.Add(this.cmbTeachs);
      this.tabPage2.Controls.Add(this.radCaths);
      this.tabPage2.Controls.Add(this.radTeach);
      this.tabPage2.Controls.Add(this.radAll);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(310, 343);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Выборка";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // cmbGroups
      // 
      this.cmbGroups.FormattingEnabled = true;
      this.cmbGroups.Location = new System.Drawing.Point(158, 74);
      this.cmbGroups.Name = "cmbGroups";
      this.cmbGroups.Size = new System.Drawing.Size(147, 21);
      this.cmbGroups.TabIndex = 7;
      // 
      // radGroup
      // 
      this.radGroup.AutoSize = true;
      this.radGroup.Location = new System.Drawing.Point(6, 75);
      this.radGroup.Name = "radGroup";
      this.radGroup.Size = new System.Drawing.Size(84, 17);
      this.radGroup.TabIndex = 6;
      this.radGroup.TabStop = true;
      this.radGroup.Text = "По группам";
      this.radGroup.UseVisualStyleBackColor = true;
      this.radGroup.CheckedChanged += new System.EventHandler(this.radGroup_CheckedChanged);
      // 
      // btnSelect
      // 
      this.btnSelect.Location = new System.Drawing.Point(206, 299);
      this.btnSelect.Name = "btnSelect";
      this.btnSelect.Size = new System.Drawing.Size(99, 38);
      this.btnSelect.TabIndex = 5;
      this.btnSelect.Text = "Выбрать";
      this.btnSelect.UseVisualStyleBackColor = true;
      this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
      // 
      // cmbCaths
      // 
      this.cmbCaths.FormattingEnabled = true;
      this.cmbCaths.Location = new System.Drawing.Point(158, 51);
      this.cmbCaths.Name = "cmbCaths";
      this.cmbCaths.Size = new System.Drawing.Size(146, 21);
      this.cmbCaths.TabIndex = 4;
      // 
      // cmbTeachs
      // 
      this.cmbTeachs.FormattingEnabled = true;
      this.cmbTeachs.Location = new System.Drawing.Point(158, 28);
      this.cmbTeachs.Name = "cmbTeachs";
      this.cmbTeachs.Size = new System.Drawing.Size(146, 21);
      this.cmbTeachs.TabIndex = 3;
      // 
      // radCaths
      // 
      this.radCaths.AutoSize = true;
      this.radCaths.Location = new System.Drawing.Point(6, 52);
      this.radCaths.Name = "radCaths";
      this.radCaths.Size = new System.Drawing.Size(86, 17);
      this.radCaths.TabIndex = 2;
      this.radCaths.Text = "По кафедре";
      this.radCaths.UseVisualStyleBackColor = true;
      this.radCaths.CheckedChanged += new System.EventHandler(this.radCaths_CheckedChanged);
      // 
      // radTeach
      // 
      this.radTeach.AutoSize = true;
      this.radTeach.Location = new System.Drawing.Point(6, 29);
      this.radTeach.Name = "radTeach";
      this.radTeach.Size = new System.Drawing.Size(121, 17);
      this.radTeach.TabIndex = 1;
      this.radTeach.Text = "По преподавателю";
      this.radTeach.UseVisualStyleBackColor = true;
      this.radTeach.CheckedChanged += new System.EventHandler(this.radTeach_CheckedChanged);
      // 
      // radAll
      // 
      this.radAll.AutoSize = true;
      this.radAll.Checked = true;
      this.radAll.Location = new System.Drawing.Point(6, 6);
      this.radAll.Name = "radAll";
      this.radAll.Size = new System.Drawing.Size(109, 17);
      this.radAll.TabIndex = 0;
      this.radAll.TabStop = true;
      this.radAll.Text = "Все дисциплины";
      this.radAll.UseVisualStyleBackColor = true;
      this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(517, 376);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(112, 39);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Закрыть";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.button1.Location = new System.Drawing.Point(311, 376);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(200, 39);
      this.button1.TabIndex = 2;
      this.button1.Text = "Выбрать";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // frmSubjects
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(634, 419);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmSubjects";
      this.Text = "Дисциплины";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSelect;
    private System.Windows.Forms.ComboBox cmbCaths;
    private System.Windows.Forms.ComboBox cmbTeachs;
    private System.Windows.Forms.RadioButton radCaths;
    private System.Windows.Forms.RadioButton radTeach;
    private System.Windows.Forms.RadioButton radAll;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.TextBox edtName;
    private System.Windows.Forms.TextBox edtDesc;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cmbGroups;
    private System.Windows.Forms.RadioButton radGroup;
    private System.Windows.Forms.Button button1;
  }
}