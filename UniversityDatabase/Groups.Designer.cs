namespace University
{
  partial class frmGroups
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
      this.edtCurator = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.edtSpec = new System.Windows.Forms.TextBox();
      this.edtFac = new System.Windows.Forms.TextBox();
      this.edtStudCount = new System.Windows.Forms.TextBox();
      this.edtCourse = new System.Windows.Forms.TextBox();
      this.edtIndex = new System.Windows.Forms.TextBox();
      this.btnCreate = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnSelect = new System.Windows.Forms.Button();
      this.cmbFac = new System.Windows.Forms.ComboBox();
      this.cmbSpec = new System.Windows.Forms.ComboBox();
      this.radBySpec = new System.Windows.Forms.RadioButton();
      this.radByFac = new System.Windows.Forms.RadioButton();
      this.radAllGroups = new System.Windows.Forms.RadioButton();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.btnDelSubject = new System.Windows.Forms.Button();
      this.btnModifySubject = new System.Windows.Forms.Button();
      this.btnAddSubject = new System.Windows.Forms.Button();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnChoose = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(341, 5);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(324, 383);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.edtCurator);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.edtSpec);
      this.tabPage1.Controls.Add(this.edtFac);
      this.tabPage1.Controls.Add(this.edtStudCount);
      this.tabPage1.Controls.Add(this.edtCourse);
      this.tabPage1.Controls.Add(this.edtIndex);
      this.tabPage1.Controls.Add(this.btnCreate);
      this.tabPage1.Controls.Add(this.btnModify);
      this.tabPage1.Controls.Add(this.btnDelete);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(316, 357);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Общие";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // edtCurator
      // 
      this.edtCurator.BackColor = System.Drawing.SystemColors.Window;
      this.edtCurator.Location = new System.Drawing.Point(134, 162);
      this.edtCurator.Name = "edtCurator";
      this.edtCurator.ReadOnly = true;
      this.edtCurator.Size = new System.Drawing.Size(176, 20);
      this.edtCurator.TabIndex = 15;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 165);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(51, 13);
      this.label5.TabIndex = 14;
      this.label5.Text = "Куратор:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 113);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Факультет:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 139);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(123, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Количество студентов:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Специальность:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 61);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Семестр:";
      // 
      // edtSpec
      // 
      this.edtSpec.BackColor = System.Drawing.SystemColors.Window;
      this.edtSpec.Location = new System.Drawing.Point(134, 84);
      this.edtSpec.Name = "edtSpec";
      this.edtSpec.ReadOnly = true;
      this.edtSpec.Size = new System.Drawing.Size(176, 20);
      this.edtSpec.TabIndex = 9;
      // 
      // edtFac
      // 
      this.edtFac.BackColor = System.Drawing.SystemColors.Window;
      this.edtFac.Location = new System.Drawing.Point(134, 110);
      this.edtFac.Name = "edtFac";
      this.edtFac.ReadOnly = true;
      this.edtFac.Size = new System.Drawing.Size(177, 20);
      this.edtFac.TabIndex = 8;
      // 
      // edtStudCount
      // 
      this.edtStudCount.BackColor = System.Drawing.SystemColors.Window;
      this.edtStudCount.Location = new System.Drawing.Point(134, 136);
      this.edtStudCount.Name = "edtStudCount";
      this.edtStudCount.ReadOnly = true;
      this.edtStudCount.Size = new System.Drawing.Size(177, 20);
      this.edtStudCount.TabIndex = 7;
      // 
      // edtCourse
      // 
      this.edtCourse.BackColor = System.Drawing.SystemColors.Window;
      this.edtCourse.Location = new System.Drawing.Point(134, 58);
      this.edtCourse.Name = "edtCourse";
      this.edtCourse.ReadOnly = true;
      this.edtCourse.Size = new System.Drawing.Size(177, 20);
      this.edtCourse.TabIndex = 6;
      // 
      // edtIndex
      // 
      this.edtIndex.BackColor = System.Drawing.SystemColors.Window;
      this.edtIndex.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.edtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.edtIndex.Location = new System.Drawing.Point(6, 15);
      this.edtIndex.Name = "edtIndex";
      this.edtIndex.ReadOnly = true;
      this.edtIndex.Size = new System.Drawing.Size(304, 22);
      this.edtIndex.TabIndex = 5;
      this.edtIndex.Text = "---";
      this.edtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnCreate
      // 
      this.btnCreate.Location = new System.Drawing.Point(6, 316);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(97, 35);
      this.btnCreate.TabIndex = 2;
      this.btnCreate.Text = "Создать";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // btnModify
      // 
      this.btnModify.Location = new System.Drawing.Point(110, 316);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(97, 35);
      this.btnModify.TabIndex = 4;
      this.btnModify.Text = "Изменить";
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(213, 316);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(97, 35);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "Удалить";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btnSelect);
      this.tabPage2.Controls.Add(this.cmbFac);
      this.tabPage2.Controls.Add(this.cmbSpec);
      this.tabPage2.Controls.Add(this.radBySpec);
      this.tabPage2.Controls.Add(this.radByFac);
      this.tabPage2.Controls.Add(this.radAllGroups);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(316, 357);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Выборка";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btnSelect
      // 
      this.btnSelect.Location = new System.Drawing.Point(187, 78);
      this.btnSelect.Name = "btnSelect";
      this.btnSelect.Size = new System.Drawing.Size(123, 37);
      this.btnSelect.TabIndex = 10;
      this.btnSelect.Text = "Выбрать";
      this.btnSelect.UseVisualStyleBackColor = true;
      this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
      // 
      // cmbFac
      // 
      this.cmbFac.FormattingEnabled = true;
      this.cmbFac.Location = new System.Drawing.Point(146, 51);
      this.cmbFac.Name = "cmbFac";
      this.cmbFac.Size = new System.Drawing.Size(164, 21);
      this.cmbFac.TabIndex = 9;
      // 
      // cmbSpec
      // 
      this.cmbSpec.FormattingEnabled = true;
      this.cmbSpec.Location = new System.Drawing.Point(146, 28);
      this.cmbSpec.Name = "cmbSpec";
      this.cmbSpec.Size = new System.Drawing.Size(164, 21);
      this.cmbSpec.TabIndex = 8;
      // 
      // radBySpec
      // 
      this.radBySpec.AutoSize = true;
      this.radBySpec.Location = new System.Drawing.Point(6, 29);
      this.radBySpec.Name = "radBySpec";
      this.radBySpec.Size = new System.Drawing.Size(119, 17);
      this.radBySpec.TabIndex = 7;
      this.radBySpec.Text = "По специальности";
      this.radBySpec.UseVisualStyleBackColor = true;
      this.radBySpec.CheckedChanged += new System.EventHandler(this.radBySpec_CheckedChanged);
      // 
      // radByFac
      // 
      this.radByFac.AutoSize = true;
      this.radByFac.Location = new System.Drawing.Point(6, 52);
      this.radByFac.Name = "radByFac";
      this.radByFac.Size = new System.Drawing.Size(100, 17);
      this.radByFac.TabIndex = 6;
      this.radByFac.Text = "По факультету";
      this.radByFac.UseVisualStyleBackColor = true;
      this.radByFac.CheckedChanged += new System.EventHandler(this.rabByFac_CheckedChanged);
      // 
      // radAllGroups
      // 
      this.radAllGroups.AutoSize = true;
      this.radAllGroups.Checked = true;
      this.radAllGroups.Location = new System.Drawing.Point(6, 6);
      this.radAllGroups.Name = "radAllGroups";
      this.radAllGroups.Size = new System.Drawing.Size(83, 17);
      this.radAllGroups.TabIndex = 5;
      this.radAllGroups.TabStop = true;
      this.radAllGroups.Text = "Все группы";
      this.radAllGroups.UseVisualStyleBackColor = true;
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.btnDelSubject);
      this.tabPage4.Controls.Add(this.btnModifySubject);
      this.tabPage4.Controls.Add(this.btnAddSubject);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(316, 357);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Дисциплины";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // btnDelSubject
      // 
      this.btnDelSubject.Location = new System.Drawing.Point(214, 321);
      this.btnDelSubject.Name = "btnDelSubject";
      this.btnDelSubject.Size = new System.Drawing.Size(99, 33);
      this.btnDelSubject.TabIndex = 2;
      this.btnDelSubject.Text = "Удалить";
      this.btnDelSubject.UseVisualStyleBackColor = true;
      this.btnDelSubject.Click += new System.EventHandler(this.btnDelSubject_Click);
      // 
      // btnModifySubject
      // 
      this.btnModifySubject.Location = new System.Drawing.Point(108, 321);
      this.btnModifySubject.Name = "btnModifySubject";
      this.btnModifySubject.Size = new System.Drawing.Size(100, 33);
      this.btnModifySubject.TabIndex = 1;
      this.btnModifySubject.Text = "Измнить";
      this.btnModifySubject.UseVisualStyleBackColor = true;
      this.btnModifySubject.Click += new System.EventHandler(this.btnModifySubject_Click);
      // 
      // btnAddSubject
      // 
      this.btnAddSubject.Location = new System.Drawing.Point(3, 321);
      this.btnAddSubject.Name = "btnAddSubject";
      this.btnAddSubject.Size = new System.Drawing.Size(99, 33);
      this.btnAddSubject.TabIndex = 0;
      this.btnAddSubject.Text = "Добавить";
      this.btnAddSubject.UseVisualStyleBackColor = true;
      this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
      // 
      // tabPage3
      // 
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(316, 357);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Студенты";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnClose.Location = new System.Drawing.Point(534, 394);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(131, 35);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Закрыть";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnChoose
      // 
      this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnChoose.Location = new System.Drawing.Point(341, 394);
      this.btnChoose.Name = "btnChoose";
      this.btnChoose.Size = new System.Drawing.Size(187, 35);
      this.btnChoose.TabIndex = 2;
      this.btnChoose.Text = "Выбрать";
      this.btnChoose.UseVisualStyleBackColor = true;
      this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
      // 
      // frmGroups
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(673, 434);
      this.Controls.Add(this.btnChoose);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmGroups";
      this.Text = "Группы";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnSelect;
    private System.Windows.Forms.ComboBox cmbFac;
    private System.Windows.Forms.ComboBox cmbSpec;
    private System.Windows.Forms.RadioButton radBySpec;
    private System.Windows.Forms.RadioButton radByFac;
    private System.Windows.Forms.RadioButton radAllGroups;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TextBox edtCurator;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox edtSpec;
    private System.Windows.Forms.TextBox edtFac;
    private System.Windows.Forms.TextBox edtStudCount;
    private System.Windows.Forms.TextBox edtCourse;
    private System.Windows.Forms.TextBox edtIndex;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.Button btnDelSubject;
    private System.Windows.Forms.Button btnModifySubject;
    private System.Windows.Forms.Button btnAddSubject;
    private System.Windows.Forms.Button btnChoose;
  }
}