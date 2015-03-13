using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmAssignSubject : Form
  {
    // CONSTANTS
    private const string DEFAULT_TEXT = "---";

    // VARIABLES
    private Security sec;
    private string subID;
    private string groupID;
    private string teachID;
    private bool isAdding;

    // Конструктор
    public frmAssignSubject(Security sec, string subID, string groupID, string teachID)
    {
      InitializeComponent();
      this.sec = sec;
      this.subID = subID;
      this.groupID = groupID;
      this.teachID = teachID;

      if (teachID != null)    // доба данных
      {
        isAdding = false;
        btnGroup.Enabled = false;
        btnSubject.Enabled = false;
      }
      else
        isAdding = true;

      initValues();
    }

    // Инициализация формы
    private void initValues()
    {
      if (subID != null)
      {
        DataTable tb = SqlAccess.getTable(sec, Query.selectSubject(subID));
        edtSubject.Text = tb.Rows[0].ItemArray[1].ToString();
      }
      else
        edtSubject.Text = DEFAULT_TEXT;

      if (groupID != null)
      {
        DataTable tb = SqlAccess.getTable(sec, Query.selectGroup(groupID));
        edtGroup.Text = tb.Rows[0].ItemArray[1].ToString();
      }
      else
        edtGroup.Text = DEFAULT_TEXT;

      if (teachID != null)
      {
        DataTable tb = SqlAccess.getTable(sec, Query.selectTeach(int.Parse(teachID)));
        edtTeach.Text = tb.Rows[0].ItemArray[10].ToString();
      }
      else
        edtTeach.Text = DEFAULT_TEXT;
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    // кнопка - назначить преподавателя
    private void button5_Click(object sender, EventArgs e)
    {
      frmTeachers frm = new frmTeachers(sec, true);

      if (frm.ShowDialog() == DialogResult.OK)
      {
        teachID = frm.selectedID.ToString();
        edtTeach.Text = 
          SqlAccess.getString(sec, 10, Query.selectTeach(int.Parse(teachID)));
      }
    }

    // кнопка - назначить предмет
    private void btnSubject_Click(object sender, EventArgs e)
    {
      frmSubjects frm = new frmSubjects(sec, true);

      if (frm.ShowDialog() == DialogResult.OK)
      {
        subID = frm.selectedID;
        edtSubject.Text = frm.selectedName;
      }
    }

    // кнопка - назначить группу
    private void btnGroup_Click(object sender, EventArgs e)
    {
      frmGroups frm = new frmGroups(sec, true);

      if (frm.ShowDialog() == DialogResult.OK)
      {
        groupID = frm.selectedID;
        edtGroup.Text = frm.selectedName;
      }
    }

    // кнопка - Отмена
    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    // кнопка - ОК
    private void btnOk_Click(object sender, EventArgs e)
    {
      if (subID == null)
      {
        ExMessage.Warning("Дисциплина не заданна!");
        return;
      }

      if (groupID == null)
      {
        ExMessage.Warning("Группа не заданна!");
        return;
      }

      if (teachID == null)
      {
        ExMessage.Warning("Преподаватель не задан!");
        return;
      }

      // теперь всё в поряде
      int res = -1;
      if (isAdding)
        res = SqlAccess.sqlCommand(sec, Query.insertTeachSubject(subID, groupID, teachID));
      else
        res = SqlAccess.sqlCommand(sec, Query.updateTeachSubject(subID, groupID, teachID));

      if (res == 0)
        Close();
    }    
  }
}