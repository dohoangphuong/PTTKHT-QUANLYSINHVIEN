using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Security.Cryptography;
using BaoCao_PTTKHT.BLL;
using BaoCao_PTTKHT.DAL;

namespace BaoCao_PTTKHT.GUI
{
    public partial class FmDangNhap : DevComponents.DotNetBar.Metro.MetroForm
    {
        #region Biến khởi tạo
        BLL_TaiKhoan _taikhoan = new BLL_TaiKhoan();
        List<TAIKHOAN> ListTK;
        private int _quyen = -1;


        public FmDangNhap()
        {
            InitializeComponent();
            ListTK = _taikhoan.SelectAll();
            KiemTra();
        }
        private void KiemTra()
        {
            try
            {
                foreach (TAIKHOAN newTK in ListTK)
                {
                    if (newTK.LoaiTaiKhoan == 0)
                    {
                        return;
                    }
                }
                BLL_TaiKhoan _taikhoan = new BLL_TaiKhoan();
                //(_TenTaiKhoan, _MatKhau, _TenNguoiDung, _LoaiTaiKhoan);
                _taikhoan.Insert("Admin", MaHoaMD5(MaHoaMD5("Admin")), "HP", 0);
                ListTK = _taikhoan.SelectAll();
            }
            catch
            {

            }
        }
         #endregion
        #region Mã hóa MD5
        private string MaHoaMD5(string str)
        {
            Byte[] dauvao = ASCIIEncoding.Default.GetBytes(str);
            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                var daura = md5.ComputeHash(dauvao);
                return BitConverter.ToString(daura).Replace("-", "");
            }
        }
         #endregion
        #region Đăng nhập
        private void btDN_Click(object sender, EventArgs e)
        {
            try
            {
                if (textTen.Text.Trim() != "" && textMatKhau.Text.Trim() != "")
                {
                    foreach (TAIKHOAN newtk in ListTK)
                    {
                        if (newtk.TenTaiKhoan ==textTen.Text && newtk.MatKhau == MaHoaMD5(MaHoaMD5(textMatKhau.Text)))
                        {
                            MessageBox.Show("Chào " + textTen.Text + " đến với phần mềm QUẢN LÝ PHÒNG ĐÀO TẠO", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _quyen = newtk.LoaiTaiKhoan;
                            this.Close();
                            return;
                        }
                    }
                }
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _quyen = -1;
                textTen.Clear();
                textMatKhau.Clear();
            }
            catch { }
           
        }
        #endregion
        #region Xem thông tin
        private void thongtin_Click(object sender, EventArgs e)
        {
            _quyen = 4;
            this.Close();
        }
        #endregion
        #region Thoát
        private void btThoat_Click(object sender, EventArgs e)
        {    
            if(DialogResult.OK == MessageBox.Show("Bạn có muốn thoát!", "THOÁT ỨNG DỤNG", MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
            {
                _quyen = -1;
                this.Close();
            }
        }
        #endregion
        #region Trả về giá trị quyền
        public int Quyen()
        {
            return _quyen;
        }
        #endregion
        #region Hiển thị mật khẩu
        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            if(checkMK.Checked == false)
            {
                textMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                textMatKhau.UseSystemPasswordChar = true;
            }
        }
        #endregion

        #region even Bắt phím
        private void frDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //Đăng nhập
                if (e.KeyChar == 13)
                {
                    btDN_Click(sender, e);
                }
                //thoát
                if (e.KeyChar == 27)
                {
                    btThoat_Click(sender, e);
                }
            }
            catch { }
        }
        #endregion
    }
}