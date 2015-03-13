using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace University
{
  class MyDataGrid : DataGridView
  {
    DataTable cur;

    // Конструктор
    public MyDataGrid(Control prnt, int x, int y, int width, int height) : base()
    {
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      Location = new Point(x, y);
      Name = "grdItems";
      Size = new Size(width, height);
      TabIndex = 6;
      Visible = true;
      EditMode = DataGridViewEditMode.EditProgrammatically;
      AllowUserToResizeColumns = false;
      AllowUserToResizeRows = false;
      RowTemplate.Height = 15;
      prnt.Controls.Add(this);
      
      RowHeadersVisible = false;
      SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    // очистка
    public void clear()
    {
      cur = null;      
      this.Rows.Clear();
    }

    // возвращает таблицу данных
    public DataTable getTable()
    {
      return cur;
    }       

    // заполнение данными
    public void setTable(DataTable tb, bool isNumerate, params int[] allowCol)
    {
      clear();
      cur = tb;

      if (cur == null)
        return;

      this.RowCount = tb.Rows.Count == 0 ? 1 : tb.Rows.Count;
      this.ColumnCount = allowCol.Length; ;
      SelectionMode = DataGridViewSelectionMode.FullRowSelect;

      // названия столбцов
      for (int i = 0, k = 0; i < tb.Columns.Count; i++)
        if (isInArray(i, allowCol))
          Columns[k++].HeaderCell.Value = tb.Columns[i].ColumnName.ToString();    

      if (tb.Rows.Count == 0)
        return;

      if (isNumerate)
      {
        this.RowHeadersVisible = true;
        this.RowHeadersWidthSizeMode = 
          DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        this.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
        for (int i = 0; i < tb.Rows.Count; i++)
          Rows[i].HeaderCell.Value = Convert.ToString(i + 1);
      }
      else
      {        
        this.RowHeadersVisible = false;
      }

      for (int i = 0, k = 0; i < tb.Columns.Count; i++)
        if (isInArray(i, allowCol))
        {
          for (int j = 0; j < tb.Rows.Count; j++)
            Rows[j].Cells[k].Value = tb.Rows[j].ItemArray[i].ToString();
          k++;
        }

      if (cur.Rows.Count > 0)
        this.SetCurrentCellAddressCore(0, 0, false, false, false);
        
    }

    public int getIDOfSelected()
    {
      string str = getObjectOfSelectedRow(0);
      int res = -1;
      if (str != null)
        res = int.Parse(str);
      return res;
    }

    public bool notSelected()
    {
      return CurrentRow == null || cur == null || cur.Rows.Count == 0 
        ? true : false;
    }

    private bool isInArray(int value, int[] array)
    {
      bool res = false;

      for (int i = 0; i < array.Length; i++)
        if (array[i] == value)
        {
          res = true;
          break;
        }

      return res;
    }

    // задаёт нумерацию строк в заголовке каждого столбца
    public void setNumeration()
    {
      RowHeadersVisible = true;

      for (int i = 0; i < RowCount; i++)
        Rows[i].HeaderCell.Value = i;
    }

    // задаёт количество колонок
    public int columnCount
    {
      set 
      { 
        ColumnCount = value;         
      }
    }

    private void InitializeComponent()
    {
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      this.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
      this.ResumeLayout(false);

    }

    // возвращает любой элемент выбранной строки
    public string getObjectOfSelectedRow(int col)
    {
      if (notSelected())
        return null;

      return cur.Rows[CurrentRow.Index].ItemArray[col].ToString();
    }

    // возврашает внутренний индекс выбранной записи
    public int getCurrentIndex()
    {
      int res = -1;
      int cur = this.CurrentRow.Index;
      int curHeader = int.Parse(this.Rows[cur].HeaderCell.Value.ToString());
      if (cur == curHeader-1)
        res = cur;
      else
        res = curHeader - 1;

      return res;
    }
  }
}
