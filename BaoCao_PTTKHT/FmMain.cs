using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_PTTKHT
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmQuanLySinhVien a = new FmQuanLySinhVien();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FmQuanLyDiemSinhVienCT a = new FmQuanLyDiemSinhVienCT();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FmQuanLyDiemLopCT a = new FmQuanLyDiemLopCT();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FmQuanLyLop a = new FmQuanLyLop();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FmQuanLyGiangDay a = new FmQuanLyGiangDay();
            a.Show();
        }
    }
}
