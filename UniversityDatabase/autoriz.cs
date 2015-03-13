using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  using System.Data;
  using System.Data.SqlClient;

  //-------------------------------------------------------------------
  // Форма авторизации
  //-------------------------------------------------------------------
  public partial class frmAutoriz : Form
  {
    private const string SERVER = "Derow";
    private const string SERVER_NB = "NB-ASUS";
    private const string SERVER_STANTION2 = "Station2";
    private const string DATA_BASE = "University";

    //private const int SERVER_STOPED = 2;
    //private const int SERVER_PAUSED = 17142;
    //private const int WRONG_LOG_OR_PAS = 18456;

    public frmAutoriz()
    {
      InitializeComponent();
      initFormData();
    }

    // инициализация значений по умолчанию
    private void initFormData()
    {
      edtLogin.Text = "adm";
      edtPas.Text = "adm";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Close();
    }

    // Кнопка авторизации
    private void btnGetIn_Click(object sender, EventArgs e)
    {
      // Security secDEROW = new Security(edtLogin.Text, edtPas.Text, DATA_BASE, SERVER);
      // Security secNB = new Security(DATA_BASE, SERVER_NB);
      // Security secStantion2 = new Security(DATA_BASE, SERVER_STANTION2);
      Security secLOCAL = new Security(edtLogin.Text, edtPas.Text);
      Security sec = secLOCAL;

      SqlConnection cn = new SqlConnection();
      cn.ConnectionString = sec.getConnStr();

      try
      {
        cn.Open();
        cn.Close();
        sec.autorize();
        showMainForm(sec);        
      }
      catch (SqlException ex)
      {
        MessageBox.Show(ExMessage.getMessage(ex), "Ошибка");
      }
      catch (Exception ex1)
      {
        ExMessage.Error(ex1.Message);
      }
    }

    // Создать строку соединения в сответствии с данными авторизации
    //private string getConString(string login, string password)
    //{
    //  return CONNECT_STR + "User ID=" + login + ";Password=" + password;
    //}

    private void showMainForm(Security sec)
    {
      this.Hide();
      frmStartImage img = new frmStartImage();
      img.ShowDialog();
      frmMain form = new frmMain(sec);      
      form.ShowDialog();
      Close();
    }
  }

  //---------------------------------------------------------------
  // Класс авторизации
  //---------------------------------------------------------------
  public class Security
  {
    // CONSTANTS
    private const string SQL_LOGIN = "dev";
    private const string SQL_PASSWORD = "dev";
    private const string DATA_SOURCE = ".";
    private const string DATA_BASE = "University";

    // права на модификацию сущностей
    public const int FAC =   0x1;
    public const int CATH = 0x2;
    public const int TEACH = 0x4;
    public const int GROUP = 0x8;
    public const int STUD = 0x10;
    public const int SUB = 0x20;
    public const int ADMIN = 0x40;

    // VARIABLES
    private string _login;
    private string _password;
    private bool winAutoriz;
      private int rights;

    // Конструктор
    public Security(string login, string password)
    {
      _login = login;
      _password = password;
      winAutoriz = true;
      rights = 0;
    }

    // авторизироваться
    public void autorize()
    {
      DataTable tb = SqlAccess.getTable(this, Query.selectRights(login));

      if (tb == null || tb.Rows.Count == 0)
      {
        throw new Exception("Не найден пользователь с таким именем");
      }
      else if (tb.Rows[0].ItemArray[1].ToString() != password)
      {
        throw new Exception("Неверный пароль!");
      }
      else
        rights = int.Parse(tb.Rows[0].ItemArray[2].ToString());
    }

    /// <summary>
    /// можно ли редактировать факультеты
    /// </summary>
    public bool facModify
    {
      get { return (rights & FAC) == 0 ? false : true; }
    }

    /// <summary>
    /// можно ли редактировать кафедры
    /// </summary>
    public bool cathModify
    {
      get { return (rights & CATH) == 0 ? false : true; }
    }

    /// <summary>
    /// можно ли редактировать данные о преподавателях
    /// </summary>
    public bool teachModify
    {
      get { return (rights & TEACH) == 0 ? false : true; }
    }

    /// <summary>
    /// можноли редактировать данные о группах
    /// </summary> 
    public bool groupModify
    {
      get { return (rights & GROUP) == 0 ? false : true; }
    }

    /// <summary>
    /// можно ли редактировать данные о студентах
    /// </summary>
    public bool studModify
    {
      get { return (rights & STUD) == 0 ? false : true; }
    }

    /// <summary>
    /// можно ли редактировать данные о дисциплинах
    /// </summary>
    public bool SubModify
    {
      get { return (rights & SUB) == 0 ? false : true; }
    }

    /// <summary>
    /// Администраторские права
    /// </summary>
    public bool isAdmin
    {
      get { return (rights & ADMIN) == 0 ? false : true; }
    }

    public string getConnStr()
    {
      string res;
      if (winAutoriz)
      {
        res =  "Data Source=" + DATA_SOURCE +
               ";Initial Catalog=" + DATA_BASE +
               ";Integrated Security=True";
      }
      else
      {
        res =  "Data Source=" + DATA_SOURCE +
               ";Initial Catalog=" + DATA_BASE +
               ";Persist Security Info=True;" +
               "User ID=" + SQL_LOGIN +
               ";Password=" + SQL_PASSWORD;
      }

      return res;
    }

    public string login
    {
      get { return _login; }
    }

    public string password
    {
      get { return _password; }
    }
  }
}