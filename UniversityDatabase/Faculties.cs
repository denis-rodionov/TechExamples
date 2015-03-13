using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace University
{
  public partial class frmFaculties : Form
  {
    private Security sec;
    private MyDataGrid grdItems;
    private const int GRID_LEFT = 5;
    private const int GRID_TOP = 5;
    private DataTable curTable;

    public frmFaculties(Security sec)
    {
      this.sec = sec;
      InitializeComponent();
      initGrid();
      initSecurity();
    }

    // инициализация настроек безопасности
    private void initSecurity()
    {
      if (!sec.facModify)
      {
        btnAdd.Enabled = false;
        btnModify.Enabled  = false;
        btnDelete.Enabled = false;
      }
    }

    private void initGrid()
    {
      grdItems = new MyDataGrid(this, GRID_LEFT, GRID_TOP,
        tabControl1.Left - 5 - GRID_LEFT, ClientSize.Height - 5 - GRID_TOP);
      grdItems.Click += new EventHandler(grdItems_Click);

      if (sec.facModify)
        grdItems.DoubleClick += new EventHandler(btnModify_Click);
    }

    private void grdItems_Click(object sender, EventArgs e)
    {
      getInfoAboutCur();
    }

    private void frmFaculties_Load(object sender, EventArgs e)
    {
      showItems();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    // Отображение всех факультетов
    private void showItems()
    {
      curTable = SqlAccess.getTable(sec, Query.selectAllFacs());

      if (curTable == null)
        return;

      grdItems.setTable(curTable, true, 1);
      getInfoAboutCur();
    }

    private void getInfoAboutCur()
    {
      if (grdItems.notSelected())
        return;

      int index = grdItems.getCurrentIndex();

      edtName.Text = curTable.Rows[index].ItemArray[1].ToString();
      edtDesc.Text = curTable.Rows[index].ItemArray[2].ToString();
      edtHead.Text = curTable.Rows[index].ItemArray[3].ToString() + " " +
                     curTable.Rows[index].ItemArray[4].ToString() + " " +
                     curTable.Rows[index].ItemArray[5].ToString();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      showItems();
    }

    // добавление факультета
    private void btnAdd_Click(object sender, EventArgs e)
    {
      frmFacModify frm = new frmFacModify(sec);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // модификация факультета
    private void btnModify_Click(object sender, EventArgs e)
    {
      int facID = grdItems.getIDOfSelected();
      int headID = int.Parse(grdItems.getObjectOfSelectedRow(6));

      frmFacModify frm = new frmFacModify(sec, facID, headID);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // удаление факультета
    private void btnDelete_Click(object sender, EventArgs e)
    {
      int facID = grdItems.getIDOfSelected();

      if (facID == -1)
        return;

      // количество зависящих кафедр
      //int count = SqlAccess.getInt(sec, 0, Query.countOfCaths(facID));

      //DialogResult res = DialogResult.No;
      //if (count > 0)
      //{
      //  res = ExMessage.ExclamationYesNo(
      //    "Данному факультету принадлежит " + count.ToString() + " кафедр." +
      //    "В следствии удаления факультета кафедры тоже удаляться.\r\n" +
      //    "Продолжить?");
      //}

      //if (res == DialogResult.Yes || count == 0)

      SqlAccess.sqlCommand(sec, Query.deleteFac(facID));
      showItems();
    }
  }
}