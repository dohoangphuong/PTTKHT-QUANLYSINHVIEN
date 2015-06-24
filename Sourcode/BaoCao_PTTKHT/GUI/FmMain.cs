using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_PTTKHT.GUI
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

        private void button6_Click(object sender, EventArgs e)
        {
            FmQuanLyGiangVien a = new FmQuanLyGiangVien();
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FmQuanLyMonHoc a = new FmQuanLyMonHoc();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FmQuanLyMonHocTienQuyet a = new FmQuanLyMonHocTienQuyet();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FmQuanLyDangKyHocPhan a = new FmQuanLyDangKyHocPhan();
            a.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FmQuanLy a = new FmQuanLy();
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FmThongTinDangKyHocPhan a = new FmThongTinDangKyHocPhan();
            a.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FmThongTinDangKyHocPhanHieuChinh a = new FmThongTinDangKyHocPhanHieuChinh();
            a.Show();
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            FmConnectDatabase fmConnectDatabase = new FmConnectDatabase();
            fmConnectDatabase.Show();
        }
    }
}
