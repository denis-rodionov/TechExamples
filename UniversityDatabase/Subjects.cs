using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmSubjects : Form
  {
    // CONSTANTS
    private const int GRID_LEFT = 5;
    private const int GRID_TOP = 5;

    private const int SEL_ALL = 0;
    private const int SEL_BY_TEACH = 1;
    private const int SEL_BY_CATH = 2;
    private const int SEL_BY_GROUP = 3;

    // VARIABLES
    private Security sec;
    private MyDataGrid grdItems;
    private int selMethod;
    private Array teachs, caths, groups;

    public string selectedID;
    public string selectedName;
    private bool isSelectMode;

    // конструктор
    public frmSubjects(Security sec, bool isSelectMode)
    {      
      InitializeComponent();
      this.sec = sec;
      this.isSelectMode = isSelectMode;
      button1.Visible = isSelectMode;       // кнопка выбрать(дисциплину)
      initCombos();
      initGrid();
      selMethod = SEL_ALL;
      selectedID = null;
      selectedName = null;
      showItems();
      initSecurity();
    }

    // инициализация системы безопасности
    private void initSecurity()
    {
      if (!sec.SubModify)
      {
        btnAdd.Enabled = false;
        btnModify.Enabled = false;
        btnDelete.Enabled = false;
      }
    }

    // инициализация таблицы
    private void initGrid()
    {
      grdItems = new MyDataGrid(this, GRID_LEFT, GRID_TOP,
        tabControl1.Left - 5 - GRID_LEFT, ClientSize.Height - 5 - GRID_TOP);
      grdItems.Click += new EventHandler(grdItems_Click);

      if (sec.SubModify)
        grdItems.DoubleClick += new EventHandler(btnModify_Click); 
    }

    // инициализация выпадающих списков
    private void initCombos()
    {
      cmbTeachs.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllTeachers());
      cmbCaths.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllCaths());
      cmbGroups.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllGroups());

      teachs = SqlAccess.getArray(sec, 0, Query.selectAllTeachers());
      caths = SqlAccess.getArray(sec, 0, Query.selectAllCaths());
      groups = SqlAccess.getArray(sec, 0, Query.selectAllGroups());

      if (cmbTeachs.Items.Count > 0)
        cmbTeachs.SelectedIndex = 0;
      if (cmbCaths.Items.Count > 0)
        cmbCaths.SelectedIndex = 0;
      if (cmbGroups.Items.Count > 0)
        cmbGroups.SelectedIndex = 0;

      cmbTeachs.Enabled = false;
      cmbCaths.Enabled = false;
      cmbGroups.Enabled = false;

      if (selMethod == SEL_BY_TEACH)
        cmbTeachs.Enabled = true;
      else if (selMethod == SEL_BY_CATH)
        cmbCaths.Enabled = true;
      else if (selMethod == SEL_BY_GROUP)
        cmbGroups.Enabled = true;
    }

    // отображение предметов, выбранных по указанному методу выборки
    private void showItems()
    {
      grdItems.clear();

      DataTable tb = null;

      switch (selMethod)
      {
        case SEL_ALL:
          tb = selectAll();
          break;
        case SEL_BY_TEACH:
          tb = selectByTeach();
          break;
        case SEL_BY_CATH:
          tb = selectByCath();
          break;
        case SEL_BY_GROUP:
          tb = selectByGroup();
          break;
      }

      if (tb != null)
      {
        grdItems.setTable(tb, true, 1);
        getInfoAboutCur();
      }
      //else
      //  ExMessage.Error("Не удаётся выбрать дисциплины указанным методом!");
    }

    // выборка всех дисциплин
    private DataTable selectAll()
    {
      return SqlAccess.getTable(sec, Query.selectAllSubjects());
    }

    // выборка дисциплин по преподавателю
    private DataTable selectByTeach()
    {
      DataTable res = null;
      string teachID = ((string[])teachs)[cmbTeachs.SelectedIndex];

      if (teachID != "" && teachID != "-1")
        res = SqlAccess.getTable(sec, 
                  Query.selectSubjectsByTeach(teachID));

      return res;
    }

    // выборка дисциплин по кафедрам
    private DataTable selectByCath()
    {
      DataTable res = null;
      string cathID = ((string[])caths)[cmbCaths.SelectedIndex];

      if (cathID != "" && cathID != "-1")
        res = SqlAccess.getTable(sec, Query.selectSubjectsByCath(cathID));

      return res;
    }

    // выборка дисциплин по группам
    private DataTable selectByGroup()
    {
      DataTable res = null;
      string groupID = ((string[])groups)[cmbCaths.SelectedIndex];

      if (groupID != "" && groupID != "-1")
        res = SqlAccess.getTable(sec, Query.selectSubjectsByGroup(groupID));

      return res;
    }

    // отображение информации о выбранной дисциплине
    private void getInfoAboutCur()
    {
      if (!grdItems.notSelected())
      {
        DataTable tb = grdItems.getTable();
        int index = grdItems.getCurrentIndex();

        edtName.Text = tb.Rows[index].ItemArray[1].ToString();
        edtDesc.Text = tb.Rows[index].ItemArray[2].ToString();
      }
      else
      {
        edtName.Text = "---";
        edtDesc.Text = "";
      }
    }

    // grdItems  - Click
    private void grdItems_Click(object sender, EventArgs e)
    {
      getInfoAboutCur();
    }


    // радио кнопка - Все дисциплины
    private void radAll_CheckedChanged(object sender, EventArgs e)
    {
      if (radAll.Checked)
        selMethod = SEL_ALL;
    }

    // радио кнопка - По преподавателю
    private void radTeach_CheckedChanged(object sender, EventArgs e)
    {
      if (cmbTeachs.Enabled = radTeach.Checked)
        selMethod = SEL_BY_TEACH;
    }

    // радио кнопка - По кафедрам
    private void radCaths_CheckedChanged(object sender, EventArgs e)
    {
      if (cmbCaths.Enabled = radCaths.Checked)
        selMethod = SEL_BY_CATH;
    }

    // кнопка - добавить
    private void btnAdd_Click(object sender, EventArgs e)
    {
      frmSubModify frm = new frmSubModify(sec);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // кнопка - изменить
    private void btnModify_Click(object sender, EventArgs e)
    {
      if (grdItems.notSelected())
      {
        ExMessage.Warning("Выберите предмет для изменения");
        return;
      }

      DataRow row = grdItems.getTable().Rows[grdItems.getCurrentIndex()];
      frmSubModify frm = new frmSubModify(sec, row);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // кнопка - удалить
    private void btnDelete_Click(object sender, EventArgs e)
    {
      string subID = grdItems.getIDOfSelected().ToString();
      SqlAccess.sqlCommand(sec, Query.deleteSubject(subID));
    }

    // радио кнопка - по группам
    private void radGroup_CheckedChanged(object sender, EventArgs e)
    {
      if (cmbGroups.Enabled = radGroup.Checked)
        selMethod = SEL_BY_GROUP;
    }

    // кнопка - закрыть
    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    // кнопка - выбрать
    private void btnSelect_Click(object sender, EventArgs e)
    {
      showItems();
    }

    // Кнопка выбрать (дисцилину)
    private void button1_Click(object sender, EventArgs e)
    {
      selectedID = grdItems.getIDOfSelected().ToString();
      selectedName = grdItems.getObjectOfSelectedRow(1);
    }
  }
}