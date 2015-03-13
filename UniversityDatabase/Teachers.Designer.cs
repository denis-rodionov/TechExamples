namespace University
{
  partial class frmTeachers
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
        this.cmbCriter = new System.Windows.Forms.ComboBox();
        this.tabCont = new System.Windows.Forms.TabControl();
        this.tabInfo = new System.Windows.Forms.TabPage();
        this.edtRank = new System.Windows.Forms.Label();
        this.edtPost = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.btnDel = new System.Windows.Forms.Button();
        this.btnAdd = new System.Windows.Forms.Button();
        this.lblAge = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.btnModify = new System.Windows.Forms.Button();
        this.edtAddress = new System.Windows.Forms.TextBox();
        this.lblCath = new System.Windows.Forms.Label();
        this.label13 = new System.Windows.Forms.Label();
        this.lblPhone = new System.Windows.Forms.Label();
        this.label11 = new System.Windows.Forms.Label();
        this.label9 = new System.Windows.Forms.Label();
        this.lblPasNo = new System.Windows.Forms.Label();
        this.label7 = new System.Windows.Forms.Label();
        this.lblDegree = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.lblThirdName = new System.Windows.Forms.Label();
        this.lblFirstName = new System.Windows.Forms.Label();
        this.lblLastName = new System.Windows.Forms.Label();
        this.tabSelect = new System.Windows.Forms.TabPage();
        this.radAll = new System.Windows.Forms.RadioButton();
        this.btnSelect = new System.Windows.Forms.Button();
        this.label1 = new System.Windows.Forms.Label();
        this.radSubj = new System.Windows.Forms.RadioButton();
        this.radFac = new System.Windows.Forms.RadioButton();
        this.radCath = new System.Windows.Forms.RadioButton();
        this.btnOk = new System.Windows.Forms.Button();
        this.tabCont.SuspendLayout();
        this.tabInfo.SuspendLayout();
        this.tabSelect.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnClose
        // 
        this.btnClose.Location = new System.Drawing.Point(536, 339);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(136, 37);
        this.btnClose.TabIndex = 0;
        this.btnClose.Text = "Закрыть";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // cmbCriter
        // 
        this.cmbCriter.Enabled = false;
        this.cmbCriter.FormattingEnabled = true;
        this.cmbCriter.Location = new System.Drawing.Point(17, 147);
        this.cmbCriter.Name = "cmbCriter";
        this.cmbCriter.Size = new System.Drawing.Size(233, 21);
        this.cmbCriter.TabIndex = 1;
        this.cmbCriter.SelectedIndexChanged += new System.EventHandler(this.cmbCath_SelectedIndexChanged);
        // 
        // tabCont
        // 
        this.tabCont.Controls.Add(this.tabInfo);
        this.tabCont.Controls.Add(this.tabSelect);
        this.tabCont.Location = new System.Drawing.Point(350, 3);
        this.tabCont.Name = "tabCont";
        this.tabCont.SelectedIndex = 0;
        this.tabCont.Size = new System.Drawing.Size(326, 330);
        this.tabCont.TabIndex = 2;
        // 
        // tabInfo
        // 
        this.tabInfo.Controls.Add(this.edtRank);
        this.tabInfo.Controls.Add(this.edtPost);
        this.tabInfo.Controls.Add(this.label4);
        this.tabInfo.Controls.Add(this.label3);
        this.tabInfo.Controls.Add(this.btnDel);
        this.tabInfo.Controls.Add(this.btnAdd);
        this.tabInfo.Controls.Add(this.lblAge);
        this.tabInfo.Controls.Add(this.label2);
        this.tabInfo.Controls.Add(this.btnModify);
        this.tabInfo.Controls.Add(this.edtAddress);
        this.tabInfo.Controls.Add(this.lblCath);
        this.tabInfo.Controls.Add(this.label13);
        this.tabInfo.Controls.Add(this.lblPhone);
        this.tabInfo.Controls.Add(this.label11);
        this.tabInfo.Controls.Add(this.label9);
        this.tabInfo.Controls.Add(this.lblPasNo);
        this.tabInfo.Controls.Add(this.label7);
        this.tabInfo.Controls.Add(this.lblDegree);
        this.tabInfo.Controls.Add(this.label5);
        this.tabInfo.Controls.Add(this.lblThirdName);
        this.tabInfo.Controls.Add(this.lblFirstName);
        this.tabInfo.Controls.Add(this.lblLastName);
        this.tabInfo.Location = new System.Drawing.Point(4, 22);
        this.tabInfo.Name = "tabInfo";
        this.tabInfo.Padding = new System.Windows.Forms.Padding(3);
        this.tabInfo.Size = new System.Drawing.Size(318, 304);
        this.tabInfo.TabIndex = 0;
        this.tabInfo.Text = "Информация";
        this.tabInfo.UseVisualStyleBackColor = true;
        this.tabInfo.Click += new System.EventHandler(this.tabInfo_Click);
        // 
        // edtRank
        // 
        this.edtRank.Location = new System.Drawing.Point(99, 108);
        this.edtRank.Name = "edtRank";
        this.edtRank.Size = new System.Drawing.Size(180, 15);
        this.edtRank.TabIndex = 22;
        this.edtRank.Text = "***";
        // 
        // edtPost
        // 
        this.edtPost.Location = new System.Drawing.Point(99, 95);
        this.edtPost.Name = "edtPost";
        this.edtPost.Size = new System.Drawing.Size(180, 15);
        this.edtPost.TabIndex = 21;
        this.edtPost.Text = "***";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(3, 108);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(91, 13);
        this.label4.TabIndex = 20;
        this.label4.Text = "Научное звание:";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(3, 95);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(68, 13);
        this.label3.TabIndex = 19;
        this.label3.Text = "Должность:";
        // 
        // btnDel
        // 
        this.btnDel.Location = new System.Drawing.Point(204, 271);
        this.btnDel.Name = "btnDel";
        this.btnDel.Size = new System.Drawing.Size(75, 29);
        this.btnDel.TabIndex = 18;
        this.btnDel.Text = "Удалить";
        this.btnDel.UseVisualStyleBackColor = true;
        this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
        // 
        // btnAdd
        // 
        this.btnAdd.Location = new System.Drawing.Point(3, 271);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(75, 29);
        this.btnAdd.TabIndex = 17;
        this.btnAdd.Text = "Добавить";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // lblAge
        // 
        this.lblAge.Location = new System.Drawing.Point(99, 69);
        this.lblAge.Name = "lblAge";
        this.lblAge.Size = new System.Drawing.Size(77, 13);
        this.lblAge.TabIndex = 16;
        this.lblAge.Text = "***";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(3, 69);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(49, 13);
        this.label2.TabIndex = 15;
        this.label2.Text = "Возраст";
        // 
        // btnModify
        // 
        this.btnModify.Location = new System.Drawing.Point(103, 271);
        this.btnModify.Name = "btnModify";
        this.btnModify.Size = new System.Drawing.Size(75, 29);
        this.btnModify.TabIndex = 14;
        this.btnModify.Text = "Изменить";
        this.btnModify.UseVisualStyleBackColor = true;
        this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
        // 
        // edtAddress
        // 
        this.edtAddress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        this.edtAddress.Location = new System.Drawing.Point(103, 180);
        this.edtAddress.Multiline = true;
        this.edtAddress.Name = "edtAddress";
        this.edtAddress.ReadOnly = true;
        this.edtAddress.Size = new System.Drawing.Size(177, 44);
        this.edtAddress.TabIndex = 13;
        // 
        // lblCath
        // 
        this.lblCath.Location = new System.Drawing.Point(100, 248);
        this.lblCath.Name = "lblCath";
        this.lblCath.Size = new System.Drawing.Size(180, 13);
        this.lblCath.TabIndex = 12;
        this.lblCath.Text = "***";
        // 
        // label13
        // 
        this.label13.AutoSize = true;
        this.label13.Location = new System.Drawing.Point(3, 248);
        this.label13.Name = "label13";
        this.label13.Size = new System.Drawing.Size(55, 13);
        this.label13.TabIndex = 11;
        this.label13.Text = "Кафедра:";
        // 
        // lblPhone
        // 
        this.lblPhone.Location = new System.Drawing.Point(100, 235);
        this.lblPhone.Name = "lblPhone";
        this.lblPhone.Size = new System.Drawing.Size(180, 13);
        this.lblPhone.TabIndex = 10;
        this.lblPhone.Text = "***";
        // 
        // label11
        // 
        this.label11.AutoSize = true;
        this.label11.Location = new System.Drawing.Point(3, 235);
        this.label11.Name = "label11";
        this.label11.Size = new System.Drawing.Size(55, 13);
        this.label11.TabIndex = 9;
        this.label11.Text = "Телефон:";
        // 
        // label9
        // 
        this.label9.AutoSize = true;
        this.label9.Location = new System.Drawing.Point(3, 177);
        this.label9.Name = "label9";
        this.label9.Size = new System.Drawing.Size(41, 13);
        this.label9.TabIndex = 7;
        this.label9.Text = "Адрес:";
        this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // lblPasNo
        // 
        this.lblPasNo.Location = new System.Drawing.Point(100, 164);
        this.lblPasNo.Name = "lblPasNo";
        this.lblPasNo.Size = new System.Drawing.Size(180, 13);
        this.lblPasNo.TabIndex = 6;
        this.lblPasNo.Text = "***";
        // 
        // label7
        // 
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(3, 164);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(91, 13);
        this.label7.TabIndex = 5;
        this.label7.Text = "Номер паспорта";
        // 
        // lblDegree
        // 
        this.lblDegree.Location = new System.Drawing.Point(99, 82);
        this.lblDegree.Name = "lblDegree";
        this.lblDegree.Size = new System.Drawing.Size(213, 15);
        this.lblDegree.TabIndex = 4;
        this.lblDegree.Text = "***";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(3, 82);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(91, 13);
        this.label5.TabIndex = 3;
        this.label5.Text = "Учёная степень:";
        // 
        // lblThirdName
        // 
        this.lblThirdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lblThirdName.Location = new System.Drawing.Point(147, 39);
        this.lblThirdName.Name = "lblThirdName";
        this.lblThirdName.Size = new System.Drawing.Size(133, 21);
        this.lblThirdName.TabIndex = 2;
        this.lblThirdName.Text = "***";
        // 
        // lblFirstName
        // 
        this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lblFirstName.Location = new System.Drawing.Point(3, 39);
        this.lblFirstName.Name = "lblFirstName";
        this.lblFirstName.Size = new System.Drawing.Size(121, 21);
        this.lblFirstName.TabIndex = 1;
        this.lblFirstName.Text = "***";
        // 
        // lblLastName
        // 
        this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.lblLastName.Location = new System.Drawing.Point(6, 14);
        this.lblLastName.Name = "lblLastName";
        this.lblLastName.Size = new System.Drawing.Size(274, 25);
        this.lblLastName.TabIndex = 0;
        this.lblLastName.Text = "***";
        this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // tabSelect
        // 
        this.tabSelect.Controls.Add(this.radAll);
        this.tabSelect.Controls.Add(this.btnSelect);
        this.tabSelect.Controls.Add(this.label1);
        this.tabSelect.Controls.Add(this.radSubj);
        this.tabSelect.Controls.Add(this.radFac);
        this.tabSelect.Controls.Add(this.radCath);
        this.tabSelect.Controls.Add(this.cmbCriter);
        this.tabSelect.Location = new System.Drawing.Point(4, 22);
        this.tabSelect.Name = "tabSelect";
        this.tabSelect.Padding = new System.Windows.Forms.Padding(3);
        this.tabSelect.Size = new System.Drawing.Size(288, 304);
        this.tabSelect.TabIndex = 1;
        this.tabSelect.Text = "Выборка";
        this.tabSelect.UseVisualStyleBackColor = true;
        // 
        // radAll
        // 
        this.radAll.AutoSize = true;
        this.radAll.Checked = true;
        this.radAll.Location = new System.Drawing.Point(17, 8);
        this.radAll.Name = "radAll";
        this.radAll.Size = new System.Drawing.Size(123, 17);
        this.radAll.TabIndex = 7;
        this.radAll.TabStop = true;
        this.radAll.Text = "все преподаватели";
        this.radAll.UseVisualStyleBackColor = true;
        this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
        // 
        // btnSelect
        // 
        this.btnSelect.Location = new System.Drawing.Point(17, 174);
        this.btnSelect.Name = "btnSelect";
        this.btnSelect.Size = new System.Drawing.Size(132, 28);
        this.btnSelect.TabIndex = 6;
        this.btnSelect.Text = "Выбрать";
        this.btnSelect.UseVisualStyleBackColor = true;
        this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(14, 131);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(102, 13);
        this.label1.TabIndex = 5;
        this.label1.Text = "Критерий выборки";
        // 
        // radSubj
        // 
        this.radSubj.AutoSize = true;
        this.radSubj.Enabled = false;
        this.radSubj.Location = new System.Drawing.Point(17, 77);
        this.radSubj.Name = "radSubj";
        this.radSubj.Size = new System.Drawing.Size(108, 17);
        this.radSubj.TabIndex = 4;
        this.radSubj.Text = "по дисциплинам";
        this.radSubj.UseVisualStyleBackColor = true;
        // 
        // radFac
        // 
        this.radFac.AutoSize = true;
        this.radFac.Location = new System.Drawing.Point(17, 54);
        this.radFac.Name = "radFac";
        this.radFac.Size = new System.Drawing.Size(107, 17);
        this.radFac.TabIndex = 3;
        this.radFac.Text = "по факультетам";
        this.radFac.UseVisualStyleBackColor = true;
        this.radFac.CheckedChanged += new System.EventHandler(this.radFac_CheckedChanged);
        // 
        // radCath
        // 
        this.radCath.AutoSize = true;
        this.radCath.Location = new System.Drawing.Point(17, 31);
        this.radCath.Name = "radCath";
        this.radCath.Size = new System.Drawing.Size(92, 17);
        this.radCath.TabIndex = 2;
        this.radCath.Text = "по кафедрам";
        this.radCath.UseVisualStyleBackColor = true;
        this.radCath.CheckedChanged += new System.EventHandler(this.radSelect_CheckedChanged);
        // 
        // btnOk
        // 
        this.btnOk.Location = new System.Drawing.Point(350, 339);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(180, 37);
        this.btnOk.TabIndex = 3;
        this.btnOk.Text = "Выбрать";
        this.btnOk.UseVisualStyleBackColor = true;
        this.btnOk.Visible = false;
        this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
        // 
        // frmTeachers
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(678, 377);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.tabCont);
        this.Controls.Add(this.btnClose);
        this.Name = "frmTeachers";
        this.Text = "Преподаватели";
        this.Load += new System.EventHandler(this.frmTeachers_Load_1);
        this.tabCont.ResumeLayout(false);
        this.tabInfo.ResumeLayout(false);
        this.tabInfo.PerformLayout();
        this.tabSelect.ResumeLayout(false);
        this.tabSelect.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.ComboBox cmbCriter;
    private System.Windows.Forms.TabControl tabCont;
    private System.Windows.Forms.TabPage tabInfo;
    private System.Windows.Forms.TabPage tabSelect;
    private System.Windows.Forms.RadioButton radSubj;
    private System.Windows.Forms.RadioButton radFac;
    private System.Windows.Forms.RadioButton radCath;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSelect;
    private System.Windows.Forms.RadioButton radAll;
    private System.Windows.Forms.TextBox edtAddress;
    private System.Windows.Forms.Label lblCath;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label lblPasNo;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label lblDegree;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblThirdName;
    private System.Windows.Forms.Label lblFirstName;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Label lblAge;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnDel;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Label edtRank;
    private System.Windows.Forms.Label edtPost;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
  }
}