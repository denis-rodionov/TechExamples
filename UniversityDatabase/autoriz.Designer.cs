namespace University
{
  partial class frmAutoriz
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
      this.btnGetIn = new System.Windows.Forms.Button();
      this.edtLogin = new System.Windows.Forms.TextBox();
      this.edtPas = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(125, 68);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(94, 27);
      this.btnClose.TabIndex = 3;
      this.btnClose.Text = "Выход";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnGetIn
      // 
      this.btnGetIn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnGetIn.Location = new System.Drawing.Point(12, 68);
      this.btnGetIn.Name = "btnGetIn";
      this.btnGetIn.Size = new System.Drawing.Size(94, 27);
      this.btnGetIn.TabIndex = 2;
      this.btnGetIn.Text = "Войти";
      this.btnGetIn.UseVisualStyleBackColor = true;
      this.btnGetIn.Click += new System.EventHandler(this.btnGetIn_Click);
      // 
      // edtLogin
      // 
      this.edtLogin.Location = new System.Drawing.Point(66, 12);
      this.edtLogin.Name = "edtLogin";
      this.edtLogin.Size = new System.Drawing.Size(152, 20);
      this.edtLogin.TabIndex = 0;
      // 
      // edtPas
      // 
      this.edtPas.Location = new System.Drawing.Point(66, 38);
      this.edtPas.Name = "edtPas";
      this.edtPas.PasswordChar = '*';
      this.edtPas.Size = new System.Drawing.Size(152, 20);
      this.edtPas.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Имя";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 43);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Пароль";
      // 
      // frmAutoriz
      // 
      this.AcceptButton = this.btnGetIn;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(231, 107);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.edtPas);
      this.Controls.Add(this.edtLogin);
      this.Controls.Add(this.btnGetIn);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "frmAutoriz";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Авторизация";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnGetIn;
    private System.Windows.Forms.TextBox edtLogin;
    private System.Windows.Forms.TextBox edtPas;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}