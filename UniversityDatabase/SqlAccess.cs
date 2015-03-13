using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace University
{
  class SqlAccess
  {
    // ������, ������������ �������
    public static DataTable getTable(Security sec, string query)
    {
      DataTable res = new DataTable();

      SqlConnection cn = new SqlConnection(sec.getConnStr());

      try
      {
        cn.Open();
        SqlDataAdapter dAdapt = new SqlDataAdapter(query, cn);        
        dAdapt.Fill(res);        
        cn.Close();
      }
      catch (SqlException ex)
      {
        ExMessage.Error(ExMessage.getMessage(ex));
        res = null;
      }

      return res;
    }

    

    public static Array getArray(Security sec, int col, string query)
    {
      DataTable tb = getTable(sec, query);

      if (tb == null)
        return null;

      string[] res = new string[tb.Rows.Count];   



      for (int i = 0; i < res.Length; i++)
        res[i] = tb.Rows[i].ItemArray[col].ToString();

      return res;
    }

    // ���������� SQL �������
    public static int sqlCommand(Security sec, string query)
    {
      SqlConnection cn = new SqlConnection(sec.getConnStr());
      SqlCommand com = new SqlCommand(query, cn);
      try
      {
        cn.Open();
        com.ExecuteNonQuery();
        cn.Close();
      }
      catch (SqlException ex)
      {
        ExMessage.Error(ExMessage.getMessage(ex));
        return -1;
      }

      return 0;
    }

    // ���������� ����� �� ������ ������ ���������� �������
    public static int getInt(Security sec, int col, string query)
    {
      DataTable tb = getTable(sec, query);

      if (tb == null || tb.Rows.Count == 0)
        return -1;

      int res = int.Parse(tb.Rows[0].ItemArray[col].ToString());

      return res;
    }

    // ���������� ������(������) �� ������ ������ ���������� �������
    public static string getString(Security sec, int col, string query)
    {
      DataTable tb = getTable(sec, query);

      if (tb == null || tb.Rows.Count == 0)
        return null;

      string res = tb.Rows[0].ItemArray[col].ToString();

      return res;
    }
  }
}
