using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmMain : Form
  {
    private Security secur;       // текущий уровень безопасности

    public frmMain(Security sec)
    {
      InitializeComponent();
      this.secur = sec;
      initSecurity();
    }

    // настройки безопасности
    private void initSecurity()
    {
      if (!secur.isAdmin)      
        frmAdmin.Enabled = false;
      if (!secur.groupModify)
        btnNewTerm.Enabled = false;
    }

    // свойство - уровень безопасности
    public Security security
    {
      set { secur = value; }
      get { return secur; }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }

    private void btnFaculties_Click(object sender, EventArgs e)
    {
      frmFaculties form = new frmFaculties(secur);
      form.Show();
    }

    private void btnShowCaths_Click(object sender, EventArgs e)
    {
      frmCathedras form = new frmCathedras(secur);
      form.Show();
    }

    private void btnTeachers_Click(object sender, EventArgs e)
    {
      frmTeachers form = new frmTeachers(secur, false);
      form.Show();
    }

    private void btnGroups_Click(object sender, EventArgs e)
    {
      frmGroups frm = new frmGroups(secur, false);
      frm.Show();
    }

    private void btnStudents_Click(object sender, EventArgs e)
    {
      frmStudents frm = new frmStudents(secur, false, 
          frmStudents.SELECT_ALL, "");
      frm.Show();
    }

    private void btnSubjects_Click(object sender, EventArgs e)
    {
      frmSubjects frm = new frmSubjects(secur, false);
      frm.Show();
    }

    // кнопка - администрирование
    private void frmAdmin_Click(object sender, EventArgs e)
    {
      frmAdmin frm = new frmAdmin(secur);
      frm.ShowDialog();
    }

    // кнопка - новый семестр
    private void btnNewTerm_Click(object sender, EventArgs e)
    {
      int res = SqlAccess.sqlCommand(secur, Query.newTerm());
      if (res == 0)
        ExMessage.Information("Все группы переведены на новый семестр обучения!");
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
        Timetable frm = new Timetable(secur, false);
        frm.ShowDialog();
    }
  }
}