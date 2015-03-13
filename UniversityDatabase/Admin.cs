using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmAdmin : Form
  {
    // VARIABLES
    private Security sec;    

    public frmAdmin(Security sec)
    {
      InitializeComponent();
      this.sec = sec;
      initUserList();      
    }

    // инициализация списка пользователей
    public void initUserList()
    {
      int last = lstUsers.SelectedIndex;
      lstUsers.DataSource = SqlAccess.getArray(sec, 0, Query.selectAllUsers());

      if (last != -1 && last < lstUsers.Items.Count)
        lstUsers.SelectedIndex = last;
      else
        lstUsers.SelectedIndex = 0;
      getInfoAboutCur();
    }

    // отображение информации о выбранном пользователе
    private void getInfoAboutCur()
    {
      string login = lstUsers.SelectedItem.ToString();
      DataTable tb = SqlAccess.getTable(sec, Query.selectRights(login));

      edtLogin.Text = login;
      edtPassword.Text = tb.Rows[0].ItemArray[1].ToString();

      int rights = int.Parse(tb.Rows[0].ItemArray[2].ToString());
      showRights(rights);
    }

    // отображение на форме прав пользователя
    private void showRights(int rights)
    {
      clearChecks();

      if ((rights & Security.FAC) != 0)
        chkFac.Checked = true;
      if ((rights & Security.CATH) != 0)
        chkCath.Checked = true;
      if ((rights & Security.TEACH) != 0)
        chkTeach.Checked = true;
      if ((rights & Security.GROUP) != 0)
        chkGroup.Checked = true;
      if ((rights & Security.STUD) != 0)
        chkStud.Checked = true;
      if ((rights & Security.SUB) != 0)
        chkSub.Checked = true;
      if ((rights & Security.ADMIN) != 0)
        chkAdmin.Checked = true;
    }
    
    // снять флажки на форме
    private void clearChecks()
    {
      chkFac.Checked = false;
      chkCath.Checked = false;
      chkTeach.Checked = false;
      chkGroup.Checked = false;
      chkStud.Checked = false;
      chkStud.Checked = false;
      chkSub.Checked = false;
      chkAdmin.Checked = false;
    }

    // кнопка - выход
    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    // кнопка - добавить
    private void btnAdd_Click(object sender, EventArgs e)
    {
      string login = edtLogin.Text;
      string pas = edtPassword.Text;
      int rights = getRights();

      if (login == "")
      {
        ExMessage.Warning("Введите имя нового пользователя");
        return;
      }

      SqlAccess.sqlCommand(sec, Query.insertUser(login, pas, rights.ToString()));
      initUserList();
    }

    // кнопка - изменить
    private void btnModify_Click(object sender, EventArgs e)
    {
      string login = edtLogin.Text;
      string pas = edtPassword.Text;
      int rights = getRights();

      if (login == "")
      {
        ExMessage.Warning("Выберите изменяемого пользователя");
        return;
      }

      SqlAccess.sqlCommand(sec, Query.updateUser(login, pas, rights.ToString()));
      initUserList();
    }

    // определение введённых прав
    private int getRights()
    {
      int res = 0;

      if (chkFac.Checked)
        res += Security.FAC;
      if (chkCath.Checked)
        res += Security.CATH;
      if (chkTeach.Checked)
        res += Security.TEACH;
      if (chkGroup.Checked)
        res += Security.GROUP;
      if (chkStud.Checked)
        res += Security.STUD;
      if (chkSub.Checked)
        res += Security.SUB;
      if (chkAdmin.Checked)
        res += Security.ADMIN;

      return res;
    }

    private void lstUsers_Click(object sender, EventArgs e)
    {
      getInfoAboutCur();
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
      string login = lstUsers.SelectedItem.ToString();
      SqlAccess.sqlCommand(sec, Query.deleteUser(login));
      initUserList();
    }
  }
}