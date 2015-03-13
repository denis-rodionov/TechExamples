using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace University
{
  public partial class frmCathModify : Form
  {
    // CONSTANT
    

    // VARIABLES
    private Security sec;
    public bool isReady;
    private int cathID;
    public bool isAdding;
    private int headID;
    private DataTable facTable;

    // конструктор для изменения кафедры
    public frmCathModify(Security sec, int cathID)
    {
      this.sec = sec;
      commonInit();      
      isAdding = false;
      this.cathID = cathID;
      Text = "Изменение кафедры";
      btnOk.Text = "Изменить";
      initCombo();
      initValues();
    }

    // конструктор для создания кафедры
    public frmCathModify(Security sec)
    {
      this.sec = sec;
      commonInit();
      isAdding = true;      
      Text = "Добавление кафедры";
      initCombo();
      checkTeachs();
      btnOk.Text = "Добавить";
    }

    private void commonInit()
    {
      InitializeComponent();
      headID = -1;
      isReady = true;     // изначально, пока никто не изменил этот флаг      
    }

    // инициализация текущих значений кафедры для её модификации
    private void initValues()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectCath(cathID));

      edtName.Text = tb.Rows[0].ItemArray[1].ToString();
      edtIndex.Text = tb.Rows[0].ItemArray[2].ToString();
      edtDesc.Text = tb.Rows[0].ItemArray[3].ToString();
      edtHead.Text = tb.Rows[0].ItemArray[5].ToString() + " " +
                     tb.Rows[0].ItemArray[6].ToString() + " " +
                     tb.Rows[0].ItemArray[7].ToString();

      headID = int.Parse(tb.Rows[0].ItemArray[8].ToString());

      cmbFacs.SelectedIndex =
        cmbFacs.Items.IndexOf(tb.Rows[0].ItemArray[4].ToString());
    }

    // проверяет наличие в базе данных учителей, чтобы
    // кто-то мог озаглавить кафедру
    private void checkTeachs()
    {
      int count = SqlAccess.getInt(sec, 0, Query.countOfTeachs());

      if (count == 0)
      {
        isReady = false;
        ExMessage.Error("Добавьте в базу данных преподавателя, чтобы " +
            "назначить главу кафердры!");
      }
    }

    // Инициализация списка факультетов
    private void initCombo()
    {
      facTable = new DataTable();
      facTable = SqlAccess.getTable(sec, Query.selectAllFacs());      

      if (facTable.Rows.Count == 0)
      {
        ExMessage.Error("Не найдено ни одного факультьета!");
        isReady = false;       
      }
      else
      {
        cmbFacs.DataSource = Converter.tableToArray(facTable, 1);
        cmbFacs.SelectedIndex = 0;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Hide();
    }

    // Выбор преподавателя на место заведующего кафедрой
    private void button3_Click(object sender, EventArgs e)
    {
      frmTeachers frm = new frmTeachers(sec, true);

      if (frm.ShowDialog() == DialogResult.OK)
      {
        headID = frm.selectedID;
        showHead();
      }
    }

    // отобразить начальника
    private void showHead()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectTeach(headID));

      edtHead.Text = tb.Rows[0].ItemArray[2] + " " +
                     tb.Rows[0].ItemArray[1] + " " +
                     tb.Rows[0].ItemArray[3];
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      if (isAdding)
        addCath();
      else
        modifyCath();
    }

    // добавление кафедры
    private void addCath()
    {
      if (headID == -1)
      {
        ExMessage.Error("Укажите заведующего кафедрой!");
        return;
      }

      int facID = 
        int.Parse(facTable.Rows[cmbFacs.SelectedIndex].ItemArray[0].ToString());

      if (facID == -1)
      {
        ExMessage.Error("Факультет не найден!");
        return;
      }
      
      SqlAccess.sqlCommand(sec, Query.insertCath(edtName.Text,
                                                 edtIndex.Text,
                                                 edtDesc.Text,
                                                 headID, facID));      
      Close();
    }

    // модификация кафедры
    private void modifyCath()
    {
      int facID =
        int.Parse(facTable.Rows[cmbFacs.SelectedIndex].ItemArray[0].ToString());

      if (facID == -1)
      {
        ExMessage.Error("Факультет не найден!");
        return;
      }

      SqlAccess.sqlCommand(sec, Query.updateCath(cathID, edtName.Text,
                                                 edtIndex.Text,
                                                 edtDesc.Text,
                                                 facID, headID));
      Close();
    }
  }
}