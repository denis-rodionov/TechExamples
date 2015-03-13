namespace University
{
  partial class frmCathedras
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
        this.cmbFaculties = new System.Windows.Forms.ComboBox();
        this.label1 = new System.Windows.Forms.Label();
        this.btnClose = new System.Windows.Forms.Button();
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tabPage1 = new System.Windows.Forms.TabPage();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnAdd = new System.Windows.Forms.Button();
        this.label5 = new System.Windows.Forms.Label();
        this.btnModify = new System.Windows.Forms.Button();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.edtHead = new System.Windows.Forms.TextBox();
        this.edtFac = new System.Windows.Forms.TextBox();
        this.edtDesc = new System.Windows.Forms.TextBox();
        this.edtIndex = new System.Windows.Forms.TextBox();
        this.edtName = new System.Windows.Forms.TextBox();
        this.tabPage2 = new System.Windows.Forms.TabPage();
        this.radByFac = new System.Windows.Forms.RadioButton();
        this.radSelectAll = new System.Windows.Forms.RadioButton();
        this.btnShow = new System.Windows.Forms.Button();
        this.tabPage3 = new System.Windows.Forms.TabPage();
        this.btnDelSubject = new System.Windows.Forms.Button();
        this.btnAddSubject = new System.Windows.Forms.Button();
        this.tabControl1.SuspendLayout();
        this.tabPage1.SuspendLayout();
        this.tabPage2.SuspendLayout();
        this.tabPage3.SuspendLayout();
        this.SuspendLayout();
        // 
        // cmbFaculties
        // 
        this.cmbFaculties.Enabled = false;
        this.cmbFaculties.FormattingEnabled = true;
        this.cmbFaculties.Location = new System.Drawing.Point(6, 77);
        this.cmbFaculties.Name = "cmbFaculties";
        this.cmbFaculties.Size = new System.Drawing.Size(198, 21);
        this.cmbFaculties.TabIndex = 1;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(3, 61);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(105, 13);
        this.label1.TabIndex = 2;
        this.label1.Text = "Критерий выборки:";
        // 
        // btnClose
        // 
        this.btnClose.Location = new System.Drawing.Point(561, 369);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(81, 35);
        this.btnClose.TabIndex = 3;
        this.btnClose.Text = "Закрыть";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tabPage1);
        this.tabControl1.Controls.Add(this.tabPage2);
        this.tabControl1.Controls.Add(this.tabPage3);
        this.tabControl1.Location = new System.Drawing.Point(318, 6);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(324, 357);
        this.tabControl1.TabIndex = 6;
        // 
        // tabPage1
        // 
        this.tabPage1.Controls.Add(this.btnDelete);
        this.tabPage1.Controls.Add(this.btnAdd);
        this.tabPage1.Controls.Add(this.label5);
        this.tabPage1.Controls.Add(this.btnModify);
        this.tabPage1.Controls.Add(this.label4);
        this.tabPage1.Controls.Add(this.label3);
        this.tabPage1.Controls.Add(this.label2);
        this.tabPage1.Controls.Add(this.edtHead);
        this.tabPage1.Controls.Add(this.edtFac);
        this.tabPage1.Controls.Add(this.edtDesc);
        this.tabPage1.Controls.Add(this.edtIndex);
        this.tabPage1.Controls.Add(this.edtName);
        this.tabPage1.Location = new System.Drawing.Point(4, 22);
        this.tabPage1.Name = "tabPage1";
        this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage1.Size = new System.Drawing.Size(316, 331);
        this.tabPage1.TabIndex = 0;
        this.tabPage1.Text = "Общие";
        this.tabPage1.UseVisualStyleBackColor = true;
        // 
        // btnDelete
        // 
        this.btnDelete.Location = new System.Drawing.Point(229, 293);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(81, 35);
        this.btnDelete.TabIndex = 9;
        this.btnDelete.Text = "Удалить";
        this.btnDelete.UseVisualStyleBackColor = true;
        this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
        // 
        // btnAdd
        // 
        this.btnAdd.Location = new System.Drawing.Point(6, 293);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(81, 35);
        this.btnAdd.TabIndex = 8;
        this.btnAdd.Text = "Добавить";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(6, 239);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(75, 13);
        this.label5.TabIndex = 8;
        this.label5.Text = "Заведующий:";
        // 
        // btnModify
        // 
        this.btnModify.Location = new System.Drawing.Point(120, 293);
        this.btnModify.Name = "btnModify";
        this.btnModify.Size = new System.Drawing.Size(81, 35);
        this.btnModify.TabIndex = 7;
        this.btnModify.Text = "Изменить";
        this.btnModify.UseVisualStyleBackColor = true;
        this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(6, 97);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(113, 13);
        this.label4.TabIndex = 7;
        this.label4.Text = "Сфера деятельности";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(6, 192);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(66, 13);
        this.label3.TabIndex = 6;
        this.label3.Text = "Факультет:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(6, 71);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(48, 13);
        this.label2.TabIndex = 5;
        this.label2.Text = "Индекс:";
        // 
        // edtHead
        // 
        this.edtHead.BackColor = System.Drawing.SystemColors.Window;
        this.edtHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.edtHead.Location = new System.Drawing.Point(120, 237);
        this.edtHead.Multiline = true;
        this.edtHead.Name = "edtHead";
        this.edtHead.ReadOnly = true;
        this.edtHead.Size = new System.Drawing.Size(190, 20);
        this.edtHead.TabIndex = 4;
        // 
        // edtFac
        // 
        this.edtFac.BackColor = System.Drawing.SystemColors.Window;
        this.edtFac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.edtFac.Location = new System.Drawing.Point(120, 190);
        this.edtFac.Multiline = true;
        this.edtFac.Name = "edtFac";
        this.edtFac.ReadOnly = true;
        this.edtFac.Size = new System.Drawing.Size(190, 20);
        this.edtFac.TabIndex = 3;
        // 
        // edtDesc
        // 
        this.edtDesc.BackColor = System.Drawing.SystemColors.Window;
        this.edtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.edtDesc.Location = new System.Drawing.Point(120, 95);
        this.edtDesc.Multiline = true;
        this.edtDesc.Name = "edtDesc";
        this.edtDesc.ReadOnly = true;
        this.edtDesc.Size = new System.Drawing.Size(190, 74);
        this.edtDesc.TabIndex = 2;
        // 
        // edtIndex
        // 
        this.edtIndex.BackColor = System.Drawing.SystemColors.Window;
        this.edtIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.edtIndex.Location = new System.Drawing.Point(120, 69);
        this.edtIndex.Name = "edtIndex";
        this.edtIndex.ReadOnly = true;
        this.edtIndex.Size = new System.Drawing.Size(190, 20);
        this.edtIndex.TabIndex = 1;
        // 
        // edtName
        // 
        this.edtName.BackColor = System.Drawing.Color.White;
        this.edtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.edtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.edtName.Location = new System.Drawing.Point(6, 20);
        this.edtName.Name = "edtName";
        this.edtName.ReadOnly = true;
        this.edtName.Size = new System.Drawing.Size(304, 22);
        this.edtName.TabIndex = 0;
        this.edtName.Text = "---";
        this.edtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // tabPage2
        // 
        this.tabPage2.Controls.Add(this.radByFac);
        this.tabPage2.Controls.Add(this.radSelectAll);
        this.tabPage2.Controls.Add(this.btnShow);
        this.tabPage2.Controls.Add(this.cmbFaculties);
        this.tabPage2.Controls.Add(this.label1);
        this.tabPage2.Location = new System.Drawing.Point(4, 22);
        this.tabPage2.Name = "tabPage2";
        this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        this.tabPage2.Size = new System.Drawing.Size(316, 331);
        this.tabPage2.TabIndex = 1;
        this.tabPage2.Text = "Выборка";
        this.tabPage2.UseVisualStyleBackColor = true;
        // 
        // radByFac
        // 
        this.radByFac.AutoSize = true;
        this.radByFac.Location = new System.Drawing.Point(6, 29);
        this.radByFac.Name = "radByFac";
        this.radByFac.Size = new System.Drawing.Size(100, 17);
        this.radByFac.TabIndex = 9;
        this.radByFac.Text = "По факультету";
        this.radByFac.UseVisualStyleBackColor = true;
        this.radByFac.CheckedChanged += new System.EventHandler(this.radByFac_CheckedChanged);
        // 
        // radSelectAll
        // 
        this.radSelectAll.AutoSize = true;
        this.radSelectAll.Checked = true;
        this.radSelectAll.Location = new System.Drawing.Point(6, 6);
        this.radSelectAll.Name = "radSelectAll";
        this.radSelectAll.Size = new System.Drawing.Size(93, 17);
        this.radSelectAll.TabIndex = 6;
        this.radSelectAll.TabStop = true;
        this.radSelectAll.Text = "Все кафедры";
        this.radSelectAll.UseVisualStyleBackColor = true;
        this.radSelectAll.CheckedChanged += new System.EventHandler(this.radSelectAll_CheckedChanged);
        // 
        // btnShow
        // 
        this.btnShow.Location = new System.Drawing.Point(210, 71);
        this.btnShow.Name = "btnShow";
        this.btnShow.Size = new System.Drawing.Size(81, 30);
        this.btnShow.TabIndex = 5;
        this.btnShow.Text = "Показать";
        this.btnShow.UseVisualStyleBackColor = true;
        this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
        // 
        // tabPage3
        // 
        this.tabPage3.Controls.Add(this.btnDelSubject);
        this.tabPage3.Controls.Add(this.btnAddSubject);
        this.tabPage3.Location = new System.Drawing.Point(4, 22);
        this.tabPage3.Name = "tabPage3";
        this.tabPage3.Size = new System.Drawing.Size(316, 331);
        this.tabPage3.TabIndex = 2;
        this.tabPage3.Text = "Дисциплины";
        this.tabPage3.UseVisualStyleBackColor = true;
        // 
        // btnDelSubject
        // 
        this.btnDelSubject.Location = new System.Drawing.Point(160, 296);
        this.btnDelSubject.Name = "btnDelSubject";
        this.btnDelSubject.Size = new System.Drawing.Size(153, 32);
        this.btnDelSubject.TabIndex = 1;
        this.btnDelSubject.Text = "Удалить";
        this.btnDelSubject.UseVisualStyleBackColor = true;
        this.btnDelSubject.Click += new System.EventHandler(this.btnDelSubject_Click);
        // 
        // btnAddSubject
        // 
        this.btnAddSubject.Location = new System.Drawing.Point(3, 296);
        this.btnAddSubject.Name = "btnAddSubject";
        this.btnAddSubject.Size = new System.Drawing.Size(153, 32);
        this.btnAddSubject.TabIndex = 0;
        this.btnAddSubject.Text = "Добавить";
        this.btnAddSubject.UseVisualStyleBackColor = true;
        this.btnAddSubject.Click += new System.EventHandler(this.button1_Click);
        // 
        // frmCathedras
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(654, 409);
        this.Controls.Add(this.tabControl1);
        this.Controls.Add(this.btnClose);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Name = "frmCathedras";
        this.Text = "Кафедры";
        this.Load += new System.EventHandler(this.frmCathedras_Load);
        this.tabControl1.ResumeLayout(false);
        this.tabPage1.ResumeLayout(false);
        this.tabPage1.PerformLayout();
        this.tabPage2.ResumeLayout(false);
        this.tabPage2.PerformLayout();
        this.tabPage3.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cmbFaculties;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.RadioButton radByFac;
    private System.Windows.Forms.RadioButton radSelectAll;
    private System.Windows.Forms.Button btnShow;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox edtHead;
    private System.Windows.Forms.TextBox edtFac;
    private System.Windows.Forms.TextBox edtDesc;
    private System.Windows.Forms.TextBox edtIndex;
    private System.Windows.Forms.TextBox edtName;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.Button btnDelSubject;
    private System.Windows.Forms.Button btnAddSubject;
    private System.Windows.Forms.Label label4;
  }
}