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
    public partial class FmQuanLyGiangDay : DevComponents.DotNetBar.Metro.MetroForm
    {
        /*
         * LƯU Ý: Mã Giảng Dạy nếu chọn vào mới thì sẽ tự động sinh khi chọn hết giá trị.->Tạo mới giảng dạy
         * và khi chọn lại giảng dạy thì sẽ cập nhật thêm thông tin.
         * */

        #region Khai bao bien
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        BLL_HocKy bll_HocKy = new BLL_HocKy();
        BLL_LopHoc bll_LopHoc = new BLL_LopHoc();
        BLL_GiangDay bll_GiangDay = new BLL_GiangDay();
        BLL_GiangVien bll_GiangVien = new BLL_GiangVien();
        BLL_BoDem bll_BoDem = new BLL_BoDem();
        #endregion

        #region class
        private class Data
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }
        #endregion

        #region Ham
        //Load Nam hoc
        public void LoadNamHoc()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            List<NAMHOC> listNamHoc = bll_NamHoc.SelectAll();
            foreach (NAMHOC namhoc in listNamHoc)
            {
                _comboItems.Add(new Data { Name = namhoc.NamHoc1, ID = namhoc.MaNamHoc.ToString() });
            }
            cbNamHoc.DisplayMember = "Name";
            cbNamHoc.ValueMember = "ID";
            cbNamHoc.DataSource = _comboItems;
            if (cbNamHoc.Items.Count > 0)
                cbNamHoc.SelectedIndex = 0;
        }

        //Load Hoc Ky
        public void LoadHocKy()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            foreach (usp_SelectHockiesByMaNamHocResult hk in bll_HocKy.SelectHocKyByMaNamHoc(int.Parse(cbNamHoc.SelectedValue.ToString())))
            {
                _comboItems.Add(new Data { Name = hk.HocKy, ID = hk.MaHocKy.ToString() });
            }
            cbNamHoc.DisplayMember = "Name";
            cbNamHoc.ValueMember = "ID";
            cbNamHoc.DataSource = _comboItems;
            if (cbNamHoc.Items.Count > 0)
                cbNamHoc.SelectedIndex = 0;
        }

        //Load Lop hoc
        public void LoadLopHoc()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            BindingList<Data> _comboItems2 = new BindingList<Data>();
            int stt = 0;
            String TenGiangVien = null;
            foreach (usp_SelectLophocsByMaHocKyResult lophoc in bll_LopHoc.SelectByMaHocKy(int.Parse(cbHocKy.SelectedValue.ToString())))
            { 
                _comboItems.Add(new Data { Name = lophoc.TenLopHoc, ID = lophoc.MaLopHoc.ToString() });
                _comboItems2.Add(new Data { Name = lophoc.MaLopHoc.ToString(), ID = lophoc.TenLopHoc });
                foreach(usp_SelectGiangdaysByMaLopHocResult giangday in bll_GiangDay.SelectGiangDayByMaLopHoc(lophoc.MaLopHoc))
                {
                    foreach(usp_SelectGiangvienResult gv in bll_GiangVien.Select(giangday.MaGiangVien))
                    {
                        TenGiangVien = gv.TenGiangVien;
                    }
                    stt++;
                    dataGridView1.Rows.Add(stt, lophoc.TenLopHoc, giangday.MaGiangVien, TenGV, cbNamHoc.Text, cbHocKy.Text, giangday.MaGiangDay, lophoc.MaLopHoc, cbHocKy.SelectedValue.ToString(), cbNamHoc.SelectedValue.ToString());
                }
            }

            cbTenLop.DisplayMember = "Name";
            cbTenLop.ValueMember = "ID";
            cbTenLop.DataSource = _comboItems;
            if (cbTenLop.Items.Count > 0)
                cbTenLop.SelectedIndex = 0;

            cbMaLop.DisplayMember = "Name";
            cbMaLop.ValueMember = "ID";
            cbMaLop.DataSource = _comboItems2;
            if (cbMaLop.Items.Count > 0)
                cbMaLop.SelectedIndex = 0;
        }

        //Load giang vien
        public void LoadGiangVien()
        { 
            BindingList<Data> _comboItems = new BindingList<Data>();
            BindingList<Data> _comboItems2 = new BindingList<Data>();
            foreach (GIANGVIEN gv in bll_GiangVien.SelectAll())
            { 
                _comboItems.Add(new Data { Name = gv.TenGiangVien, ID = gv.MaGiangVien });
                _comboItems2.Add(new Data { Name = gv.MaGiangVien, ID = gv.TenGiangVien });
            }

            cbTenGiangVien.DisplayMember = "Name";
            cbTenGiangVien.ValueMember = "ID";
            cbTenGiangVien.DataSource = _comboItems;
            if (cbTenGiangVien.Items.Count > 0)
                cbTenGiangVien.SelectedIndex = 0;

            cbMaGiangVien.DisplayMember = "Name";
            cbMaGiangVien.ValueMember = "ID";
            cbMaGiangVien.DataSource = _comboItems2;
            if (cbMaGiangVien.Items.Count > 0)
                cbMaGiangVien.SelectedIndex = 0;
        }
        #endregion

        public FmQuanLyGiangDay()
        {
            InitializeComponent();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHocKy();
        }

        private void FmQuanLyGiangDay_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLopHoc();
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaLop.SelectedValue = cbTenLop.Text;
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenLop.SelectedValue = cbMaLop.Text;
        }

        private void cbMaGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenGiangVien.SelectedValue = cbMaGiangVien.Text;
        }

        private void cbTenGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaGiangVien.SelectedValue = cbTenGiangVien.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(cbMaGiangVien.Text) || String.IsNullOrEmpty(cbMaLop.Text)))
            {
                bll_GiangDay.Insert(bll_BoDem.SelectSoDem("GIANGDAY") + 1, int.Parse(cbMaLop.Text), cbMaGiangVien.Text);
                LoadLopHoc();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(cbMaGiangVien.Text) || String.IsNullOrEmpty(cbMaLop.Text) || dataGridView1.CurrentRow == null))
            {
                bll_GiangDay.Update(int.Parse(dataGridView1.CurrentRow.Cells["MaGiangDay"].Value.ToString()), int.Parse(cbMaLop.Text), cbMaGiangVien.Text);
                LoadLopHoc();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            { 
                bll_GiangDay.Delete(int.Parse(dataGridView1.CurrentRow.Cells["MaGiangDay"].Value.ToString()));
                LoadLopHoc();
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                cbTenLop.SelectedValue = dataGridView1.CurrentRow.Cells["MaLop"].Value.ToString();
                cbTenGiangVien.SelectedValue = dataGridView1.CurrentRow.Cells["MaGV"].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}