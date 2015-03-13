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
    private const string ALL_FACS = "��� ����������";
    private const int SELECT_ALL = 1;
    private const int SELECT_BY_FAC = 2;

    // VARIABLES
    private int selMethod = SELECT_ALL;
    // ��������� �����
    private const int GRID_LEFT = 5;
    private const int GRID_TOP = 5;

    // ����������
    private Security sec;
    private string curFac = null;         // ALL_FACS - ��� ����������
    private MyDataGrid grdItems;
    private MyDataGrid grdSubItems;
    private DataTable curTable;       // �������, ����������� �� �����

    public frmCathedras(Security sec)
    {
      this.sec = sec;
      InitializeComponent();
      initSecurity();
    }

    // ������������� ���������� ������������
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

    // ����������� ������� ���������
    public void initSubGrid()
    {
      grdSubItems = new MyDataGrid(tabPage3, 0, 0,
        tabPage3.Right, btnAddSubject.Top - GRID_TOP);
    }

    public string curFaculty
    {
      set { curFac = value; }
    }

    // �������� �����
    private void frmCathedras_Load(object sender, EventArgs e)
    {
      initDataGrid();
      initSubGrid();
      fillFacsCombo();
      showItems();      
      initSelectPars();
    }

    // ������������� ����������� �������
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

    // ������������� ������� ������ ������
    private void initDataGrid()
    {
      grdItems = new MyDataGrid(this, GRID_LEFT, GRID_TOP, 
        tabControl1.Left - 5 - GRID_LEFT, ClientSize.Height - 5 - GRID_TOP);
      grdItems.Click += new EventHandler(grdItems_Click);

      if (sec.cathModify)
        grdItems.DoubleClick += new EventHandler(btnModify_Click);     
    }

    // ���������� ������ �����������
    private void fillFacsCombo()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectAllFacs());

      if (tb == null)
        return;

      cmbFaculties.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllFacs());      
    }

    // ����������� ������� ������ � ������������ � ��������� �����������
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

    // �������� ���������� � �������, ��������� �������
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

    // ���������� ������� ���������
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

    // �������� �������
    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (grdItems.notSelected())
      {
        MessageBox.Show("�� ������� �������!", "������");
        return;
      }

      int curCath = grdItems.getIDOfSelected();
      //int count = SqlAccess.getInt(sec, 0, Query.countOfTeachsOfCaths(curCath));

      //DialogResult res = DialogResult.No;
      //if (count > 0)
      //{
      //  res = ExMessage.ExclamationYesNo(
      //    "��� �������� ������� ���������� " + count.ToString() +
      //    " ��������������, ����������� �� ���� ��������!\r\n����������?");
      //}

      //if (res == DialogResult.Yes || count == 0)
      if (true)
      {
        SqlAccess.sqlCommand(sec, Query.deleteCath(curCath));
        showItems();
      }
    }

    // ���������� �������
    private void btnAdd_Click(object sender, EventArgs e)
    {
      frmCathModify frm = new frmCathModify(sec);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // ���� �� ������� ��� ����������� ����������
    private void grdItems_Click(object sender, EventArgs e)
    {
      getInfoAboutCur();
    }

    // ��������� �������
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

    // ������ - �������� (����������)
    private void button1_Click(object sender, EventArgs e)
    {
      string cathID = grdItems.getIDOfSelected().ToString();
      string specID = SqlAccess.getString(sec, 0, Query.selectSpecByCath(cathID));
      frmSpecSubjects frm = new frmSpecSubjects(sec, specID);

      frm.ShowDialog();
      getInfoAboutCur();
    }

    // ������ - ������� (����������)
    private void btnDelSubject_Click(object sender, EventArgs e)
    {      
      string subID = grdSubItems.getIDOfSelected().ToString();

      if (subID != "-1")
      {
        SqlAccess.sqlCommand(sec, Query.deleteSpecSubject(subID));
        getInfoAboutCur();
      }
      else
        ExMessage.Warning("�������� ����������!");
    }
  }
}