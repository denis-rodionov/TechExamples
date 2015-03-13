namespace University
{
  partial class frmMain
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
        this.btnFaculties = new System.Windows.Forms.Button();
        this.btnShowCaths = new System.Windows.Forms.Button();
        this.btnTeachers = new System.Windows.Forms.Button();
        this.btnGroups = new System.Windows.Forms.Button();
        this.btnStudents = new System.Windows.Forms.Button();
        this.btnSubjects = new System.Windows.Forms.Button();
        this.frmAdmin = new System.Windows.Forms.Button();
        this.btnNewTerm = new System.Windows.Forms.Button();
        this.imgHeader = new System.Windows.Forms.PictureBox();
        this.frmTimetable = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).BeginInit();
        this.SuspendLayout();
        // 
        // btnClose
        // 
        this.btnClose.Location = new System.Drawing.Point(306, 246);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(194, 38);
        this.btnClose.TabIndex = 0;
        this.btnClose.Text = "Выход";
        this.btnClose.UseVisualStyleBackColor = true;
        this.btnClose.Click += new System.EventHandler(this.button1_Click);
        // 
        // btnFaculties
        // 
        this.btnFaculties.Location = new System.Drawing.Point(0, 202);
        this.btnFaculties.Name = "btnFaculties";
        this.btnFaculties.Size = new System.Drawing.Size(96, 38);
        this.btnFaculties.TabIndex = 1;
        this.btnFaculties.Text = "Факультеты";
        this.btnFaculties.UseVisualStyleBackColor = true;
        this.btnFaculties.Click += new System.EventHandler(this.btnFaculties_Click);
        // 
        // btnShowCaths
        // 
        this.btnShowCaths.Location = new System.Drawing.Point(204, 158);
        this.btnShowCaths.Name = "btnShowCaths";
        this.btnShowCaths.Size = new System.Drawing.Size(96, 38);
        this.btnShowCaths.TabIndex = 2;
        this.btnShowCaths.Text = "Кафедры";
        this.btnShowCaths.UseVisualStyleBackColor = true;
        this.btnShowCaths.Click += new System.EventHandler(this.btnShowCaths_Click);
        // 
        // btnTeachers
        // 
        this.btnTeachers.Location = new System.Drawing.Point(0, 158);
        this.btnTeachers.Name = "btnTeachers";
        this.btnTeachers.Size = new System.Drawing.Size(96, 38);
        this.btnTeachers.TabIndex = 3;
        this.btnTeachers.Text = "Преподаватели";
        this.btnTeachers.UseVisualStyleBackColor = true;
        this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
        // 
        // btnGroups
        // 
        this.btnGroups.Location = new System.Drawing.Point(102, 202);
        this.btnGroups.Name = "btnGroups";
        this.btnGroups.Size = new System.Drawing.Size(96, 38);
        this.btnGroups.TabIndex = 4;
        this.btnGroups.Text = "Группы";
        this.btnGroups.UseVisualStyleBackColor = true;
        this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
        // 
        // btnStudents
        // 
        this.btnStudents.Location = new System.Drawing.Point(102, 158);
        this.btnStudents.Name = "btnStudents";
        this.btnStudents.Size = new System.Drawing.Size(96, 38);
        this.btnStudents.TabIndex = 5;
        this.btnStudents.Text = "Студенты";
        this.btnStudents.UseVisualStyleBackColor = true;
        this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
        // 
        // btnSubjects
        // 
        this.btnSubjects.Location = new System.Drawing.Point(204, 202);
        this.btnSubjects.Name = "btnSubjects";
        this.btnSubjects.Size = new System.Drawing.Size(96, 38);
        this.btnSubjects.TabIndex = 6;
        this.btnSubjects.Text = "Дисциплины";
        this.btnSubjects.UseVisualStyleBackColor = true;
        this.btnSubjects.Click += new System.EventHandler(this.btnSubjects_Click);
        // 
        // frmAdmin
        // 
        this.frmAdmin.Location = new System.Drawing.Point(306, 158);
        this.frmAdmin.Name = "frmAdmin";
        this.frmAdmin.Size = new System.Drawing.Size(194, 38);
        this.frmAdmin.TabIndex = 8;
        this.frmAdmin.Text = "Администрирование";
        this.frmAdmin.UseVisualStyleBackColor = true;
        this.frmAdmin.Click += new System.EventHandler(this.frmAdmin_Click);
        // 
        // btnNewTerm
        // 
        this.btnNewTerm.Location = new System.Drawing.Point(0, 246);
        this.btnNewTerm.Name = "btnNewTerm";
        this.btnNewTerm.Size = new System.Drawing.Size(300, 37);
        this.btnNewTerm.TabIndex = 9;
        this.btnNewTerm.Text = "Новый семестр обучения";
        this.btnNewTerm.UseVisualStyleBackColor = true;
        this.btnNewTerm.Click += new System.EventHandler(this.btnNewTerm_Click);
        // 
        // imgHeader
        // 
        this.imgHeader.Image = global::University.Properties.Resources._2_0;
        this.imgHeader.Location = new System.Drawing.Point(0, 2);
        this.imgHeader.Name = "imgHeader";
        this.imgHeader.Size = new System.Drawing.Size(500, 150);
        this.imgHeader.TabIndex = 7;
        this.imgHeader.TabStop = false;
        // 
        // frmTimetable
        // 
        this.frmTimetable.Location = new System.Drawing.Point(306, 202);
        this.frmTimetable.Name = "frmTimetable";
        this.frmTimetable.Size = new System.Drawing.Size(194, 38);
        this.frmTimetable.TabIndex = 10;
        this.frmTimetable.Text = "Расписание";
        this.frmTimetable.UseVisualStyleBackColor = true;
        this.frmTimetable.Click += new System.EventHandler(this.button1_Click_1);
        // 
        // frmMain
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(501, 289);
        this.Controls.Add(this.frmTimetable);
        this.Controls.Add(this.btnNewTerm);
        this.Controls.Add(this.frmAdmin);
        this.Controls.Add(this.imgHeader);
        this.Controls.Add(this.btnSubjects);
        this.Controls.Add(this.btnStudents);
        this.Controls.Add(this.btnGroups);
        this.Controls.Add(this.btnTeachers);
        this.Controls.Add(this.btnShowCaths);
        this.Controls.Add(this.btnFaculties);
        this.Controls.Add(this.btnClose);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "frmMain";
        this.Text = "Университет 1.0";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnFaculties;
    private System.Windows.Forms.Button btnShowCaths;
    private System.Windows.Forms.Button btnTeachers;
    private System.Windows.Forms.Button btnGroups;
    private System.Windows.Forms.Button btnStudents;
    private System.Windows.Forms.Button btnSubjects;
    private System.Windows.Forms.PictureBox imgHeader;
    private System.Windows.Forms.Button frmAdmin;
    private System.Windows.Forms.Button btnNewTerm;
    private System.Windows.Forms.Button frmTimetable;
  }
}

