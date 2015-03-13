namespace University
{
  partial class frmStudModify
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
      this.edtLastName = new System.Windows.Forms.TextBox();
      this.edtAddress = new System.Windows.Forms.TextBox();
      this.edtPhone = new System.Windows.Forms.TextBox();
      this.edtStartYear = new System.Windows.Forms.TextBox();
      this.edtRecordBook = new System.Windows.Forms.TextBox();
      this.edtPasNO = new System.Windows.Forms.TextBox();
      this.edtThirdName = new System.Windows.Forms.TextBox();
      this.edtFirstName = new System.Windows.Forms.TextBox();
      this.numAge = new System.Windows.Forms.NumericUpDown();
      this.cmbGroup = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.chkGroup = new System.Windows.Forms.CheckBox();
      this.btnOk = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
      this.SuspendLayout();
      // 
      // edtLastName
      // 
      this.edtLastName.Location = new System.Drawing.Point(117, 14);
      this.edtLastName.Name = "edtLastName";
      this.edtLastName.Size = new System.Drawing.Size(219, 20);
      this.edtLastName.TabIndex = 0;
      // 
      // edtAddress
      // 
      this.edtAddress.Location = new System.Drawing.Point(117, 221);
      this.edtAddress.Multiline = true;
      this.edtAddress.Name = "edtAddress";
      this.edtAddress.Size = new System.Drawing.Size(219, 67);
      this.edtAddress.TabIndex = 8;
      // 
      // edtPhone
      // 
      this.edtPhone.Location = new System.Drawing.Point(117, 195);
      this.edtPhone.Name = "edtPhone";
      this.edtPhone.Size = new System.Drawing.Size(219, 20);
      this.edtPhone.TabIndex = 7;
      // 
      // edtStartYear
      // 
      this.edtStartYear.Location = new System.Drawing.Point(117, 169);
      this.edtStartYear.Name = "edtStartYear";
      this.edtStartYear.Size = new System.Drawing.Size(219, 20);
      this.edtStartYear.TabIndex = 6;
      // 
      // edtRecordBook
      // 
      this.edtRecordBook.Location = new System.Drawing.Point(117, 118);
      this.edtRecordBook.Name = "edtRecordBook";
      this.edtRecordBook.Size = new System.Drawing.Size(219, 20);
      this.edtRecordBook.TabIndex = 4;
      // 
      // edtPasNO
      // 
      this.edtPasNO.Location = new System.Drawing.Point(117, 92);
      this.edtPasNO.Name = "edtPasNO";
      this.edtPasNO.Size = new System.Drawing.Size(219, 20);
      this.edtPasNO.TabIndex = 3;
      // 
      // edtThirdName
      // 
      this.edtThirdName.Location = new System.Drawing.Point(117, 66);
      this.edtThirdName.Name = "edtThirdName";
      this.edtThirdName.Size = new System.Drawing.Size(219, 20);
      this.edtThirdName.TabIndex = 2;
      // 
      // edtFirstName
      // 
      this.edtFirstName.Location = new System.Drawing.Point(117, 40);
      this.edtFirstName.Name = "edtFirstName";
      this.edtFirstName.Size = new System.Drawing.Size(219, 20);
      this.edtFirstName.TabIndex = 1;
      // 
      // numAge
      // 
      this.numAge.Location = new System.Drawing.Point(117, 144);
      this.numAge.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numAge.Name = "numAge";
      this.numAge.Size = new System.Drawing.Size(219, 20);
      this.numAge.TabIndex = 5;
      // 
      // cmbGroup
      // 
      this.cmbGroup.FormattingEnabled = true;
      this.cmbGroup.Location = new System.Drawing.Point(117, 296);
      this.cmbGroup.Name = "cmbGroup";
      this.cmbGroup.Size = new System.Drawing.Size(221, 21);
      this.cmbGroup.TabIndex = 10;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Фамилия:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 95);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Паспорт:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 121);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(98, 13);
      this.label3.TabIndex = 13;
      this.label3.Text = "Зачётная книжка:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 146);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 13);
      this.label4.TabIndex = 14;
      this.label4.Text = "Возраст:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 172);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(95, 13);
      this.label5.TabIndex = 15;
      this.label5.Text = "Год поступления:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 198);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(55, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "Телефон:";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(12, 224);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(41, 13);
      this.label9.TabIndex = 19;
      this.label9.Text = "Адрес:";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(12, 69);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(57, 13);
      this.label10.TabIndex = 20;
      this.label10.Text = "Отчество:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(12, 43);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(32, 13);
      this.label11.TabIndex = 21;
      this.label11.Text = "Имя:";
      // 
      // chkGroup
      // 
      this.chkGroup.AutoSize = true;
      this.chkGroup.Checked = true;
      this.chkGroup.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkGroup.Location = new System.Drawing.Point(12, 298);
      this.chkGroup.Name = "chkGroup";
      this.chkGroup.Size = new System.Drawing.Size(64, 17);
      this.chkGroup.TabIndex = 22;
      this.chkGroup.Text = "Группа:";
      this.chkGroup.UseVisualStyleBackColor = true;
      this.chkGroup.CheckedChanged += new System.EventHandler(this.chkGroup_CheckedChanged);
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(178, 323);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(160, 28);
      this.btnOk.TabIndex = 11;
      this.btnOk.Text = "ОК";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(12, 323);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(160, 28);
      this.btnCancel.TabIndex = 12;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmStudModify
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(346, 361);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.chkGroup);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cmbGroup);
      this.Controls.Add(this.numAge);
      this.Controls.Add(this.edtFirstName);
      this.Controls.Add(this.edtThirdName);
      this.Controls.Add(this.edtPasNO);
      this.Controls.Add(this.edtRecordBook);
      this.Controls.Add(this.edtStartYear);
      this.Controls.Add(this.edtPhone);
      this.Controls.Add(this.edtAddress);
      this.Controls.Add(this.edtLastName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MinimizeBox = false;
      this.Name = "frmStudModify";
      this.Text = "StudModify";
      ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox edtLastName;
    private System.Windows.Forms.TextBox edtAddress;
    private System.Windows.Forms.TextBox edtPhone;
    private System.Windows.Forms.TextBox edtStartYear;
    private System.Windows.Forms.TextBox edtRecordBook;
    private System.Windows.Forms.TextBox edtPasNO;
    private System.Windows.Forms.TextBox edtThirdName;
    private System.Windows.Forms.TextBox edtFirstName;
    private System.Windows.Forms.NumericUpDown numAge;
    private System.Windows.Forms.ComboBox cmbGroup;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.CheckBox chkGroup;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCancel;
  }
}