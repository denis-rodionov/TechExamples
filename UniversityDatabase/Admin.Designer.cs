namespace University
{
  partial class frmAdmin
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
      this.lstUsers = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.edtLogin = new System.Windows.Forms.TextBox();
      this.edtPassword = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.chkAdmin = new System.Windows.Forms.CheckBox();
      this.chkFac = new System.Windows.Forms.CheckBox();
      this.chkCath = new System.Windows.Forms.CheckBox();
      this.chkTeach = new System.Windows.Forms.CheckBox();
      this.chkGroup = new System.Windows.Forms.CheckBox();
      this.chkStud = new System.Windows.Forms.CheckBox();
      this.chkSub = new System.Windows.Forms.CheckBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnModify = new System.Windows.Forms.Button();
      this.btnDel = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lstUsers
      // 
      this.lstUsers.FormattingEnabled = true;
      this.lstUsers.Location = new System.Drawing.Point(12, 25);
      this.lstUsers.Name = "lstUsers";
      this.lstUsers.Size = new System.Drawing.Size(129, 173);
      this.lstUsers.TabIndex = 0;
      this.lstUsers.Click += new System.EventHandler(this.lstUsers_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Пользователи";
      // 
      // edtLogin
      // 
      this.edtLogin.Location = new System.Drawing.Point(61, 13);
      this.edtLogin.Name = "edtLogin";
      this.edtLogin.Size = new System.Drawing.Size(148, 20);
      this.edtLogin.TabIndex = 2;
      // 
      // edtPassword
      // 
      this.edtPassword.Location = new System.Drawing.Point(61, 43);
      this.edtPassword.Name = "edtPassword";
      this.edtPassword.Size = new System.Drawing.Size(148, 20);
      this.edtPassword.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Имя";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 46);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(45, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Пароль";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.chkSub);
      this.groupBox1.Controls.Add(this.chkStud);
      this.groupBox1.Controls.Add(this.chkGroup);
      this.groupBox1.Controls.Add(this.chkTeach);
      this.groupBox1.Controls.Add(this.chkCath);
      this.groupBox1.Controls.Add(this.chkFac);
      this.groupBox1.Controls.Add(this.chkAdmin);
      this.groupBox1.Location = new System.Drawing.Point(147, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(203, 187);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Права";
      // 
      // chkAdmin
      // 
      this.chkAdmin.AutoSize = true;
      this.chkAdmin.Location = new System.Drawing.Point(6, 19);
      this.chkAdmin.Name = "chkAdmin";
      this.chkAdmin.Size = new System.Drawing.Size(105, 17);
      this.chkAdmin.TabIndex = 0;
      this.chkAdmin.Text = "Администратор";
      this.chkAdmin.UseVisualStyleBackColor = true;
      // 
      // chkFac
      // 
      this.chkFac.AutoSize = true;
      this.chkFac.Location = new System.Drawing.Point(6, 42);
      this.chkFac.Name = "chkFac";
      this.chkFac.Size = new System.Drawing.Size(165, 17);
      this.chkFac.TabIndex = 1;
      this.chkFac.Text = "Модификация факультетов";
      this.chkFac.UseVisualStyleBackColor = true;
      // 
      // chkCath
      // 
      this.chkCath.AutoSize = true;
      this.chkCath.Location = new System.Drawing.Point(6, 65);
      this.chkCath.Name = "chkCath";
      this.chkCath.Size = new System.Drawing.Size(138, 17);
      this.chkCath.TabIndex = 2;
      this.chkCath.Text = "Модификация кафедр";
      this.chkCath.UseVisualStyleBackColor = true;
      // 
      // chkTeach
      // 
      this.chkTeach.AutoSize = true;
      this.chkTeach.Location = new System.Drawing.Point(6, 88);
      this.chkTeach.Name = "chkTeach";
      this.chkTeach.Size = new System.Drawing.Size(183, 17);
      this.chkTeach.TabIndex = 3;
      this.chkTeach.Text = "Модификация преподавателей";
      this.chkTeach.UseVisualStyleBackColor = true;
      // 
      // chkGroup
      // 
      this.chkGroup.AutoSize = true;
      this.chkGroup.Location = new System.Drawing.Point(6, 111);
      this.chkGroup.Name = "chkGroup";
      this.chkGroup.Size = new System.Drawing.Size(128, 17);
      this.chkGroup.TabIndex = 4;
      this.chkGroup.Text = "Модификация групп";
      this.chkGroup.UseVisualStyleBackColor = true;
      // 
      // chkStud
      // 
      this.chkStud.AutoSize = true;
      this.chkStud.Location = new System.Drawing.Point(6, 134);
      this.chkStud.Name = "chkStud";
      this.chkStud.Size = new System.Drawing.Size(151, 17);
      this.chkStud.TabIndex = 5;
      this.chkStud.Text = "Модификация студентов";
      this.chkStud.UseVisualStyleBackColor = true;
      // 
      // chkSub
      // 
      this.chkSub.AutoSize = true;
      this.chkSub.Location = new System.Drawing.Point(6, 157);
      this.chkSub.Name = "chkSub";
      this.chkSub.Size = new System.Drawing.Size(154, 17);
      this.chkSub.TabIndex = 6;
      this.chkSub.Text = "Модификация дисциплин";
      this.chkSub.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.edtLogin);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.edtPassword);
      this.groupBox2.Location = new System.Drawing.Point(356, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(221, 82);
      this.groupBox2.TabIndex = 7;
      this.groupBox2.TabStop = false;
      // 
      // btnModify
      // 
      this.btnModify.Location = new System.Drawing.Point(356, 102);
      this.btnModify.Name = "btnModify";
      this.btnModify.Size = new System.Drawing.Size(109, 45);
      this.btnModify.TabIndex = 8;
      this.btnModify.Text = "Изменить";
      this.btnModify.UseVisualStyleBackColor = true;
      this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
      // 
      // btnDel
      // 
      this.btnDel.Location = new System.Drawing.Point(356, 153);
      this.btnDel.Name = "btnDel";
      this.btnDel.Size = new System.Drawing.Size(109, 45);
      this.btnDel.TabIndex = 9;
      this.btnDel.Text = "Удалить";
      this.btnDel.UseVisualStyleBackColor = true;
      this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(468, 102);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(109, 45);
      this.btnAdd.TabIndex = 10;
      this.btnAdd.Text = "Добавить";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(468, 153);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(109, 45);
      this.btnClose.TabIndex = 11;
      this.btnClose.Text = "Выход";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // frmAdmin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 210);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnDel);
      this.Controls.Add(this.btnModify);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lstUsers);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmAdmin";
      this.Text = "Администрирование";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lstUsers;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox edtLogin;
    private System.Windows.Forms.TextBox edtPassword;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox chkSub;
    private System.Windows.Forms.CheckBox chkStud;
    private System.Windows.Forms.CheckBox chkGroup;
    private System.Windows.Forms.CheckBox chkTeach;
    private System.Windows.Forms.CheckBox chkCath;
    private System.Windows.Forms.CheckBox chkFac;
    private System.Windows.Forms.CheckBox chkAdmin;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnModify;
    private System.Windows.Forms.Button btnDel;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnClose;
  }
}