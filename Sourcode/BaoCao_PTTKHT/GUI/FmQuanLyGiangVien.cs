using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BaoCao_PTTKHT.BLL;
using BaoCao_PTTKHT.DAL;

namespace BaoCao_PTTKHT.GUI
{
    public partial class FmQuanLyGiangVien : DevComponents.DotNetBar.Metro.MetroForm
    {
        /*
         * YÊU CẦU: tìm sv      -> group sinh viên không được bỏ trống
         *          tìm lớp học -> group lớp học k được bỏ trống
         * LƯU Ý: Khi ở tap sv: mở 2 group
         *        Khi ở tap lớp đóng tap sv
         */

        #region khai bao bien
        BLL_GiangVien bll_GiangVien = new BLL_GiangVien();
        BLL_Khoa bll_Khoa = new BLL_Khoa();
        BLL_BoDem bll_BoDem = new BLL_BoDem();
        #endregion

        #region wrapper
        private class Data
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }
        #endregion

        #region Ham
        //Load Khoa
        public void LoadKhoa()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            List<KHOA> listKhoa = bll_Khoa.SelectAll();
            foreach (KHOA khoa in listKhoa)
            {
                _comboItems.Add(new Data { Name = khoa.TenKhoa, ID = khoa.MaKhoa });
            }
            cbKhoa.DisplayMember = "Name";
            cbKhoa.ValueMember = "ID";
            cbKhoa.DataSource = _comboItems;
            if (cbKhoa.Items.Count > 0)
                cbKhoa.SelectedIndex = 0;
        }

        //Load giang vien
        public void LoadGiangVien()
        {
            dataGridView2.Rows.Clear();
            int stt = 0;
            foreach (GIANGVIEN gv in bll_GiangVien.SelectAll())
            { 
                String tenKhoa = null;
                foreach (usp_SelectKhoaResult khoa in bll_Khoa.Select(gv.MaKhoa))
                {
                    tenKhoa = khoa.TenKhoa;
                }
                stt++;
                dataGridView2.Rows.Add(stt, gv.MaGiangVien, gv.TenGiangVien, gv.DiaChi, gv.GioiTinh, gv.DienThoai, gv.NgaySinh.ToShortDateString(), tenKhoa, gv.TrinhDo, gv.ChucVu, gv.MaKhoa);
            }
            tbMaGV.Text = CreateMaGV();
        }

        //Tao ma giang vien
        public String CreateMaGV()
        {
            String temp = "GV0000";
            String soDem = (bll_BoDem.SelectSoDem("GIANGVIEN") +1 ).ToString();
            temp = temp.Remove(temp.Length - soDem.Length);
            temp += soDem;
            return temp;
        }

        //xoa cac o textbox
        public void ClearTb()
        {
            tbChucVu.Clear();
            tbDiaChi.Clear();
            tbHoTen.Clear();
            tbDienThoai.Clear();
            tbTrinhDo.Clear();
        }
        #endregion

        public FmQuanLyGiangVien()
        {
            InitializeComponent();
        }

        private void FmQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadGiangVien();
            cbGioiTinh.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbHoTen.Text) || String.IsNullOrEmpty(tbDiaChi.Text) || String.IsNullOrEmpty(tbChucVu.Text)
                || String.IsNullOrEmpty(cbGioiTinh.Text)))
            {
                bll_GiangVien.Insert(CreateMaGV(), tbHoTen.Text, tbDiaChi.Text, dtpNgaySinh.Value, cbGioiTinh.Text, tbDienThoai.Text, tbChucVu.Text, tbTrinhDo.Text, cbKhoa.SelectedValue.ToString());
                ClearTb();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadGiangVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbHoTen.Text) || String.IsNullOrEmpty(tbDiaChi.Text) || String.IsNullOrEmpty(tbChucVu.Text)
                || String.IsNullOrEmpty(cbGioiTinh.Text)))
            {
                if (dataGridView2.CurrentRow != null)
                {
                    bll_GiangVien.Update(dataGridView2.CurrentRow.Cells["MaGV"].Value.ToString(), tbHoTen.Text, tbDiaChi.Text, dtpNgaySinh.Value, cbGioiTinh.Text, tbDienThoai.Text, tbChucVu.Text, tbTrinhDo.Text, cbKhoa.SelectedValue.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadGiangVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                bll_GiangVien.Delete(dataGridView2.CurrentRow.Cells["MaGV"].Value.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                try
                {
                    tbHoTen.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["TenGV"].Value.ToString().Trim());
                    cbGioiTinh.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim());
                    tbDiaChi.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["DiaChi"].Value.ToString().Trim());
                    tbMaGV.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["MaGV"].Value.ToString().Trim());
                    dtpNgaySinh.Text = dataGridView2.CurrentRow.Cells["NgaySinh"].Value.ToString();
                    tbChucVu.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["ChucVu"].Value.ToString().Trim());
                    cbKhoa.SelectedValue = Convert.ToString(dataGridView2.CurrentRow.Cells["MaKhoa"].Value.ToString().Trim());
                    tbDienThoai.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["DienThoai"].Value.ToString().Trim());
                    tbTrinhDo.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["TrinhDo"].Value.ToString().Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #region kiểm soát dữ liệu đầu vào
        private void tbHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
            if (tbHoTen.Text.Length >= 50 && key != 8)
            {
                e.Handled = true;
            }
        }

        private void tbDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (tbDiaChi.Text.Length >= 100 && key != 8)
            {
                e.Handled = true;
            }
        }

        private void tbDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (tbDienThoai.Text.Length >= 12 && key != 8)
            {
                e.Handled = true;
            }
        }
        #endregion

    }
}