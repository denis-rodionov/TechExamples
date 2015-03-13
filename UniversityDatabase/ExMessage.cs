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
    // ���������� �������� ����������
    public static string getMessage(SqlException ex)
    {
      string res;

      switch (ex.Number)
      {
        case 18456:        
          res = "������� ����� ����� ��� ������!";
          break;
        case 17142:
          res = "������ �������������!";
          break;
        case 53:
        case 2:
        case 1231:
          res = "�������� ������������ � �������! ��������� ��������� ����������.";
          break;
        case 547:
          res = "� ������� ������ ������� ������� ������ ������ ������!";
          break;
        default:
          res = "���������� SQL:\r\n" + ex.Message + "\r\nNumber: " + ex.Number.ToString();
          break;
      }

      return res;
    }

    // EXCLAMATION MESSAGE BOX
    public static DialogResult ExclamationYesNo(string msg)
    {
      return MessageBox.Show(msg, "��������������", 
        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

    // EXCLAMATION MESSAGE BOX
    public static DialogResult ExclamationOkCancel(string msg)
    {
      return MessageBox.Show(msg, "��������������",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

    // ERROR MESSAGE BOX
    public static DialogResult Error(string msg)
    {
      return MessageBox.Show(msg, "������",
        MessageBoxButtons.OK, MessageBoxIcon.Error,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

    // INFORMATION MESSAGE BOX
    public static DialogResult Information(string msg)
    {
      return MessageBox.Show(msg, "����������",
        MessageBoxButtons.OK, MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

    // Warning MESSAGE BOX
    public static DialogResult Warning(string msg)
    {
      return MessageBox.Show(msg, "��������",
        MessageBoxButtons.OK, MessageBoxIcon.Warning,
        MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    } 
  }
}
