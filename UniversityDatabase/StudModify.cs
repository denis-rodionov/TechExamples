using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmStudModify : Form
  {
    // VARIABLES
    private Security sec;
    private bool isAdding;
    public bool isReady;
    private DataRow stud;

    // Конструктор для добавления студента
    public frmStudModify(Security sec)
    {
      this.sec = sec;
      initCommon();
      isAdding = true;
      Text = "Добавление студента в базу данных";
      btnOk.Text = "Добавить";
    }

    // Конструктор для изменения данных о студенте
    public frmStudModify(Security sec, DataRow stud)
    {
      this.sec = sec;
      initCommon();
      this.stud = stud;
      isAdding = false;
      btnOk.Text = "Изменить";
      initValues();
    }

    // общие для обоих конструкторов операторы
    private void initCommon()
    {      
      InitializeComponent();
      isReady = true;
      initGroupCombo();
    }

    // инициализация изменяемых значений для студента
    private void initValues()
    {
      edtFirstName.Text = stud.ItemArray[1].ToString();
      edtLastName.Text = stud.ItemArray[2].ToString();
      edtThirdName.Text = stud.ItemArray[3].ToString();
      edtPasNO.Text = stud.ItemArray[4].ToString();
      edtRecordBook.Text = stud.ItemArray[5].ToString();
      numAge.Value = int.Parse(stud.ItemArray[6].ToString());
      edtStartYear.Text = stud.ItemArray[7].ToString();
      edtPhone.Text = stud.ItemArray[8].ToString();
      edtAddress.Text = stud.ItemArray[9].ToString();
      //numCourse.Value = int.Parse(stud.ItemArray[1].ToString());

      if (stud.ItemArray[10].ToString() != "")
        cmbGroup.Text = stud.ItemArray[12].ToString();
      else
      {
        cmbGroup.Enabled = false;
        chkGroup.Checked = false;
      }
      
    }

    // инициализация выпадающего списка
    private void initGroupCombo()
    {
      cmbGroup.DataSource = SqlAccess.getArray(sec, 1, Query.selectAllGroups());

      if (cmbGroup.DataSource == null)
        isReady = false;

      if (cmbGroup.Items.Count > 0)
        cmbGroup.SelectedIndex = 0;
      else
      {
        cmbGroup.Enabled = false;
        chkGroup.Checked = false;
      }


    }

    // кнопка - Отмена
    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    // флажок - группа
    private void chkGroup_CheckedChanged(object sender, EventArgs e)
    {
      if (cmbGroup.Items.Count > 0)
        cmbGroup.Enabled = chkGroup.Checked;
      else
        chkGroup.Checked = false;
    }

    // добавить/изменить
    private void btnOk_Click(object sender, EventArgs e)
    {
      if (isAdding)
        add();
      else
        modify();
    }

    // добачить студента
    private void add()
    {
      string group = "NULL";
      string startYear = edtStartYear.Text;

      if (chkGroup.Checked)
      {
        int g = SqlAccess.getInt(sec, 0, 
          Query.selectGroupByIndex(cmbGroup.SelectedValue.ToString()));

        if (g != -1)
          group = g.ToString();
      }

      if (startYear == "")
        startYear = "NULL";

      int res = SqlAccess.sqlCommand(sec, Query.insertStud(edtFirstName.Text,
                                                 edtLastName.Text,
                                                 edtThirdName.Text,
                                                 edtPasNO.Text, 
                                                 edtRecordBook.Text,
                                                 numAge.Value.ToString(),
                                                 startYear,
                                                 edtPhone.Text, 
                                                 edtAddress.Text,                                   
                                                 group));
      if (res == 0)
        Close();
    }

    // изменить данные о студенте
    private void modify()
    {
      string studID = stud.ItemArray[0].ToString();
      string group = "NULL";
      string startYear = edtStartYear.Text;

      if (chkGroup.Checked)
      {
        int g = SqlAccess.getInt(sec, 0,
          Query.selectGroupByIndex(cmbGroup.SelectedValue.ToString()));

        if (g != -1)
          group = g.ToString();
      }

      if (startYear == "")
        startYear = "NULL";

      int res = SqlAccess.sqlCommand(sec, Query.updateStud(studID,
                                                 edtFirstName.Text,
                                                 edtLastName.Text,
                                                 edtThirdName.Text,
                                                 edtPasNO.Text,
                                                 edtRecordBook.Text,
                                                 numAge.Value.ToString(),
                                                 startYear,
                                                 edtPhone.Text,
                                                 edtAddress.Text,
                                                 group));
      if (res == 0)
        Close();
    }
  }
}