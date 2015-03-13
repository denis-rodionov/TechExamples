namespace University
{
  partial class frmGroupModify
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSelectTeach = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.chkSpec = new System.Windows.Forms.CheckBox();
      this.chkCurator = new System.Windows.Forms.CheckBox();
      this.edtIndex = new System.Windows.Forms.TextBox();
      this.numCourse = new System.Windows.Forms.NumericUpDown();
      this.cmbSpec = new System.Windows.Forms.ComboBox();
      this.edtCurator = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.numCourse)).BeginInit();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(305, 115);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(92, 30);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "button1";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(210, 115);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(89, 30);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Отмена";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnSelectTeach
      // 
      this.btnSelectTeach.Location = new System.Drawing.Point(15, 115);
      this.btnSelectTeach.Name = "btnSelectTeach";
      this.btnSelectTeach.Size = new System.Drawing.Size(189, 30);
      this.btnSelectTeach.TabIndex = 2;
      this.btnSelectTeach.Text = "Выбрать куратора";
      this.btnSelectTeach.UseVisualStyleBackColor = true;
      this.btnSelectTeach.Click += new System.EventHandler(this.btnSelectTeach_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Индекс:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 38);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(54, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Семестр:";
      // 
      // chkSpec
      // 
      this.chkSpec.AutoSize = true;
      this.chkSpec.Checked = true;
      this.chkSpec.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkSpec.Location = new System.Drawing.Point(15, 64);
      this.chkSpec.Name = "chkSpec";
      this.chkSpec.Size = new System.Drawing.Size(104, 17);
      this.chkSpec.TabIndex = 6;
      this.chkSpec.Text = "Специальность";
      this.chkSpec.UseVisualStyleBackColor = true;
      this.chkSpec.CheckedChanged += new System.EventHandler(this.chkSpec_CheckedChanged);
      // 
      // chkCurator
      // 
      this.chkCurator.AutoSize = true;
      this.chkCurator.Checked = true;
      this.chkCurator.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkCurator.Location = new System.Drawing.Point(15, 91);
      this.chkCurator.Name = "chkCurator";
      this.chkCurator.Size = new System.Drawing.Size(67, 17);
      this.chkCurator.TabIndex = 7;
      this.chkCurator.Text = "Куратор";
      this.chkCurator.UseVisualStyleBackColor = true;
      this.chkCurator.CheckedChanged += new System.EventHandler(this.chkCurator_CheckedChanged);
      // 
      // edtIndex
      // 
      this.edtIndex.Location = new System.Drawing.Point(149, 10);
      this.edtIndex.Name = "edtIndex";
      this.edtIndex.Size = new System.Drawing.Size(245, 20);
      this.edtIndex.TabIndex = 8;
      // 
      // numCourse
      // 
      this.numCourse.Location = new System.Drawing.Point(149, 36);
      this.numCourse.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numCourse.Name = "numCourse";
      this.numCourse.Size = new System.Drawing.Size(245, 20);
      this.numCourse.TabIndex = 9;
      this.numCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // cmbSpec
      // 
      this.cmbSpec.FormattingEnabled = true;
      this.cmbSpec.Location = new System.Drawing.Point(149, 62);
      this.cmbSpec.Name = "cmbSpec";
      this.cmbSpec.Size = new System.Drawing.Size(245, 21);
      this.cmbSpec.TabIndex = 10;
      // 
      // edtCurator
      // 
      this.edtCurator.Location = new System.Drawing.Point(150, 89);
      this.edtCurator.Name = "edtCurator";
      this.edtCurator.ReadOnly = true;
      this.edtCurator.Size = new System.Drawing.Size(244, 20);
      this.edtCurator.TabIndex = 11;
      this.edtCurator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // frmGroupModify
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(406, 152);
      this.Controls.Add(this.edtCurator);
      this.Controls.Add(this.cmbSpec);
      this.Controls.Add(this.numCourse);
      this.Controls.Add(this.edtIndex);
      this.Controls.Add(this.chkCurator);
      this.Controls.Add(this.chkSpec);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSelectTeach);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "frmGroupModify";
      this.Text = "GroupModify";
      ((System.ComponentModel.ISupportInitialize)(this.numCourse)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSelectTeach;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.CheckBox chkSpec;
    private System.Windows.Forms.CheckBox chkCurator;
    private System.Windows.Forms.TextBox edtIndex;
    private System.Windows.Forms.NumericUpDown numCourse;
    private System.Windows.Forms.ComboBox cmbSpec;
    private System.Windows.Forms.TextBox edtCurator;
  }
}