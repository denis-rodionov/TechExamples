using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmSubModify : Form
  {
    // VARIABLES
    public bool isReady;
    private Security sec;
    private DataRow subject;
    private bool isAdding;

    // ����������� ��� ����������
    public frmSubModify(Security sec)
    {
      InitializeComponent();
      isReady = true;
      this.sec = sec;
      isAdding = true;
      Text = "���������� ����������";
      btnOk.Text = "��������";
    }
    
    // ����������� ��� ���������
    public frmSubModify(Security sec, DataRow subject)
    {
      InitializeComponent();
      isReady = true;
      this.sec = sec;
      this.subject = subject;
      initValues();
      isAdding = false;
      Text = "������������� ������ � ����������";
      btnOk.Text = "���������";
    }

    // ������������ �������� ��� ��������� ��������
    public void initValues()
    {
      edtName.Text = subject.ItemArray[1].ToString();
      edtDesc.Text = subject.ItemArray[2].ToString();
    }

    // ������ - ������
    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    // ������ - ��������/��������
    private void btnOk_Click(object sender, EventArgs e)
    {
      if (isAdding)
        add();
      else
        modify();
    }

    // ���������� �������� � �������
    private void add()
    {
      int res = SqlAccess.sqlCommand(sec, Query.insertSubject(edtName.Text,
                                                              edtDesc.Text));

      if (res == 0)
        Close();
    }

    // ��������� ������ � ��������
    private void modify()
    {
      string subID = subject.ItemArray[0].ToString();
      int res = SqlAccess.sqlCommand(sec, Query.updateSubject(subID,
                                                              edtName.Text,
                                                              edtDesc.Text));
      if (res == 0)
        Close();
    }
  }
}