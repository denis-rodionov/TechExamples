using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmFacModify : Form
  {
    private Security sec;
    private int facID;
    private int headID;
    private bool isAdding;
    public bool isReady;

    // Конструктор для добавления факультета
    public frmFacModify(Security sec)
    {
      this.sec = sec;
      initCommon();
      facID = -1;
      headID = -1;
      Text = "Добавление нового факультета";
      btnOk.Text = "Добавить";
      isAdding = true;
      checkTeachs();
    }

    // конструктор для изменения факультета
    public frmFacModify(Security sec, int facID, int headID)
    {
      this.sec = sec;
      initCommon();      
      this.facID = facID;
      this.headID = headID;
      Text = "Изменение существующего факультета";
      btnOk.Text = "Изменить";
      isAdding = false;
      initValues();
    }

    private void initCommon()
    {
      isReady = true;       // изначально, впоследствии иннициализации может измениться
      InitializeComponent();
    }

    // для модификации: задание начальных параметров
    private void initValues()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectFac(facID));

      edtName.Text = tb.Rows[0].ItemArray[1].ToString();
      edtDesc.Text = tb.Rows[0].ItemArray[2].ToString();
      edtHead.Text = tb.Rows[0].ItemArray[3].ToString() + " " +
                     tb.Rows[0].ItemArray[4].ToString() + " " +
                     tb.Rows[0].ItemArray[5].ToString();
    }

    private void checkTeachs()
    {
      int count = SqlAccess.getInt(sec, 0, Query.countOfTeachs());
      isReady = count > 0;
      if (count == 0)
        ExMessage.Warning("Сперва добавьте преподавателя для назначения декана факультета");
    }

    private void btnSelectHead_Click(object sender, EventArgs e)
    {
      frmTeachers frm = new frmTeachers(sec, true);

      if (frm.ShowDialog() == DialogResult.OK)
      {
        headID = frm.selectedID;
        showHead();
      }
    }

    private void showHead()
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectTeach(headID));

      edtHead.Text = tb.Rows[0].ItemArray[2].ToString() + " " +
                     tb.Rows[0].ItemArray[1].ToString() + " " +
                     tb.Rows[0].ItemArray[3].ToString();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      if (isAdding)
        addFac();
      else
        modifyFac();
    }

    private void addFac()
    {
      if (headID == -1)
      {
        ExMessage.Error("Укажите декана кафедры!");
        return;
      }

      SqlAccess.sqlCommand(sec, Query.insertFac(edtName.Text,
                                                edtDesc.Text,
                                                headID));
      Close();
    }

    private void modifyFac()
    {
      SqlAccess.sqlCommand(sec, Query.updateFac(facID, 
                                                edtName.Text,
                                                edtDesc.Text,
                                                headID));
      Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

  }
}