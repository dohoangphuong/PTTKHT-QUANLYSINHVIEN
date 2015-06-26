using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            KhoiTaoChucNang();
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
                FmDangNhap idangnhap = new FmDangNhap();
                idangnhap.ShowDialog();
                int iquyen = idangnhap.Quyen();
                _quyen = iquyen;
                //if (iquyen != -1)
                //{
                //    _quyen = iquyen;
                //}
                //else
                //    if (_quyen == -1)
                //        this.Close();
                KhoiTaoChucNang();
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
                        sv.Enabled = false;
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
                        sv.Enabled = false;
                        lk.Enabled = false;
                        lh.Enabled = false;
                        bdsv.Enabled = false;
                        gv.Enabled = false;
                        bdl.Enabled = false;
                        gd.Enabled = false;
                        dk.Enabled = false;
                        ttdk.Enabled = true;
                        hcdk.Enabled = false;
                        PhanQuyen.Enabled = true;
                        break;
                    case 3://Cán bộ
                        nh.Enabled = false;
                        hk.Enabled = false;
                        mh.Enabled = false;
                        mtq.Enabled = false;
                        sv.Enabled = false;
                        lk.Enabled = false;
                        lh.Enabled = false;
                        bdsv.Enabled = false;
                        gv.Enabled = true;
                        bdl.Enabled = true;
                        gd.Enabled = true;
                        dk.Enabled = false;
                        ttdk.Enabled = false;
                        hcdk.Enabled = false;
                        PhanQuyen.Enabled = true;
                        break;
                    case 4://khác
                        nh.Enabled = true;
                        hk.Enabled = true;
                        mh.Enabled = true;
                        mtq.Enabled = true;
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
                }
            }
            catch { }
        }
        #endregion

    }
}