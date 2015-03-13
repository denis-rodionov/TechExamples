using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmStudents : Form
  {
    // CONSTANT
    public const int SELECT_ALL = 0;
    public const int SELECT_BY_GROUP = 1;
    public const int SELECT_BY_CATH = 2;
    public const int SELECT_BY_FAC = 3;

    private const int GRID_LEFT = 5;
    private const int GRID_TOP = 5;

    // VARIABLES
    private Security sec;
    private int curSelect;
    private string criter;      // �������� �������
    public DataRow selectedRow;
    private bool isQuery;
    private MyDataGrid grdItems;
    private MyDataGrid grdSubItems;

    public frmStudents(Security sec, bool isQuery, int selMethod, string criter)
    {
      InitializeComponent();
      this.sec = sec;
      this.isQuery = isQuery;
      initGrid();
      initSubGrid();
      initCombos();
      initSelMethod(selMethod, criter);
      initButtons();
      showItems();
      initSecurity();      
    }

    // ������������� ������� ������������
    private void initSecurity()
    {
      if (!sec.studModify)
      {
        btnAdd.Enabled = false;
        btnModify.Enabled = false;
        btnDelete.Enabled = false;
      }
    }

    // ������������� ����� ������
    private void initGrid()
    {
      grdItems = new MyDataGrid(this, GRID_LEFT, GRID_TOP,
        tabControl1.Left - 5 - GRID_LEFT, ClientSize.Height - 5 - GRID_TOP);
      grdItems.Click += new EventHandler(grdItems_Click);

      if (sec.studModify)
        grdItems.DoubleClick += new EventHandler(btnModify_Click);  
    }

    // ������������� ������� ���������
    private void initSubGrid()
    {
      grdSubItems = new MyDataGrid(tabPage3, 0, 0, tabPage3.Width, tabPage3.Bottom);
    }

    // ���� �� ����� ������
    private void grdItems_Click(object sender, EventArgs e)
    {
      getInfoAboutCur();
    }

    // ������������� ������ ������ ��������
    private void initButtons()
    {
      btnOk.Visible = isQuery;
    }

    // ������������� ���������� �����o�
    private void initCombos()
    {
      cmbGroup.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllGroups());
      cmbCath.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllCaths());
      cmbFac.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllFacs());

      if (cmbGroup.Items.Count > 0)
        cmbGroup.SelectedIndex = 0;
      if (cmbCath.Items.Count > 0)
        cmbCath.SelectedIndex = 0;
      if (cmbFac.Items.Count > 0)
        cmbFac.SelectedIndex = 0;

      cmbGroup.Enabled = false;
      cmbCath.Enabled = false;
      cmbFac.Enabled = false;
    }

    // ������������� �������� �������
    private void initSelMethod(int selMethod, string criter)
    {
      curSelect = selMethod;
      this.criter = criter;

      switch (selMethod)
      {
        case SELECT_ALL:          
          radAll.Checked = true;
          break;
        case SELECT_BY_GROUP:
          radByGroup.Checked = true;
          cmbGroup.Enabled = true;
          cmbGroup.Text = criter;
          break;
        case SELECT_BY_CATH:
          radByCath.Checked = true;
          cmbCath.Enabled = true;
          cmbCath.Text = criter;
          break;
        case SELECT_BY_FAC:
          radByFac.Checked = true;
          cmbFac.Enabled = true;
          cmbFac.Text = criter;
          break;
      }
    }

    // ����������� �� ����� ���������, ��������� ������� �������
    private void showItems()
    {
      DataTable tb = null;

      switch (curSelect)
      {
        case SELECT_ALL:
          tb = selectAll();
          break;
        case SELECT_BY_GROUP:
          tb = selectByGroup();
          break;
        case SELECT_BY_CATH:
          tb = selectByCath();
          break;
        case SELECT_BY_FAC:
          tb = selectByFac();
          break;
        default:
          ExMessage.Warning("�� ����� ����� �������");
          break;
      }

      grdItems.setTable(tb, true, 1, 2, 3);
      getInfoAboutCur();
    }

    // ������� ���� ���������
    private DataTable selectAll()
    {
      return SqlAccess.getTable(sec, Query.selectAllStudents());
    }

    // ������� ��������� �� �������� ������
    private DataTable selectByGroup()
    {
      string groupIndex = cmbGroup.SelectedValue.ToString();
      return SqlAccess.getTable(sec, Query.selectStudsByGroup(groupIndex));
    }

    // ������� ��������� �� �������� �������
    private DataTable selectByCath()
    {
      string cathName = cmbCath.SelectedValue.ToString();
      return SqlAccess.getTable(sec, Query.selectStudsByCath(cathName));
    }

    // ������� ��������� �� �������� ����������
    private DataTable selectByFac()
    {
      string facName = cmbFac.SelectedValue.ToString();
      return SqlAccess.getTable(sec, Query.selectStudsByFac(facName));
    }

    // ���������� ���������� � ������� �������� ��������
    private void getInfoAboutCur()
    {
      if (!grdItems.notSelected())
      {
        int index = grdItems.getCurrentIndex();
        DataTable tb = grdItems.getTable();

        edtLastName.Text = tb.Rows[index].ItemArray[2].ToString();
        edtFirstName.Text = tb.Rows[index].ItemArray[1].ToString();
        edtThirdName.Text = tb.Rows[index].ItemArray[3].ToString();
        edtPasNo.Text = tb.Rows[index].ItemArray[4].ToString();
        edtRecordBook.Text = tb.Rows[index].ItemArray[5].ToString();
        edtAge.Text = tb.Rows[index].ItemArray[6].ToString();
        edtStartYear.Text = tb.Rows[index].ItemArray[7].ToString();
        edtPhone.Text = tb.Rows[index].ItemArray[8].ToString();
        edtAddress.Text = tb.Rows[index].ItemArray[9].ToString();
        edtCourse.Text = tb.Rows[index].ItemArray[11].ToString();
        edtGroup.Text = tb.Rows[index].ItemArray[12].ToString();
        edtCathName.Text = tb.Rows[index].ItemArray[13].ToString();
        edtFacName.Text = tb.Rows[index].ItemArray[14].ToString();

        fillSubTable();
      }
      else
      {
        edtFirstName.Text = "---";
        edtLastName.Text = "---";
        edtThirdName.Text = "---";
        edtPasNo.Text = "";
        edtRecordBook.Text = "";
        edtAge.Text = "";
        edtStartYear.Text = "";
        edtPhone.Text = "";
        edtAddress.Text = "";
        edtCourse.Text = "";
        edtGroup.Text = "";
        edtCathName.Text = "";
        edtFacName.Text = "";
      }
    }

    // ���������� ������� ���������
    private void fillSubTable()
    {
      string groupID = 
        grdItems.getTable().Rows[grdItems.getCurrentIndex()].ItemArray[10].ToString();
      if (groupID == "")
        return;
      DataTable tb = SqlAccess.getTable(sec, Query.selectSubjectsByGroup(groupID));
      grdSubItems.setTable(tb, true, 1);
    }

    // ������ �������
    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    // ������ - �������
    private void btnSelect_Click(object sender, EventArgs e)
    {
      showItems();
    }

    // ������ - ��������
    private void btnModify_Click(object sender, EventArgs e)
    {
      frmStudModify frm = new frmStudModify(sec, 
        grdItems.getTable().Rows[grdItems.getCurrentIndex()]);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // ������ - �������
    private void btnDelete_Click(object sender, EventArgs e)
    {
      int index = grdItems.getIDOfSelected();
      SqlAccess.sqlCommand(sec, Query.deleteStud(index));
      showItems();
    }

    // ������ - ��������
    private void btnAdd_Click(object sender, EventArgs e)
    {
      frmStudModify frm = new frmStudModify(sec);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // ����� ������ - �� �������
    private void radByGroup_CheckedChanged(object sender, EventArgs e)
    {
      if (cmbGroup.Enabled = radByGroup.Checked)
        curSelect = SELECT_BY_GROUP;
    }

    // ����� ������ - �� ��������
    private void radByCath_CheckedChanged(object sender, EventArgs e)
    {
      if (cmbCath.Enabled = radByCath.Checked)
        curSelect = SELECT_BY_CATH;
    }

    // ����� ������ - �� �����������
    private void radByFac_CheckedChanged(object sender, EventArgs e)
    {
      if (cmbFac.Enabled = radByFac.Checked)
        curSelect = SELECT_BY_FAC;
    }

    // ����� ������ - ���� ���������
    private void radAll_CheckedChanged(object sender, EventArgs e)
    {
      if (radAll.Checked)
        curSelect = SELECT_ALL;
    }
  }
}