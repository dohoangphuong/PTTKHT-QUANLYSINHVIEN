using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace BaoCao_PTTKHT.GUI
{
    public partial class FmQuanLyHocKy : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FmQuanLyHocKy()
        {
            InitializeComponent();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}