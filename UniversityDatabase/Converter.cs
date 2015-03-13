using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace University
{
  class Converter
  {
    public static Array tableToArray(DataTable tb, int column)
    {
      string[] arr = new string[tb.Rows.Count];

      for (int i = 0; i < tb.Rows.Count; i++)
        arr[i] = tb.Rows[i].ItemArray[column].ToString();

      return arr;
    }
  }
}
