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
    public partial class FmQuanLyLopKhoa : DevComponents.DotNetBar.Metro.MetroForm
    {
        #region Khai bao bien
        BLL_Khoa bll_Khoa = new BLL_Khoa();
        BLL_Lop bll_Lop = new BLL_Lop();
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        #endregion

        #region class
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

        //Load Nam Hoc
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

        //Load lop
        public void LoadLop()
        {
            dataGridView2.Rows.Clear();
            int stt = 0;
            String tenKhoa = null;
            foreach (usp_SelectLopsByMaNamHocResult lop in bll_Lop.SelectLopByMaNamHoc(int.Parse(cbNamHoc.SelectedValue.ToString())))
            {
                foreach (usp_SelectKhoaResult khoa in bll_Khoa.Select(lop.MaKhoa))
                {
                    tenKhoa = khoa.TenKhoa;
                }
                stt++;
                dataGridView2.Rows.Add(stt, lop.MaLop, lop.TenLop, tenKhoa, lop.MaKhoa);
            }
        }
        #endregion

        public FmQuanLyLopKhoa()
        {
            InitializeComponent();
        }

        private void FmQuanLyLopKhoa_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadNamHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(cbKhoa.Text) || String.IsNullOrEmpty(tbMaLop.Text) || String.IsNullOrEmpty(tbTenLop.Text)))
            {
                bll_Lop.Insert(tbMaLop.Text, tbTenLop.Text, cbKhoa.SelectedValue.ToString(), 1);
                LoadLop();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                bll_Lop.Delete(dataGridView2.CurrentRow.Cells["MaLop"].Value.ToString());
                LoadLop();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                if (!(String.IsNullOrEmpty(cbKhoa.Text) || String.IsNullOrEmpty(tbMaLop.Text) || String.IsNullOrEmpty(tbTenLop.Text)))
                {
                    bll_Lop.Update(dataGridView2.CurrentRow.Cells["MaLop"].Value.ToString(), tbTenLop.Text, cbKhoa.SelectedValue.ToString(), 1);
                    LoadLop();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLop();
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                try
                {
                    cbKhoa.SelectedValue = dataGridView2.CurrentRow.Cells["MaKhoa"].Value.ToString();
                    tbMaLop.Text = dataGridView2.CurrentRow.Cells["MaLop"].Value.ToString();
                    tbTenLop.Text = dataGridView2.CurrentRow.Cells["TenLop"].Value.ToString();
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
    }
}