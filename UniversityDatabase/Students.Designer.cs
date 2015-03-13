namespace University
{
  partial class frmStudents
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.edtPasNo = new System.Windows.Forms.TextBox();
      this.edtRecordBook = new System.Windows.Forms.TextBox();
      this.edtAge = new System.Windows.Forms.TextBox();
      this.edtStartYear = new System.Windows.Forms.TextBox();
      this.edtPhone = new System.Windows.Forms.TextBox();
      this.edtAddress = new System.Windows.Forms.TextBox();
      this.edtCourse = new System.Windows.Forms.TextBox();
      this.edtGroup = new System.Windows.Forms.TextBox();
      this.edtCathName = new System.Windows.Forms.TextBox();
      this.edtFirstName = new System.Windows.Forms.TextBox();
      this.edtThirdName = new System.Windows.Forms.TextBox();
      this.edtFacName = new System.Windows.Forms.TextBox();
      this.edtLastName = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnModify = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnSelect = new System.Windows.Forms.Button();
      this.cmbCath = new System.Windows.Forms.ComboBox();
      this.cmbFac = new System.Windows.Forms.ComboBox();
      this.cmbGroup = new System.Windows.Forms.ComboBox();
      this.radByGroup = new System.Windows.Forms.RadioButton();
      this.radByCath = new System.Windows.Forms.RadioButton();
      this.radByFac = new System.Windows.Forms.RadioButton();
      this.radAll = new System.Windows.Forms.RadioButton();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.btnOk = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(564, 488);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(99, 33);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "Закрыть";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Location = new System.Drawing.Point(364, 12);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(299, 470);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.label10);
      this.tabPage1.Controls.Add(this.label9);
      this.tabPage1.Controls.Add(this.label8);
      this.tabPage1.Controls.Add(this.label7);
      this.tabPage1.Controls.Add(this.label6);
      this.tabPage1.Controls.Add(this.label5);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.edtPasNo);
      this.tabPage1.Controls.Add(this.edtRecordBook);
      this.tabPage1.Controls.Add(this.edtAge);
      this.tabPage1.Controls.Add(this.edtStartYear);
      this.tabPage1.Controls.Add(this.edtPhone);
      this.tabPage1.Controls.Add(this.edtAddress);
      this.tabPage1.Controls.Add(this.edtCourse);
      this.tabPage1.Controls.Add(this.edtGroup);
      this.tabPage1.Controls.Add(this.edtCathName);
      this.tabPage1.Controls.Add(this.edtFirstName);
      this.tabPage1.Controls.Add(this.edtThirdName);
      this.tabPage1.Controls.Add(this.edtFacName);
      this.tabPage1.Controls.Add(this.edtLastName);
      this.tabPage1.Controls.Add(this.btnAdd);
      this.tabPage1.Controls.Add(this.btnDelete);
      this.tabPage1.Controls.Add(this.btnModify);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(291, 444);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Общие";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(6, 131);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(69, 13);
      this.label10.TabIndex = 25;
      this.label10.Text = "Зач. книжка";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(6, 387);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(66, 13);
      this.label9.TabIndex = 24;
      this.label9.Text = "Факультет:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(6, 361);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(55, 13);
      this.label8.TabIndex = 23;
      this.label8.Text = "Кафедра:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 335);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(45, 13);
      this.label7.TabIndex = 22;
      this.label7.Text = "Группа:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 309);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(54, 13);
      this.label6.TabIndex = 21;
      this.label6.Text = "Семестр:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 235);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(41, 13);
      this.label5.TabIndex = 20;
      this.label5.Text = "Адрес:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 209);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 13);
      this.label4.TabIndex = 19;
      this.label4.Text = "Телефон:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 183);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(95, 13);
      this.label3.TabIndex = 18;
      this.label3.Text = "Год поступления:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 157);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 17;
      this.label2.Text = "Возраст:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 105);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "Паспорт:";
      // 
      // edtPasNo
      // 
      this.edtPasNo.BackColor = System.Drawing.SystemColors.Window;
      this.edtPasNo.Location = new System.Drawing.Point(108, 102);
      this.edtPasNo.Name = "edtPasNo";
      this.edtPasNo.ReadOnly = true;
      this.edtPasNo.Size = new System.Drawing.Size(170, 20);
      this.edtPasNo.TabIndex = 15;
      // 
      // edtRecordBook
      // 
      this.edtRecordBook.BackColor = System.Drawing.SystemColors.Window;
      this.edtRecordBook.Location = new System.Drawing.Point(108, 128);
      this.edtRecordBook.Name = "edtRecordBook";
      this.edtRecordBook.ReadOnly = true;
      this.edtRecordBook.Size = new System.Drawing.Size(170, 20);
      this.edtRecordBook.TabIndex = 14;
      // 
      // edtAge
      // 
      this.edtAge.BackColor = System.Drawing.SystemColors.Window;
      this.edtAge.Location = new System.Drawing.Point(108, 154);
      this.edtAge.Name = "edtAge";
      this.edtAge.ReadOnly = true;
      this.edtAge.Size = new System.Drawing.Size(170, 20);
      this.edtAge.TabIndex = 13;
      // 
      // edtStartYear
      // 
      this.edtStartYear.BackColor = System.Drawing.SystemColors.Window;
      this.edtStartYear.Location = new System.Drawing.Point(108, 180);
      this.edtStartYear.Name = "edtStartYear";
      this.edtStartYear.ReadOnly = true;
      this.edtStartYear.Size = new System.Drawing.Size(170, 20);
      this.edtStartYear.TabIndex = 12;
      // 
      // edtPhone
      // 
      this.edtPhone.BackColor = System.Drawing.SystemColors.Window;
      this.edtPhone.Location = new System.Drawing.Point(108, 206);
      this.edtPhone.Name = "edtPhone";
      this.edtPhone.ReadOnly = true;
      this.edtPhone.Size = new System.Drawing.Size(170, 20);
      this.edtPhone.TabIndex = 11;
      // 
      // edtAddress
      // 
      this.edtAddress.BackColor = System.Drawing.SystemColors.Window;
      this.edtAddress.Location = new System.Drawing.Point(108, 232);
      this.edtAddress.Multiline = true;
      this.edtAddress.Name = "edtAddress";
      this.edtAddress.ReadOnly = true;
      this.edtAddress.Size = new System.Drawing.Size(170, 68);
      this.edtAddress.TabIndex = 10;
      // 
      // edtCourse
      // 
      this.edtCourse.BackColor = System.Drawing.SystemColors.Window;
      this.edtCourse.Location = new System.Drawing.Point(108, 306);
      this.edtCourse.Name = "edtCourse";
      this.edtCourse.ReadOnly = true;
      this.edtCourse.Size = new System.Drawing.Size(170, 20);
      this.edtCourse.TabIndex = 9;
      // 
      // edtGroup
      // 
      this.edtGroup.BackColor = System.Drawing.SystemColors.Window;
      this.edtGroup.Location = new System.Drawing.Point(108, 332);
      this.edtGroup.Name = "edtGroup";
      this.edtGroup.ReadOnly = true;
      this.edtGroup.Size = new System.Drawing.Size(170, 20);
      this.edtGroup.TabIndex = 8;
      // 
      // edtCathName
      // 
      this.edtCathName.BackColor = System.Drawing.SystemColors.Window;
      this.edtCathName.Location = new System.Drawing.Point(108, 358);
      this.edtCathName.Name = "edtCathName";
      this.edtCathName.ReadOnly = true;
      this.edtCathName.Size = new System.Drawing.Size(170, 20);
      this.edtCathName.TabIndex = 7;
      // 
      // edtFirstName
      // 
      this.edtFirstName.BackColor = System.Drawing.SystemColors.Window;
      this.edtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.edtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.edtFirstName.Location = new System.Drawing.Point(6, 38);
      this.edtFirstName.Name = "edtFirstName";
      this.edtFirstName.ReadOnly = true;
      this.edtFirstName.Size = new System.Drawing.Size(272, 19);
      this.edtFirstName.TabIndex = 6;
      this.edtFirstName.Text = "---";
      this.edtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // edtThirdName
      // 
      this.edtThirdName.BackColor = System.Drawing.SystemColors.Window;
      this.edtThirdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.edtThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.edtThirdName.Location = new System.Drawing.Point(6, 70);
      this.edtThirdName.Name = "edtThirdName";
      this.edtThirdName.ReadOnly = true;
      this.edtThirdName.Size = new System.Drawing.Size(272, 19);
      this.edtThirdName.TabIndex = 5;
      this.edtThirdName.Text = "---";
      this.edtThirdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // edtFacName
      // 
      this.edtFacName.BackColor = System.Drawing.SystemColors.Window;
      this.edtFacName.Location = new System.Drawing.Point(108, 384);
      this.edtFacName.Name = "edtFacName";
      this.edtFacName.ReadOnly = true;
      this.edtFacName.Size = new System.Drawing.Size(170, 20);
      this.edtFacName.TabIndex = 4;
      // 
      // edtLastName
      // 
      this.edtLastName.BackColor = System.Drawing.SystemColors.Window;
      this.edtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.edtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.edtLastName.Location = new System.Drawing.Point(6, 6);
      this.edtLastName.Name = "edtLastName";
      this.edtLastName.ReadOnly = true;
      this.edtLastName.Size = new System.Drawing.Size(272, 19);
      this.edtLastName.TabIndex = 3;
      this.edtLastName.Text = "---";
      this.edtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(6, 411);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(86, 27);
      this.btnAdd.TabIndex = 2;
      this.btnAdd.Text = "Добавить";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(192, 411);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(86, 27);
      this.btnDelete.TabIndex = 1;
      this.btnDelete.Text = "Удалить";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnModify
      // 
      this.btnModify.Location = new System.Drawing.Point(99, 411);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(86, 27);
      this.btnModify.TabIndex = 0;
      this.btnModify.Text = "Изменить";
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btnSelect);
      this.tabPage2.Controls.Add(this.cmbCath);
      this.tabPage2.Controls.Add(this.cmbFac);
      this.tabPage2.Controls.Add(this.cmbGroup);
      this.tabPage2.Controls.Add(this.radByGroup);
      this.tabPage2.Controls.Add(this.radByCath);
      this.tabPage2.Controls.Add(this.radByFac);
      this.tabPage2.Controls.Add(this.radAll);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(291, 444);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Выборка";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btnSelect
      // 
      this.btnSelect.Location = new System.Drawing.Point(162, 304);
      this.btnSelect.Name = "btnSelect";
      this.btnSelect.Size = new System.Drawing.Size(118, 29);
      this.btnSelect.TabIndex = 7;
      this.btnSelect.Text = "Выбрать";
      this.btnSelect.UseVisualStyleBackColor = true;
      this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
      // 
      // cmbCath
      // 
      this.cmbCath.FormattingEnabled = true;
      this.cmbCath.Location = new System.Drawing.Point(116, 51);
      this.cmbCath.Name = "cmbCath";
      this.cmbCath.Size = new System.Drawing.Size(164, 21);
      this.cmbCath.TabIndex = 6;
      // 
      // cmbFac
      // 
      this.cmbFac.FormattingEnabled = true;
      this.cmbFac.Location = new System.Drawing.Point(116, 74);
      this.cmbFac.Name = "cmbFac";
      this.cmbFac.Size = new System.Drawing.Size(164, 21);
      this.cmbFac.TabIndex = 5;
      // 
      // cmbGroup
      // 
      this.cmbGroup.FormattingEnabled = true;
      this.cmbGroup.Location = new System.Drawing.Point(116, 28);
      this.cmbGroup.Name = "cmbGroup";
      this.cmbGroup.Size = new System.Drawing.Size(164, 21);
      this.cmbGroup.TabIndex = 4;
      // 
      // radByGroup
      // 
      this.radByGroup.AutoSize = true;
      this.radByGroup.Location = new System.Drawing.Point(6, 29);
      this.radByGroup.Name = "radByGroup";
      this.radByGroup.Size = new System.Drawing.Size(76, 17);
      this.radByGroup.TabIndex = 3;
      this.radByGroup.TabStop = true;
      this.radByGroup.Text = "По группе";
      this.radByGroup.UseVisualStyleBackColor = true;
      this.radByGroup.CheckedChanged += new System.EventHandler(this.radByGroup_CheckedChanged);
      // 
      // radByCath
      // 
      this.radByCath.AutoSize = true;
      this.radByCath.Location = new System.Drawing.Point(6, 52);
      this.radByCath.Name = "radByCath";
      this.radByCath.Size = new System.Drawing.Size(86, 17);
      this.radByCath.TabIndex = 2;
      this.radByCath.TabStop = true;
      this.radByCath.Text = "По кафедре";
      this.radByCath.UseVisualStyleBackColor = true;
      this.radByCath.CheckedChanged += new System.EventHandler(this.radByCath_CheckedChanged);
      // 
      // radByFac
      // 
      this.radByFac.AutoSize = true;
      this.radByFac.Location = new System.Drawing.Point(6, 75);
      this.radByFac.Name = "radByFac";
      this.radByFac.Size = new System.Drawing.Size(100, 17);
      this.radByFac.TabIndex = 1;
      this.radByFac.TabStop = true;
      this.radByFac.Text = "По факультету";
      this.radByFac.UseVisualStyleBackColor = true;
      this.radByFac.CheckedChanged += new System.EventHandler(this.radByFac_CheckedChanged);
      // 
      // radAll
      // 
      this.radAll.AutoSize = true;
      this.radAll.Location = new System.Drawing.Point(6, 6);
      this.radAll.Name = "radAll";
      this.radAll.Size = new System.Drawing.Size(94, 17);
      this.radAll.TabIndex = 0;
      this.radAll.TabStop = true;
      this.radAll.Text = "Все студенты";
      this.radAll.UseVisualStyleBackColor = true;
      this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
      // 
      // tabPage3
      // 
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(291, 444);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Дисцилины";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(364, 488);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(194, 33);
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "Выбрать";
      this.btnOk.UseVisualStyleBackColor = true;
      // 
      // frmStudents
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(670, 533);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmStudents";
      this.Text = "Студенты";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Button btnSelect;
    private System.Windows.Forms.ComboBox cmbCath;
    private System.Windows.Forms.ComboBox cmbFac;
    private System.Windows.Forms.ComboBox cmbGroup;
    private System.Windows.Forms.RadioButton radByGroup;
    private System.Windows.Forms.RadioButton radByCath;
    private System.Windows.Forms.RadioButton radByFac;
    private System.Windows.Forms.RadioButton radAll;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.TextBox edtPasNo;
    private System.Windows.Forms.TextBox edtRecordBook;
    private System.Windows.Forms.TextBox edtAge;
    private System.Windows.Forms.TextBox edtStartYear;
    private System.Windows.Forms.TextBox edtPhone;
    private System.Windows.Forms.TextBox edtAddress;
    private System.Windows.Forms.TextBox edtCourse;
    private System.Windows.Forms.TextBox edtGroup;
    private System.Windows.Forms.TextBox edtCathName;
    private System.Windows.Forms.TextBox edtFirstName;
    private System.Windows.Forms.TextBox edtThirdName;
    private System.Windows.Forms.TextBox edtFacName;
    private System.Windows.Forms.TextBox edtLastName;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tabPage3;
  }
}