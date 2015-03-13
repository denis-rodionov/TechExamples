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

    // ����������� ��� ��������� �������
    public frmCathModify(Security sec, int cathID)
    {
      this.sec = sec;
      commonInit();      
      isAdding = false;
      this.cathID = cathID;
      Text = "��������� �������";
      btnOk.Text = "��������";
      initCombo();
      initValues();
    }

    // ����������� ��� �������� �������
    public frmCathModify(Security sec)
    {
      this.sec = sec;
      commonInit();
      isAdding = true;      
      Text = "���������� �������";
      initCombo();
      checkTeachs();
      btnOk.Text = "��������";
    }

    private void commonInit()
    {
      InitializeComponent();
      headID = -1;
      isReady = true;     // ����������, ���� ����� �� ������� ���� ����      
    }

    // ������������� ������� �������� ������� ��� � �����������
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

    // ��������� ������� � ���� ������ ��������, �����
    // ���-�� ��� ���������� �������
    private void checkTeachs()
    {
      int count = SqlAccess.getInt(sec, 0, Query.countOfTeachs());

      if (count == 0)
      {
        isReady = false;
        ExMessage.Error("�������� � ���� ������ �������������, ����� " +
            "��������� ����� ��������!");
      }
    }

    // ������������� ������ �����������
    private void initCombo()
    {
      facTable = new DataTable();
      facTable = SqlAccess.getTable(sec, Query.selectAllFacs());      

      if (facTable.Rows.Count == 0)
      {
        ExMessage.Error("�� ������� �� ������ �����������!");
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

    // ����� ������������� �� ����� ����������� ��������
    private void button3_Click(object sender, EventArgs e)
    {
      frmTeachers frm = new frmTeachers(sec, true);

      if (frm.ShowDialog() == DialogResult.OK)
      {
        headID = frm.selectedID;
        showHead();
      }
    }

    // ���������� ����������
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

    // ���������� �������
    private void addCath()
    {
      if (headID == -1)
      {
        ExMessage.Error("������� ����������� ��������!");
        return;
      }

      int facID = 
        int.Parse(facTable.Rows[cmbFacs.SelectedIndex].ItemArray[0].ToString());

      if (facID == -1)
      {
        ExMessage.Error("��������� �� ������!");
        return;
      }
      
      SqlAccess.sqlCommand(sec, Query.insertCath(edtName.Text,
                                                 edtIndex.Text,
                                                 edtDesc.Text,
                                                 headID, facID));      
      Close();
    }

    // ����������� �������
    private void modifyCath()
    {
      int facID =
        int.Parse(facTable.Rows[cmbFacs.SelectedIndex].ItemArray[0].ToString());

      if (facID == -1)
      {
        ExMessage.Error("��������� �� ������!");
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