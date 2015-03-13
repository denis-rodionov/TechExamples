using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmCathedras : Form
  {
    // CONSTANTS
    private const string ALL_FACS = "Все факультеты";
    private const int SELECT_ALL = 1;
    private const int SELECT_BY_FAC = 2;

    // VARIABLES
    private int selMethod = SELECT_ALL;
    // Параметры формы
    private const int GRID_LEFT = 5;
    private const int GRID_TOP = 5;

    // Переменные
    private Security sec;
    private string curFac = null;         // ALL_FACS - все факультеты
    private MyDataGrid grdItems;
    private MyDataGrid grdSubItems;
    private DataTable curTable;       // таблица, отображённая на форму

    public frmCathedras(Security sec)
    {
      this.sec = sec;
      InitializeComponent();
      initSecurity();
    }

    // инициализация параметров безопасности
    private void initSecurity()
    {
      if (!sec.cathModify)
      {
        btnAdd.Enabled = false;
        btnModify.Enabled = false;
        btnDelete.Enabled = false;      
        btnAddSubject.Enabled = false;
        btnDelSubject.Enabled = false;
      }
    }

    // нициализаци таблицы дисциплин
    public void initSubGrid()
    {
      grdSubItems = new MyDataGrid(tabPage3, 0, 0,
        tabPage3.Right, btnAddSubject.Top - GRID_TOP);
    }

    public string curFaculty
    {
      set { curFac = value; }
    }

    // загрузка формы
    private void frmCathedras_Load(object sender, EventArgs e)
    {
      initDataGrid();
      initSubGrid();
      fillFacsCombo();
      showItems();      
      initSelectPars();
    }

    // инициализация компонентов выборки
    private void initSelectPars()
    {
      switch (selMethod)
      {
        case SELECT_ALL:       
          cmbFaculties.Enabled = false;
          break;
        case SELECT_BY_FAC:
          cmbFaculties.Enabled = true;
          fillFacsCombo();
          break;
      }
    }

    // инициализация таблицы вывода кафедр
    private void initDataGrid()
    {
      grdItems = new MyDataGrid(this, GRID_LEFT, GRID_TOP, 
        tabControl1.Left - 5 - GRID_LEFT, ClientSize.Height - 5 - GRID_TOP);
      grdItems.Click += new EventHandler(grdItems_Click);

      if (sec.cathModify)
        grdItems.DoubleClick += new EventHandler(btnModify_Click);     
    }

    // заполнение списка факультетов
    private void fillFacsCombo()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectAllFacs());

      if (tb == null)
        return;

      cmbFaculties.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllFacs());      
    }

    // Отображение таблицы кафедр в соответствии с выбранным факультетом
    private void showItems()
    {
      object curFac = cmbFaculties.SelectedItem;
      if (curFac != null)
      {        
        if (selMethod == SELECT_BY_FAC)
          curTable = SqlAccess.getTable(sec, Query.selectCathsByFac(curFac.ToString()));
        else if (selMethod == SELECT_ALL)
          curTable = SqlAccess.getTable(sec, Query.selectAllCaths());
        else
          return;

        grdItems.setTable(curTable, true, 1, 2);
        getInfoAboutCur();
      }
    }

    // получить информацию о текущей, выбранной кафедре
    private void getInfoAboutCur()
    {
      if (grdItems.notSelected())
        return;
      int index = grdItems.getCurrentIndex();

      edtName.Text = curTable.Rows[index].ItemArray[1].ToString();
      edtIndex.Text = curTable.Rows[index].ItemArray[2].ToString();
      edtDesc.Text = curTable.Rows[index].ItemArray[3].ToString();
      edtFac.Text = curTable.Rows[index].ItemArray[4].ToString();
      edtHead.Text = curTable.Rows[index].ItemArray[5].ToString() + " " +
                     curTable.Rows[index].ItemArray[6].ToString() + " " +
                     curTable.Rows[index].ItemArray[7].ToString();

      fillSubjectTable();
    }

    // заполнение таблицы дисциплин
    private void fillSubjectTable()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectSubjectsByCath(
            grdItems.getIDOfSelected().ToString()));
      grdSubItems.setTable(tb, true, 1,3);
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnShow_Click(object sender, EventArgs e)
    {
      showItems();
    }

    private void radSelectAll_CheckedChanged(object sender, EventArgs e)
    {
      selMethod = SELECT_ALL;
      initSelectPars();
    }

    private void radByFac_CheckedChanged(object sender, EventArgs e)
    {
      selMethod = SELECT_BY_FAC;
      initSelectPars();
    }

    // удаление кафедры
    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (grdItems.notSelected())
      {
        MessageBox.Show("Не выбрана кафедра!", "Ошибка");
        return;
      }

      int curCath = grdItems.getIDOfSelected();
      //int count = SqlAccess.getInt(sec, 0, Query.countOfTeachsOfCaths(curCath));

      //DialogResult res = DialogResult.No;
      //if (count > 0)
      //{
      //  res = ExMessage.ExclamationYesNo(
      //    "При удалении кафедры потеряются " + count.ToString() +
      //    " преподавателей, закреплённых за этой кафедрой!\r\nПродолжить?");
      //}

      //if (res == DialogResult.Yes || count == 0)
      if (true)
      {
        SqlAccess.sqlCommand(sec, Query.deleteCath(curCath));
        showItems();
      }
    }

    // Добавление кафедры
    private void btnAdd_Click(object sender, EventArgs e)
    {
      frmCathModify frm = new frmCathModify(sec);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // клик по таблице для отображения информации
    private void grdItems_Click(object sender, EventArgs e)
    {
      getInfoAboutCur();
    }

    // изменение кафедры
    private void btnModify_Click(object sender, EventArgs e)
    {
      int cathID = grdItems.getIDOfSelected();

      frmCathModify frm = new frmCathModify(sec, cathID);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // кнопка - добавить (дисциплину)
    private void button1_Click(object sender, EventArgs e)
    {
      string cathID = grdItems.getIDOfSelected().ToString();
      string specID = SqlAccess.getString(sec, 0, Query.selectSpecByCath(cathID));
      frmSpecSubjects frm = new frmSpecSubjects(sec, specID);

      frm.ShowDialog();
      getInfoAboutCur();
    }

    // кнопка - удалить (дисциплину)
    private void btnDelSubject_Click(object sender, EventArgs e)
    {      
      string subID = grdSubItems.getIDOfSelected().ToString();

      if (subID != "-1")
      {
        SqlAccess.sqlCommand(sec, Query.deleteSpecSubject(subID));
        getInfoAboutCur();
      }
      else
        ExMessage.Warning("Выберите дисциплину!");
    }
  }
}