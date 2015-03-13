using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
    public partial class Timetable : Form
    {
        // CONSTANT
        private const int GRID_LEFT = 5;
        private const int GRID_TOP = 5;

        // VARIABLES
        private Security sec;
        private MyDataGrid grdItems;
        private MyDataGrid grdStudItems;
        private MyDataGrid grdSubItems;
        private DataTable facs, specs;

        private bool isSelectMode;
        public string selectedName;
        public string selectedID;

        /*public frmGroups(Security sec, bool isSelectMode)
    {
      this.sec = sec;
      InitializeComponent();
      this.isSelectMode = isSelectMode;
      btnChoose.Visible = isSelectMode;
      selectedID = null;
      selectedName = null;
      initGrid();
      initStudGrid();
      initSubGrid();
      initCombos();
      showItems();
      initSecurity();
    }*/

        public Timetable(Security sec, bool isSelectMode)
        {
            this.sec = sec;
            InitializeComponent();
            this.isSelectMode = isSelectMode;
            selectedID = null;
            selectedName = null;
            initGrid();
            showItems();
        }

        private void showItems()
        {
            DataTable tb = null;
            tb = selectAll();
            grdItems.setTable(tb, true, 1, 2, 3, 4);
        }

        private DataTable selectAll()
        {
            DataTable tb = SqlAccess.getTable(sec, Query.selectTimetable());

            return tb;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void initGrid()
        {
            grdItems = new MyDataGrid(this, GRID_LEFT, GRID_TOP,
              this.Width - 30, this.Height - 90);
            //grdItems.Click += new EventHandler(grdItems_Click);
            //grdItems.DoubleClick += new EventHandler(btnModify_Click);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}