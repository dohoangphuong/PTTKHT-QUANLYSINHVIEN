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
    public partial class FmQuanLy : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        #region Khởi tạo
        private int _quyen = -1;
        public FmQuanLy()
        {
            InitializeComponent();
            DangNhap();
            //_quyen = 0;
            //KhoiTaoChucNang();
        }
        #endregion
        #region QUAN LY, PHÂN QUYỀN
        private void DN_Click(object sender, EventArgs e)
        {
            DangNhap();

        }
        #region Đăng nhập
        private void DangNhap()
        {
            try
            {
               // _quyen = 0;
                FmDangNhap idangnhap = new FmDangNhap();
                idangnhap.ShowDialog();
                int iquyen = idangnhap.Quyen();
                _quyen = iquyen;
              
              //  KhoiTaoChucNang();
            }
            catch { }
        }
        #endregion
        #endregion

        #region Khởi tạo chức năng cho từng loại tài khoản
        private void KhoiTaoChucNang()
        {
            try
            {
                switch (_quyen)
                {
                    case -1://thoat ép buộc
                        nh.Enabled = false;
                        hk.Enabled = false;
                        mh.Enabled = false;
                        mtq.Enabled = false;
                        sv.Enabled = false;
                        lk.Enabled = false;
                        lh.Enabled = false;
                        gv.Enabled = false;
                        bdl.Enabled = false;
                        gd.Enabled = false;
                        dk.Enabled = false;
                        ttdk.Enabled = false;
                        hcdk.Enabled = false;
                        PhanQuyen.Enabled = false;
                        
                        break;
                    case 0://ADmin
                        nh.Enabled = false;
                        hk.Enabled = false;
                        mh.Enabled = false;
                        mtq.Enabled = false;
                        sv.Enabled = true;
                        lk.Enabled = false;
                        lh.Enabled = false;
                        bdsv.Enabled = false;
                        gv.Enabled = false;
                        bdl.Enabled = false;
                        gd.Enabled = false;
                        dk.Enabled = false;
                        ttdk.Enabled = false;
                        hcdk.Enabled = false;
                        PhanQuyen.Enabled = true;
                        break;
                    case 1://SV
                        nh.Enabled = false;
                        hk.Enabled = false;
                        mh.Enabled = false;
                        mtq.Enabled = false;
                        sv.Enabled = true;
                        lk.Enabled = true;
                        lh.Enabled = true;
                        bdsv.Enabled = true;
                        gv.Enabled = false;
                        bdl.Enabled = true;
                        gd.Enabled = false;
                        dk.Enabled = true;
                        ttdk.Enabled = true;
                        hcdk.Enabled = true;
                        PhanQuyen.Enabled = false;
                        break;
                    case 2://GV
                        nh.Enabled = false;
                        hk.Enabled = false;
                        mh.Enabled = false;
                        mtq.Enabled = false;
                        sv.Enabled = true;
                        lk.Enabled = false;
                        lh.Enabled = false;
                        bdsv.Enabled = false;
                        gv.Enabled = false;
                        bdl.Enabled = false;
                        gd.Enabled = false;
                        dk.Enabled = false;
                        ttdk.Enabled = true;
                        hcdk.Enabled = false;
                        PhanQuyen.Enabled = false;
                        break;
                    case 3://Cán bộ
                        nh.Enabled = false;
                        hk.Enabled = false;
                        mh.Enabled = false;
                        mtq.Enabled = false;
                        sv.Enabled = true;
                        lk.Enabled = false;
                        lh.Enabled = false;
                        bdsv.Enabled = false;
                        gv.Enabled = true;
                        bdl.Enabled = true;
                        gd.Enabled = true;
                        dk.Enabled = false;
                        ttdk.Enabled = false;
                        hcdk.Enabled = false;
                        PhanQuyen.Enabled = false;
                        break;
                    case 4://khác
                        nh.Enabled = false;
                        hk.Enabled = false;
                        mh.Enabled = false;
                        mtq.Enabled = false;
                        sv.Enabled = true;
                        lk.Enabled = false;
                        lh.Enabled = false;
                        bdsv.Enabled = false;
                        gv.Enabled = false;
                        bdl.Enabled = false;
                        gd.Enabled = false;
                        dk.Enabled = false;
                        ttdk.Enabled = false;
                        hcdk.Enabled = false;
                        PhanQuyen.Enabled = false;
                        break;
                }
            }
            catch { }
        }
        #endregion

        private void PhanQuyen_Click(object sender, EventArgs e)
        {
            FmQuanLyTaiKhoan a = new FmQuanLyTaiKhoan();
            a.ShowDialog();
        }

        private void nh_Click(object sender, EventArgs e)
        {
            FmQuanLyNamHoc a = new FmQuanLyNamHoc();
            a.ShowDialog();
        }

        private void hk_Click(object sender, EventArgs e)
        {
            FmQuanLyHocKy a = new FmQuanLyHocKy();
            a.ShowDialog();
        }

        private void mtq_Click(object sender, EventArgs e)
        {
            FmQuanLyMonHocTienQuyet a = new FmQuanLyMonHocTienQuyet();
            a.ShowDialog();
        }

        private void mh_Click(object sender, EventArgs e)
        {
            FmQuanLyMonHoc a = new FmQuanLyMonHoc();
             a.ShowDialog();
        }

        private void sv_Click(object sender, EventArgs e)
        {
            FmQuanLySinhVien a = new FmQuanLySinhVien();
            a.ShowDialog();
        }

        private void lk_Click(object sender, EventArgs e)
        {
            FmQuanLyLopKhoa a = new FmQuanLyLopKhoa();
            a.ShowDialog();
        }

        private void lh_Click(object sender, EventArgs e)
        {
            FmQuanLyLopHoc a = new FmQuanLyLopHoc();
            a.ShowDialog();
        }

        private void bdsv_Click(object sender, EventArgs e)
        {
            FmQuanLyDiemSinhVienCT a = new FmQuanLyDiemSinhVienCT();
            a.ShowDialog();
        }

        private void gv_Click(object sender, EventArgs e)
        {
            FmQuanLyGiangVien a = new FmQuanLyGiangVien();
            a.ShowDialog();
        }

        private void gd_Click(object sender, EventArgs e)
        {
            FmQuanLyGiangDay a = new FmQuanLyGiangDay();
            a.ShowDialog();
        }

        private void bdl_Click(object sender, EventArgs e)
        {
            FmQuanLyDiemLopCT a = new FmQuanLyDiemLopCT();
            a.ShowDialog();
        }

        private void dk_Click(object sender, EventArgs e)
        {
            FmQuanLyDangKyHocPhan a = new FmQuanLyDangKyHocPhan();
            a.ShowDialog();
        }

        private void ttdk_Click(object sender, EventArgs e)
        {
            FmThongTinDangKyHocPhan a = new FmThongTinDangKyHocPhan();
            a.ShowDialog();
        }

        private void hcdk_Click(object sender, EventArgs e)
        {
            FmThongTinDangKyHocPhanHieuChinh a = new FmThongTinDangKyHocPhanHieuChinh();
            a.ShowDialog();
        }

    }
}