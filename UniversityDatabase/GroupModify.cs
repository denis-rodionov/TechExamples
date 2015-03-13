using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmGroupModify : Form
  {
    // VARIABLES
    private Security sec;
    public bool isReady;
    private DataRow group;    // ������ ��� ���������
    private int curatorID;
    private bool isAdding;

    // ����������� ����������
    public frmGroupModify(Security sec)
    {
      InitializeComponent();
      this.sec = sec;
      isReady = true;
      group = null;
      initComboSpec();
      Text = "�������� ������";
      btnOk.Text = "��������";
      curatorID = -1;
      isAdding = true;
    }

    // ����������� ���������
    public frmGroupModify(Security sec, DataRow group)
    {
      InitializeComponent();
      this.sec = sec;
      isReady = true;
      this.group = group;
      initComboSpec();
      Text = "�������� ������";
      btnOk.Text = "��������";
      curatorID = -1;
      initValues();
      isAdding = false;
    }

    // ������������� ���������� ������ ��� ���������
    private void initValues()
    {
      edtIndex.Text = group.ItemArray[1].ToString();

      if (group.ItemArray[7].ToString() == "")  //��� ��������
      {
        chkCurator.Checked = false;
        btnSelectTeach.Enabled = false;
      }
      else
      {
        chkCurator.Checked = true;
        btnSelectTeach.Enabled = true;
        edtCurator.Text = group.ItemArray[5].ToString() + " " +
                          group.ItemArray[4].ToString() + " " +
                          group.ItemArray[6].ToString();
        curatorID = int.Parse(group.ItemArray[7].ToString());
      }

      numCourse.Value = int.Parse(group.ItemArray[2].ToString());

      if (group.ItemArray[3].ToString() == "")  // ��� �������������
      {
        chkSpec.Checked = false;
        cmbSpec.Enabled = false;
      }
      else
      {
        chkSpec.Checked = true;
        cmbSpec.Enabled = true;
        cmbSpec.Text = group.ItemArray[3].ToString();
      }
    }

    // ������ ��������������
    private void initComboSpec()
    {
      Array arr = SqlAccess.getArray(sec, 1, Query.selectAllSpecs());
      cmbSpec.DataSource = arr;

      if (arr == null)
        isReady = false;
      else if (arr.Length == 0)
      {
        isReady = false;
        ExMessage.Error("� ���� ������ �� ���������� �� ����� �������������");
      }
      else
        cmbSpec.SelectedIndex = 0;
    }

    // ������ - �������
    private void chkCurator_CheckedChanged(object sender, EventArgs e)
    {
      btnSelectTeach.Enabled = chkCurator.Checked;
    }

    // ������ - �������������
    private void chkSpec_CheckedChanged(object sender, EventArgs e)
    {
      cmbSpec.Enabled = chkSpec.Checked;
    }

    // ������ ��������/��������
    private void btnOk_Click(object sender, EventArgs e)
    {
      if (isAdding)
        addGroup();
      else
        modifyGroup();
    }

    // ������ - ������� ��������
    private void btnSelectTeach_Click(object sender, EventArgs e)
    {
      frmTeachers frm = new frmTeachers(sec, true);

      if (frm.ShowDialog() == DialogResult.OK)
      {
        curatorID = frm.selectedID;
        showCurator();
      }
    }

    // ���������� ��������
    private void showCurator()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectTeach(curatorID));

      if (tb == null || tb.Rows.Count == 0)
        return;

      edtCurator.Text = tb.Rows[0].ItemArray[2].ToString() + " " +
                        tb.Rows[0].ItemArray[1].ToString() + " " +
                        tb.Rows[0].ItemArray[3].ToString();
    }

    // ������
    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    // ���������� ������
    private void addGroup()
    {
      string curator = "NULL";
      if (chkCurator.Checked && curatorID != -1)
        curator = curatorID.ToString();

      string spec = chkSpec.Checked ? cmbSpec.Text : "NULL";

      SqlAccess.sqlCommand(sec, Query.insertGroup(edtIndex.Text,
                                                  curator, spec, 
                                                  numCourse.Value.ToString()));
      Close();
    }

    // ��������� ������
    private void modifyGroup()
    {
      string curator = "NULL";
      if (chkCurator.Checked && curatorID != -1)
        curator = curatorID.ToString();

      string spec = chkSpec.Checked ? cmbSpec.Text : "NULL";

      SqlAccess.sqlCommand(sec, Query.updateGroup(group.ItemArray[0].ToString(),
                                                  edtIndex.Text,
                                                  curator, spec, 
                                                  numCourse.Value.ToString()));
      Close();
    }
  }
}