using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmSpecSubjects : Form
  {
    // VARIABLES
    private Security sec;
    private string specID;
    private string subID;

    // �����������
    public frmSpecSubjects(Security sec, string specID)
    {
      InitializeComponent();
      this.sec = sec;
      this.specID = specID;
    }


    // ���������� ����������
    private void btnOk_Click(object sender, EventArgs e)
    {
      if (subID == null)
      {
        ExMessage.Warning("������� �������� �������������!");
        return;
      }

      int res = SqlAccess.sqlCommand(sec, Query.insertSpecSubject(specID, 
          subID, numHours.Value.ToString()));

      if (res == 0)
        Close();
    }

    // ������ - ������
    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
    
    // ������ - ������� ����������
    private void btnChoose_Click(object sender, EventArgs e)
    {
      frmSubjects frm = new frmSubjects(sec, true);

      if (frm.ShowDialog() == DialogResult.OK)
      {
        edtName.Text = frm.selectedName;
        subID = frm.selectedID;
      }
    }
  }
}