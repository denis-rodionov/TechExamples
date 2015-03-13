using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace University
{
  public partial class frmStartImage : Form
  {
    public frmStartImage()
    {
      InitializeComponent();
    }

    private void frmStartImage_Load(object sender, EventArgs e)
    {
      
    }

    private void frmStartImage_Shown(object sender, EventArgs e)
    {
      
    }

    private void frmStartImage_FormClosing(object sender, FormClosingEventArgs e)
    {
      
    }

    private void imgMain_LoadCompleted(object sender, AsyncCompletedEventArgs e)
    {
      
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      Close();
    }
  }
}