using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace University
{
  class ExMessage
  {
    // возвращает описание исключения
    public static string getMessage(SqlException ex)
    {
      string res;

      switch (ex.Number)
      {
        case 18456:        
          res = "Неверно задан логин или пароль!";
          break;
        case 17142:
          res = "Сервер приостановлен!";
          break;
        case 53:
        case 2:
        case 1231:
          res = "Неудаётся подключиться к серверу! Проверьте параметры соединения.";
          break;
        case 547:
          res = "С записью данной таблицы связаны записи других таблиц!";
          break;
        default:
          res = "Исключение SQL:\r\n" + ex.Message + "\r\nNumber: " + ex.Number.ToString();
          break;
      }

      return res;
    }

    // EXCLAMATION MESSAGE BOX
    public static DialogResult ExclamationYesNo(string msg)
    {
      return MessageBox.Show(msg, "Предупреждение", 
        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

    // EXCLAMATION MESSAGE BOX
    public static DialogResult ExclamationOkCancel(string msg)
    {
      return MessageBox.Show(msg, "Предупреждение",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

    // ERROR MESSAGE BOX
    public static DialogResult Error(string msg)
    {
      return MessageBox.Show(msg, "Ошибка",
        MessageBoxButtons.OK, MessageBoxIcon.Error,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

    // INFORMATION MESSAGE BOX
    public static DialogResult Information(string msg)
    {
      return MessageBox.Show(msg, "Информация",
        MessageBoxButtons.OK, MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

    // Warning MESSAGE BOX
    public static DialogResult Warning(string msg)
    {
      return MessageBox.Show(msg, "Внимание",
        MessageBoxButtons.OK, MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    } 
  }
}
