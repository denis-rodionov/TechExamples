using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmTeachers : Form
  {
    // Параметры формы
    private const int GRID_X = 5;
    private const int GRID_Y = 5;
    private const int GRID_WIDTH = 10;
    private const int GRID_HEIGHT = 10;

    // переменные
    private Security sec;
    private MyDataGrid grdItems;
    private bool isSelectForm;
    public int selectedID;

    public frmTeachers(Security sec, bool isSelectForm)
    {
      InitializeComponent();
      this.isSelectForm = isSelectForm;
      btnOk.Visible = isSelectForm;
      selectedID = -1;
      MaximizeBox = false;
      FormBorderStyle = FormBorderStyle.FixedSingle;
      this.sec = sec;
      initGrid();
      showTeachersByCurrentMethod();
      if (grdItems.getTable().Rows.Count != 0)
        getInfoAbout(0);

      initSecurity();
    }

    // инициализация параметров безопасности
    private void initSecurity()
    {
      if (!sec.teachModify)
      {
        btnAdd.Enabled = false;
        btnModify.Enabled = false;
        btnDel.Enabled = false;
      }
    }

    private void initGrid()
    {
      grdItems = new MyDataGrid(this, GRID_X, GRID_Y, 
                    tabCont.Left - 10, ClientSize.Height - 10);
      grdItems.Click += new EventHandler(grdItems_Click);

      if (sec.teachModify)
        grdItems.DoubleClick += new EventHandler(btnModify_Click);      
    }

    private void grdItems_Click(object sender, EventArgs e)
    {
      fillNullAbout();
      if (grdItems.getTable().Rows.Count != 0)
        getInfoAbout(grdItems.CurrentRow.Index);
    }

    private void getInfoAbout(int row)
    {
      if (grdItems.Rows[row].Cells[0].ToString() != "")
      {
        DataTable tb = SqlAccess.getTable(sec,
            Query.selectTeach(grdItems.Rows[row].Cells[1].Value.ToString(),
                              grdItems.Rows[row].Cells[0].Value.ToString(),
                              grdItems.Rows[row].Cells[2].Value.ToString()));

        if (tb == null || tb.Rows.Count != 0)
        {
          lblFirstName.Text = tb.Rows[0].ItemArray[1].ToString();
          lblLastName.Text = tb.Rows[0].ItemArray[2].ToString();
          lblThirdName.Text = tb.Rows[0].ItemArray[3].ToString();
          lblPasNo.Text = tb.Rows[0].ItemArray[4].ToString();
          lblDegree.Text = tb.Rows[0].ItemArray[5].ToString();
          lblAge.Text = tb.Rows[0].ItemArray[6].ToString();
          lblPhone.Text = tb.Rows[0].ItemArray[7].ToString();
          edtAddress.Text = tb.Rows[0].ItemArray[8].ToString();
          lblCath.Text = tb.Rows[0].ItemArray[9].ToString();
          edtPost.Text = tb.Rows[0].ItemArray[10].ToString();
          edtRank.Text = tb.Rows[0].ItemArray[11].ToString();
        }
        else
        {
          fillNullAbout();
          lblLastName.Text = "Запись не найдена";
        }
      }
    }

    // заполнение всех полей звёздочками
    private void fillNullAbout()
    {
      lblFirstName.Text = "***";
      lblLastName.Text = "***";
      lblThirdName.Text = "***";
      lblPasNo.Text = "***";
      lblDegree.Text = "***";
      lblAge.Text = "***";
      lblPhone.Text = "***";
      edtAddress.Text = "***";
      lblCath.Text = "***";
      edtPost.Text = "***";
      edtRank.Text = "***";
    }

    private void cmbCath_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
      Close();
    }

    // Начать выборку
    private void btnSelect_Click(object sender, EventArgs e)
    {
      showTeachersByCurrentMethod();
    }

    // 
    private void showTeachersByCurrentMethod()
    {
      grdItems.clear();

      if (radCath.Checked)
        selectByCaths(cmbCriter.SelectedItem.ToString());
      else if (radFac.Checked)
        selectByFacs(cmbCriter.SelectedItem.ToString());
      else if (radAll.Checked)
        selectAll();

      if (grdItems.CurrentRow != null)
        getInfoAbout(grdItems.CurrentRow.Index);
    }

    // Выборка всех преподавателей
    private void selectAll()
    {      
      DataTable tb = 
        SqlAccess.getTable(sec, Query.selectAllTeachers());
      grdItems.setTable(tb, true, 1, 2, 3, 4);      
    }

    // выборка по кафедрам
    private void selectByCaths(string str)
    {
      string cathName = getCathNameFromString(str);      

      DataTable tb = 
        SqlAccess.getTable(sec, Query.selectTeachsByCath(cathName));
      grdItems.setTable(tb, true, 1, 2, 3, 4);
    }

    // выборка по факультетам
    private void selectByFacs(string facName)
    {      
      DataTable tb = 
        SqlAccess.getTable(sec, Query.selectTeachsByFact(facName));
      grdItems.setTable(tb, true, 1, 2, 3, 4);
    }

    // мзвлечение из строки типа: (<cathIndex>) <cathName> имени кафедры
    private string getCathNameFromString(string str)
    {
      string res = null;
      for (int i = 0; i < str.Length; i++)
        if (str[i] == ' ')     
        {
          res = str.Substring(i + 1);
          break;
        }

      return res;
    }

    // Cathedras radio button changed
    private void radSelect_CheckedChanged(object sender, EventArgs e)
    {
      if (radCath.Checked)
      {
        cmbCriter.DataSource = null;        
        Array arr = SqlAccess.getArray(sec, 1, Query.selectAllCathsWithIndex());
        cmbCriter.DataSource = arr;
        cmbCriter.SelectedIndex = 0;
      }
    }

    // Faculty radio button changed
    private void radFac_CheckedChanged(object sender, EventArgs e)
    {
      if (radFac.Checked)
      {
        cmbCriter.DataSource = null;
        cmbCriter.Items.Clear();
        cmbCriter.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllFacs());     
        cmbCriter.SelectedIndex = 0;
      }
    }

    private void frmTeachers_Load(object sender, EventArgs e)
    {

    }

    private void radAll_CheckedChanged(object sender, EventArgs e)
    {
      cmbCriter.Enabled = !cmbCriter.Enabled;
    }

    // удаление преподавателя
    private void btnDel_Click(object sender, EventArgs e)
    {
      int teachID = grdItems.getIDOfSelected();

      if (teachID == -1)
        return;

      SqlAccess.sqlCommand(sec, Query.deleteTeach(teachID));
      showTeachersByCurrentMethod();
    }

    // добавление преподавателя
    private void btnAdd_Click(object sender, EventArgs e)
    {
      frmTeachModify form = new frmTeachModify(sec);      

      if (form.status == frmTeachModify.STAT_SUCCESS)
      {
        form.ShowDialog();
        showTeachersByCurrentMethod();
      }
    }

    // модификация преподавателя
    private void btnModify_Click(object sender, EventArgs e)
    {
      int teachId = grdItems.getIDOfSelected();
      if (teachId == -1)
      {
        MessageBox.Show("Преподаватель отсутстввует в базе данных, попробуёте повторить выборку", "Ошибка");
        return;
      }

      frmTeachModify form = new frmTeachModify(sec, teachId);

      if (form.status == frmTeachModify.STAT_SUCCESS)
      {
        form.ShowDialog();
        showTeachersByCurrentMethod();
      }
    }

    // Выбор преподавателя
    private void btnOk_Click(object sender, EventArgs e)
    {
      selectedID = grdItems.getIDOfSelected();
      DialogResult = DialogResult.OK;
      Hide();
    }

    private void frmTeachers_Load_1(object sender, EventArgs e)
    {

    }

    private void tabInfo_Click(object sender, EventArgs e)
    {

    }
  }
}