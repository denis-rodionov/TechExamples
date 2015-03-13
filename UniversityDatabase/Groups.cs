using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmGroups : Form
  {
    // CONSTANT
    private const int GRID_LEFT = 5;
    private const int GRID_TOP = 5;

    // VARIABLES
    private Security sec;
    private MyDataGrid grdItems;
    private MyDataGrid grdStudItems;
    private MyDataGrid grdSubItems;
    private DataTable facs, specs;

    private bool isSelectMode;
    public string selectedName;
    public string selectedID;

    public frmGroups(Security sec, bool isSelectMode)
    {
      this.sec = sec;
      InitializeComponent();
      this.isSelectMode = isSelectMode;
      btnChoose.Visible = isSelectMode;
      selectedID = null;
      selectedName = null;
      initGrid();
      initStudGrid();
      initSubGrid();
      initCombos();
      showItems();
      initSecurity();
    }

    // ������������� ������� ������������
    private void initSecurity()
    {
      if (!sec.groupModify)
      {
        btnCreate.Enabled = false;        
        btnModify.Enabled = false;
        btnDelete.Enabled = false;
        btnAddSubject.Enabled = false;
        btnModifySubject.Enabled = false;
        btnDelSubject.Enabled = false;
      }
    }

    // ������������ ������� ���������
    private void initSubGrid()
    {
      grdSubItems = new MyDataGrid(tabPage4, 0, 0,
        tabPage4.Width, btnAddSubject.Top - GRID_TOP);

      if (sec.groupModify)
        grdSubItems.DoubleClick += new EventHandler(btnModifySubject_Click);   
    }

    // ������������� ������� ���������
    private void initStudGrid()
    {
      grdStudItems = new MyDataGrid(tabPage3, 0, 0,
        tabPage3.Width, tabPage3.Height);
    }

    private void initCombos()
    {
      facs = SqlAccess.getTable(sec, Query.selectAllFacs());
      specs = SqlAccess.getTable(sec, Query.selectAllSpecs());

      cmbFac.DataSource = Converter.tableToArray(facs, 1);
      cmbSpec.DataSource = Converter.tableToArray(specs, 1);

      if (cmbFac.Items.Count > 0)
        cmbFac.SelectedIndex = 0;

      if (cmbSpec.Items.Count > 0)
        cmbSpec.SelectedIndex = 0;

      cmbFac.Enabled = false;
      cmbSpec.Enabled = false;
    }

    private void initGrid()
    {
      grdItems = new MyDataGrid(this, GRID_LEFT, GRID_TOP,
        tabControl1.Left - 5 - GRID_LEFT, ClientSize.Height - 5 - GRID_TOP);
      grdItems.Click += new EventHandler(grdItems_Click);
      grdItems.DoubleClick += new EventHandler(btnModify_Click);   
    }

    // ����������� ��������� � ������� ��������� ������
    private void getInfoAboutCur()
    {
      if (!grdItems.notSelected())
      {
        DataTable tb = grdItems.getTable();
        int index = grdItems.getCurrentIndex();

        edtIndex.Text = tb.Rows[index].ItemArray[1].ToString();
        edtCourse.Text = tb.Rows[index].ItemArray[2].ToString();
        edtSpec.Text = tb.Rows[index].ItemArray[3].ToString();
        edtCurator.Text = tb.Rows[index].ItemArray[5].ToString() + " " +
                          tb.Rows[index].ItemArray[4].ToString() + " " +
                          tb.Rows[index].ItemArray[6].ToString();
        edtFac.Text = tb.Rows[index].ItemArray[9].ToString();
        edtStudCount.Text = tb.Rows[index].ItemArray[10].ToString();

        // ���������� ������ ��������� ������
        DataTable studs =
          SqlAccess.getTable(sec, Query.selectStudsByGroup(tb.Rows[index].ItemArray[1].ToString()));
        grdStudItems.setTable(studs, true, 1, 2, 3);

        // ���������� ������ ��������� ������
        DataTable subjects = SqlAccess.getTable(sec, Query.selectSubjectsByGroup(
            tb.Rows[index].ItemArray[0].ToString()));
        grdSubItems.setTable(subjects, true, 1, 3);
      }
      else
      {
        edtIndex.Text = "---";
        edtSpec.Text = "";
        edtCourse.Text = "";
        edtCurator.Text = "";
        edtFac.Text = "";
        edtStudCount.Text = "";
      }      
    }

    // ���� �� �������
    private void grdItems_Click(object sender, EventArgs e)
    {
      getInfoAboutCur();
    }

    // �������
    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    // ���������� ������
    private void btnCreate_Click(object sender, EventArgs e)
    {
      frmGroupModify frm = new frmGroupModify(sec);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // ����������� ������
    private void btnModify_Click(object sender, EventArgs e)
    {
      if (grdItems.notSelected())
        return;

      int index = grdItems.getCurrentIndex();
      frmGroupModify frm = 
        new frmGroupModify(sec, grdItems.getTable().Rows[index]);

      if (frm.isReady)
      {
        frm.ShowDialog();
        showItems();
      }
    }

    // �������� ������
    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (!grdItems.notSelected())
      {
        int groupID = grdItems.getIDOfSelected(); 

        SqlAccess.sqlCommand(sec, Query.deleteGroup(groupID));

        showItems();
      }
    }

    private void radBySpec_CheckedChanged(object sender, EventArgs e)
    {
      cmbSpec.Enabled = radBySpec.Checked;
    }

    private void rabByFac_CheckedChanged(object sender, EventArgs e)
    {
      cmbFac.Enabled = radByFac.Checked;
    }

    // ������ - �������
    private void btnSelect_Click(object sender, EventArgs e)
    {
      showItems();
    }

    // ���������� ������ �� �������� ������ �������
    private void showItems()
    {
      DataTable tb = null;

      if (radAllGroups.Checked)     // ��� �������      
        tb = selectAll();
      else if (radBySpec.Checked)   // ������� �� ��������������
        tb = selectBySpec();
      else if (radByFac.Checked)    // ������� �� ����������
        tb = selectByFac();
      else
        ExMessage.Warning("�� ����� ����� �������");

      grdItems.setTable(tb, true, 1, 2, 3);
      getInfoAboutCur();
    }

    // ������� ��� ������
    private DataTable selectAll()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectAllGroups());

      return tb;     
    }

    // ������� ������ �� ����������� �������������
    private DataTable selectBySpec()
    {
      string specName = cmbSpec.SelectedValue.ToString();
      DataTable tb = SqlAccess.getTable(sec, Query.selectGroupsBySpec(specName));

      return tb;
    }

    // ������� ������ �� ������������ ����������
    private DataTable selectByFac()
    {
      string facName = cmbFac.SelectedValue.ToString();
      DataTable tb = SqlAccess.getTable(sec, Query.selectGroupsByFac(facName));

      return tb;
    }

    // ������ - ������� (����������)
    private void btnChoose_Click(object sender, EventArgs e)
    {
      selectedID = grdItems.getIDOfSelected().ToString();
      selectedName = grdItems.getObjectOfSelectedRow(1);
    }

    // ������ - �������� (����������)
    private void btnAddSubject_Click(object sender, EventArgs e)
    {
      string groupID = grdItems.getIDOfSelected().ToString();
      frmAssignSubject frm = new frmAssignSubject(sec, null, groupID, null);

      frm.ShowDialog();
      getInfoAboutCur();
    }


    // ������ - �������� (����������)
    private void btnModifySubject_Click(object sender, EventArgs e)
    {
      string groupID = grdItems.getIDOfSelected().ToString();
      string subID = grdSubItems.getIDOfSelected().ToString();
      string teachID = grdSubItems.getObjectOfSelectedRow(4).ToString();
      frmAssignSubject frm = new frmAssignSubject(sec, subID, groupID, teachID);

      frm.ShowDialog();
      getInfoAboutCur();
    }

    // ������ - ������� (����������)
    private void btnDelSubject_Click(object sender, EventArgs e)
    {
      string subID = grdSubItems.getIDOfSelected().ToString();
      string groupID = grdItems.getIDOfSelected().ToString();
      string teachID = grdSubItems.getObjectOfSelectedRow(4).ToString();

      if (subID == "-1" || groupID == "-1" || teachID == "-1")
      {
        ExMessage.Warning("�������� ����������");
      }
      else
      {
        SqlAccess.sqlCommand(sec, Query.deleteTeachSubject(subID, groupID, teachID));
        getInfoAboutCur();
      }
    }
  }
}