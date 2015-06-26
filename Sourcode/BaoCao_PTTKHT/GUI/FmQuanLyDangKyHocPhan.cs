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
    public partial class FmQuanLyDangKyHocPhan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FmQuanLyDangKyHocPhan()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FmThongTinDangKyHocPhanHieuChinh a = new FmThongTinDangKyHocPhanHieuChinh();
            a.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}