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
    public partial class FmQuanLyTaiKhoan : DevComponents.DotNetBar.Metro.MetroForm
    {
        
        #region Biến khởi tạo
        BLL_TaiKhoan _taikhoan = new BLL_TaiKhoan();
        List<TAIKHOAN> ListTK;
        List<TAIKHOAN> ListHSADD = new List<TAIKHOAN>();
        List<TAIKHOAN> ListHSDelete = new List<TAIKHOAN>();
        List<TAIKHOAN> ListHSUpdate = new List<TAIKHOAN>();
        string _tk, _mk, _ten;
        int _loai;
        bool _luu = false;
        public FmQuanLyTaiKhoan()
        {
            InitializeComponent();
            ListTK = _taikhoan.SelectAll();
            dataPhanQuyen.DataSource = ListTK;
            dataPhanQuyen.Columns[1].Visible = false;
            dataPhanQuyen.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPhanQuyen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPhanQuyen.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            combo.SelectedIndex = 1;
        }
        #endregion
        #region Hiện ẩn mật khẩu
        private void checkMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMK.Checked == false)
            {
                textMK1.UseSystemPasswordChar = false;
                textMK2.UseSystemPasswordChar = false;
            }
            else
            {
                textMK1.UseSystemPasswordChar = true;
                textMK2.UseSystemPasswordChar = true;
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
        #region button
        //Clear textbox
        private void Clear()
        {
            textTK.Clear();
            textMK1.Clear();
            textMK2.Clear();
            textTen.Clear();
        }
        //Thêm
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (textTK.Text.Trim() == "" || textMK1.Text.Trim() == "" || textMK2.Text.Trim() == "" || textTen.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy dủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textMK1.Text == textMK2.Text)
                    {
                        bool trung = false;

                        foreach (TAIKHOAN newtk in ListTK)
                        {
                            if (newtk.TenTaiKhoan == textTK.Text)
                            {
                                trung = true;
                                break;
                            }
                        }
                        if (!trung)
                        {
                            TAIKHOAN newTK = new TAIKHOAN();

                            newTK.TenTaiKhoan = textTK.Text;
                            newTK.MatKhau = MaHoaMD5(MaHoaMD5(textMK1.Text));
                            newTK.LoaiTaiKhoan = combo.SelectedIndex;
                            newTK.TenNguoiDung = textTen.Text;

                            //Add List HocSinh Insert To Save DB
                            ListHSADD.Add(newTK);
                            ListTK.Add(newTK);
                            dataPhanQuyen.DataSource = ListTK.ToArray();
                            MessageBox.Show("Tài khoản bạn tạo thành công!", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _luu = true;
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản bạn vừa thêm đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu xác nhận giống và mật khẩu giống nhau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch { }
        }

        //Sửa
         private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (textTK.Text.Trim() == "" || textMK1.Text.Trim() == "" || textMK2.Text.Trim() == "" || textTen.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy dủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textMK1.Text == textMK2.Text)//2 mật khẩu giống nhau
                    {
                        bool trung = false;
                        bool ok = false;

                        String id = dataPhanQuyen.CurrentRow.Cells["TenTK"].Value.ToString();

                        foreach (TAIKHOAN newTK in ListTK)
                        {
                            if (newTK.TenTaiKhoan.ToString() == id)//lấy tk cần sửa
                            {
                                if (textTK.Text == _tk && textMK1.Text == _mk && combo.SelectedIndex == _loai)//không có thay đổi
                                {
                                    break;
                                }
                                else
                                {
                                    if (textTK.Text != _tk)//tên tk thay đổi
                                    {
                                        foreach (TAIKHOAN newTK1 in ListTK)
                                        {
                                            if (newTK1.TenTaiKhoan == textTK.Text)//trùng tk
                                            {
                                                trung = true;
                                                break;
                                            }
                                        }
                                        if (!trung)//khác trùng thì đổi
                                        {
                                            newTK.TenTaiKhoan = textTK.Text;
                                            ok = true;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Tài khoản bạn vừa thêm đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    if (textMK1.Text != _mk)//mat khẩu
                                    {
                                        newTK.MatKhau = MaHoaMD5(MaHoaMD5(textMK1.Text));
                                        ok = true;
                                    }
                                    if (combo.SelectedIndex != _loai)//loại
                                    {
                                        newTK.LoaiTaiKhoan = combo.SelectedIndex;
                                        ok = true;
                                    }
                                    if (textTen.Text != _ten)//tên người dùng
                                    {
                                        newTK.LoaiTaiKhoan = combo.SelectedIndex;
                                        ok = true;
                                    }

                                    if (!trung && ok)
                                    {
                                        ListHSUpdate.Add(newTK);
                                        dataPhanQuyen.DataSource = ListTK.ToArray();
                                        _luu = true;
                                        Clear();
                                    }
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu xác nhận và mật khẩu giống nhau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch { }
        }

        //Xóa
         private void BtXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String id = dataPhanQuyen.CurrentRow.Cells["TenTK"].Value.ToString();

                foreach (TAIKHOAN newtk in ListTK)
                {
                    if (newtk.TenTaiKhoan == id)
                    {
                        ListHSDelete.Add(newtk);

                        ListTK.Remove(newtk);
                        _luu = true;
                        break;
                    }
                }
                dataPhanQuyen.DataSource = ListTK.ToArray();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

         private void Luu()
        {
            try
            {
                //Delete
                foreach (TAIKHOAN newHs in ListHSDelete)
                {
                    _taikhoan.Delete(newHs.TenTaiKhoan);
                }
                //ADD
                foreach (TAIKHOAN newHs in ListHSADD)
                {
                    _taikhoan.Insert(newHs.TenTaiKhoan, newHs.MatKhau, newHs.TenNguoiDung, newHs.LoaiTaiKhoan);
                }
                //Update
                foreach (TAIKHOAN newHs in ListHSUpdate)
                {
                    _taikhoan.Update(newHs.TenTaiKhoan, newHs.MatKhau, newHs.TenNguoiDung, newHs.LoaiTaiKhoan);
                }
                _luu = false;
            }
            catch { }
        }
        //Thoát
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (_luu)
            {
                DialogResult di = MessageBox.Show("Bạn có muốn lưu lại dữ liệu lại trước khi thoát?", "ĐÓNG ỨNG DỤNG", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (DialogResult.Yes == di)
                {
                    Luu();
                    this.Close();
                }
                else
                {
                    if (DialogResult.No == di)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                DialogResult di = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "ĐÓNG ỨNG DỤNG", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult.OK == di)
                {
                    this.Close();
                }
            }
            
           
        }
        //Lưu
        private void btLuu_Click(object sender, EventArgs e)
        {
            Luu();
        }
        #endregion
        #region Click DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       //     MessageBox.Show("asd");
            try
            {
                textTK.Text = Convert.ToString(dataPhanQuyen.CurrentRow.Cells["TenTaiKhoan"].Value.ToString().Trim());
                textMK1.Clear();
                textMK2.Clear();
                textTen.Text = Convert.ToString(dataPhanQuyen.CurrentRow.Cells["TenNguoiDung"].Value.ToString().Trim());
                combo.SelectedIndex = Convert.ToInt32(Convert.ToString(dataPhanQuyen.CurrentRow.Cells["LoaiTaiKhoan"].Value.ToString().Trim()));
                _tk = textTK.Text;
                _mk = textMK1.Text;
                _loai = combo.SelectedIndex;
                _ten = textTen.Text;
            }
            catch { }
        }
        #endregion
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (textTK.Text.Length >= 30 && key != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (textMK1.Text.Length >= 100 && key != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (textMK1.Text.Length >= 50 && key != 8)
            {
                e.Handled = true;
            }
        }
    }
}