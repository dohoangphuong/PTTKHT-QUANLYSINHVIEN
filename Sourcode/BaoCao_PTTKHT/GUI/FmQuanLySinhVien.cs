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
    public partial class FmQuanLySinhVien : DevComponents.DotNetBar.Metro.MetroForm
    {
        /*
         * YÊU CẦU: tìm sv      -> group sinh viên không được bỏ trống
         *          tìm lớp học -> group lớp học k được bỏ trống
         * LƯU Ý: Khi ở tap sv: mở 2 group
         *        Khi ở tap lớp đóng tap sv
         */
        #region khai bao bien
        BLL_SinhVien bll_SinhVien = new BLL_SinhVien();
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        BLL_Khoa bll_Khoa = new BLL_Khoa();
        BLL_Lop bll_Lop = new BLL_Lop();
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
        //Load nam hoc
        public void LoadNam()
        {
            BindingList<Data> _comboItems = new BindingList<Data>(); 
            List<NAMHOC> listNamHoc = bll_NamHoc.SelectAll();
            foreach (NAMHOC namhoc in listNamHoc)
            {
                _comboItems.Add(new Data { Name = namhoc.NamHoc1, ID = namhoc.MaNamHoc.ToString() });
            }
            cbNam.DisplayMember = "Name";
            cbNam.ValueMember = "ID";
            cbNam.DataSource = _comboItems;
            if (cbNam.Items.Count > 0)
                cbNam.SelectedIndex = 0;
        }

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

        //Load Lop
        public void LoadLop()
        {
            BindingList<Data> _comboItems = new BindingList<Data>(); 
            foreach (usp_SelectLopsByMaKhoaResult lop in bll_Lop.SelectLopByMaKhoa(cbKhoa.SelectedValue.ToString()))
            {
                _comboItems.Add(new Data { Name = lop.TenLop, ID = lop.MaLop });
            }
            cbLopKhoa.DisplayMember = "Name";
            cbLopKhoa.ValueMember = "ID";
            cbLopKhoa.DataSource = _comboItems;
            if (cbLopKhoa.Items.Count > 0)
                cbLopKhoa.SelectedIndex = 0;
        }

        //Load sinh vien theo nam
        public void LoadSinhVien(int maNam)
        {
            int stt = 0;
            dataGridView2.Rows.Clear();
            if (bll_Lop.SelectLopByMaNamHoc(maNam) != null)
            {
                foreach (usp_SelectLopsByMaNamHocResult lop in bll_Lop.SelectLopByMaNamHoc(maNam))
                {
                    foreach (usp_SelectSinhviensByMaLopResult sv in bll_SinhVien.SelectSinhVienByMaLop(lop.MaLop))
                    {
                        stt++;
                        String tenKhoa = null;
                        foreach (usp_SelectKhoaResult khoa in bll_Khoa.Select(lop.MaKhoa))
                        {
                            tenKhoa = khoa.TenKhoa;
                        }
                        dataGridView2.Rows.Add(stt, sv.MSSV, sv.TenSinhVien, sv.GioiTinh, sv.DiaChi, sv.NgaySinh.ToShortDateString(), sv.DienThoai, lop.TenLop, tenKhoa, lop.MaKhoa, lop.MaLop);
                    }
                }
            }
        }

        //Tao ma sv
        public String CreateMSSV()
        {
            if (cbNam.SelectedIndex != -1)
            {
                String temp = cbNam.Text.Substring(2, 2) + "520000";
                String soDem = (int.Parse(bll_SinhVien.SelectLastMssvByNam(int.Parse(cbNam.SelectedValue.ToString())).Substring(4)) + 1).ToString();
                temp = temp.Remove(temp.Length - soDem.Length);
                temp += soDem;
                return temp;
            }
            return "00000000";
        }
        #endregion

        public FmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadNam();
            cbGioiTinh.SelectedIndex = 0;
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSinhVien(int.Parse(cbNam.SelectedValue.ToString()));
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLop();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbHoTen.Text) || String.IsNullOrEmpty(tbDiaChi.Text) || String.IsNullOrEmpty(tbDienThoai.Text)
                || String.IsNullOrEmpty(cbGioiTinh.Text) || String.IsNullOrEmpty(cbNam.Text) || String.IsNullOrEmpty(cbKhoa.Text)
                || String.IsNullOrEmpty(cbLopKhoa.Text)))
            {
                bll_SinhVien.Insert(CreateMSSV(), tbHoTen.Text, tbDiaChi.Text, dtpNgaySinh.Value, cbGioiTinh.Text, tbDienThoai.Text, cbLopKhoa.SelectedValue.ToString());
                LoadSinhVien(int.Parse(cbNam.SelectedValue.ToString()));            
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbHoTen.Text) || String.IsNullOrEmpty(tbDiaChi.Text) || String.IsNullOrEmpty(tbDienThoai.Text)
                || String.IsNullOrEmpty(cbGioiTinh.Text) || String.IsNullOrEmpty(cbNam.Text) || String.IsNullOrEmpty(cbKhoa.Text)
                || String.IsNullOrEmpty(cbLopKhoa.Text)))
            {
                bll_SinhVien.Update(tbMSSV.Text, tbHoTen.Text, tbDiaChi.Text, dtpNgaySinh.Value, cbGioiTinh.Text, tbDienThoai.Text, cbLopKhoa.SelectedValue.ToString());
                LoadSinhVien(int.Parse(cbNam.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                try
                {
                    tbHoTen.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["TenSV"].Value.ToString().Trim());
                    cbGioiTinh.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["GioiTinh"].Value.ToString().Trim());
                    tbDiaChi.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["DiaChi"].Value.ToString().Trim());
                    tbMSSV.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["MSSV"].Value.ToString().Trim());
                    dtpNgaySinh.Value = DateTime.Parse(dataGridView2.CurrentRow.Cells["NgaySinh"].Value.ToString());
                    tbDienThoai.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["DienThoai"].Value.ToString().Trim());
                    cbKhoa.SelectedValue = Convert.ToString(dataGridView2.CurrentRow.Cells["MaKhoa"].Value.ToString().Trim());
                    cbLopKhoa.SelectedValue = Convert.ToString(dataGridView2.CurrentRow.Cells["MaLop"].Value.ToString().Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                bll_SinhVien.Delete(dataGridView2.CurrentRow.Cells["MSSV"].Value.ToString());
                LoadSinhVien(int.Parse(cbNam.SelectedValue.ToString()));
            }
        }
    }
}