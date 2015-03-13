using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmTeachModify : Form
  {
    public const int STAT_SUCCESS = 0;
    public const int STAT_ERROR = 1;
    public const int STAT_CANCELED = 2;

    private Security sec;
    public DataTable res;
    public int status;
    private int teachID;

    // конструктор для модификации преподавателя
    public frmTeachModify(Security sec, int teachID)
    {
      InitializeComponent();

      this.sec = sec;
      this.teachID = teachID;
      Text = "Изменение данных о преподавателе";
      btnOk.Text = "Изменить";

      if (fillDegreeCombo() == false || fillCathCombo() == false ||            
            fillPostCombo() == false || fillRankCombo() == false ||
            fillValues(teachID) == false)
      {        
        status = STAT_ERROR;
      }
    }

    // конструктор для добавления преподавателя
    public frmTeachModify(Security sec)
    {
      InitializeComponent();

      this.sec = sec;
      this.teachID = -1;
      Text = "Добавление преподавателя";
      btnOk.Text = "Добавить";           

      if (fillDegreeCombo() == false || fillCathCombo() == false ||
          fillPostCombo() == false || fillRankCombo() == false)       
      {        
        status = STAT_ERROR;
      }
    }

    // инициализауия списка должностей
    private bool fillPostCombo()
    {
      cmbPost.DataSource =
          SqlAccess.getArray(sec, 1, Query.selectAllPosts()); ;

      if (cmbPost.DataSource != null && cmbPost.Items.Count != 0)
        cmbPost.SelectedIndex = 0;

      return cmbPost.DataSource == null ? false : true;
    }

    // инициализация списка научных званий
    private bool fillRankCombo()
    {
      cmbRank.DataSource =
          SqlAccess.getArray(sec, 1, Query.selectAllRanks()); ;

      if (cmbRank.DataSource != null && cmbRank.Items.Count != 0)
        cmbRank.SelectedIndex = 0;

      return cmbRank.DataSource == null ? false : true;
    }
    
    // инициализация списка учёных степеней
    private bool fillDegreeCombo()
    {      
      cmbDegrees.DataSource = 
          SqlAccess.getArray(sec, 1, Query.selectAllDegs()); ;

      if (cmbDegrees.DataSource != null && cmbDegrees.Items.Count != 0)
        cmbDegrees.SelectedIndex = 0;

      return cmbDegrees.DataSource == null ? false : true;
    }

    private bool fillCathCombo()
    {
      cmbCaths.DataSource =
          SqlAccess.getArray(sec, 1, Query.selectAllCaths());

      if (cmbCaths.DataSource != null && cmbCaths.Items.Count != 0)
        cmbCaths.SelectedIndex = 0;

      return cmbCaths.DataSource == null ? false : true;
    }

    // заполнение формы с информацией об преподавателе
    private bool fillValues(int id)
    {
      DataTable tb = SqlAccess.getTable(sec, Query.selectTeach(id));

      if (tb == null)
        return false;      

      edtLastName.Text = tb.Rows[0].ItemArray[2].ToString();
      edtFirstName.Text = tb.Rows[0].ItemArray[1].ToString();
      edtThirdName.Text = tb.Rows[0].ItemArray[3].ToString();
      edtPasNO.Text = tb.Rows[0].ItemArray[4].ToString();
      edtAge.Text = tb.Rows[0].ItemArray[6].ToString();
      edtPhone.Text = tb.Rows[0].ItemArray[7].ToString();      
      edtAddress.Text = tb.Rows[0].ItemArray[8].ToString();
      chkCaths.Checked = tb.Rows[0].ItemArray[9].ToString() == "" ?
        false : true;
      if (chkCaths.Checked)
        cmbCaths.SelectedIndex =
          cmbCaths.Items.IndexOf(tb.Rows[0].ItemArray[9]);
      else
        cmbCaths.Enabled = false;
      cmbDegrees.SelectedIndex =
          cmbDegrees.Items.IndexOf(tb.Rows[0].ItemArray[5]);
      cmbPost.SelectedIndex =
          cmbPost.Items.IndexOf(tb.Rows[0].ItemArray[11]);
      cmbRank.SelectedIndex =
          cmbRank.Items.IndexOf(tb.Rows[0].ItemArray[12]); 

      return true;
    }

    // кнопка Добавить/Изменить
    private void btnOk_Click(object sender, EventArgs e)
    {
      if (teachID == -1)    // добавление
        addTeach();
      else
        modifyTeach();      
    }

    // добавление
    private void addTeach()
    {
      string cathName;
      if (chkCaths.Checked)
        cathName = cmbCaths.Text;
      else
        cathName = null;

      int res = SqlAccess.sqlCommand(sec, Query.insertTeach(edtFirstName.Text,
                                                  edtLastName.Text,
                                                  edtThirdName.Text,
                                                  edtAge.Text,
                                                  edtPasNO.Text,
                                                  edtPhone.Text,
                                                  edtAddress.Text,
                                                  cmbDegrees.Text,
                                                  cmbCaths.Text,
                                                  cmbPost.Text,
                                                  cmbRank.Text));
      if (res != -1)
        Close();
    }

    // изменение
    private void modifyTeach()
    {
      string cathName;
      if (chkCaths.Checked)
        cathName = cmbCaths.Text;
      else
        cathName = null;

      int res = SqlAccess.sqlCommand(sec, Query.updateTeach(teachID,
                                                  edtFirstName.Text,
                                                  edtLastName.Text, 
                                                  edtThirdName.Text,
                                                  edtAge.Text,
                                                  edtPasNO.Text, 
                                                  edtPhone.Text,
                                                  edtAddress.Text, 
                                                  cmbDegrees.Text,
                                                  cathName, 
                                                  cmbPost.Text,
                                                  cmbRank.Text));
      if (res != -1)
        Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      status = STAT_CANCELED;
      Hide();
    }

    // флажок - кафедра
    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      cmbCaths.Enabled = chkCaths.Checked;
    }

    private void cmbDegrees_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}