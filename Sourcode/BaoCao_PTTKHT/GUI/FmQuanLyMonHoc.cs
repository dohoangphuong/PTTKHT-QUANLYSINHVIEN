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
    public partial class FmQuanLyMonHoc : DevComponents.DotNetBar.Metro.MetroForm
    {
        /*
         * YÊU CẦU: tìm sv      -> group sinh viên không được bỏ trống
         *          tìm lớp học -> group lớp học k được bỏ trống
         * LƯU Ý: Khi ở tap sv: mở 2 group
         *        Khi ở tap lớp đóng tap sv
         */

        #region Khai bao bien
        BLL_Khoa bll_Khoa = new BLL_Khoa();
        BLL_MonHoc bll_MonHoc = new BLL_MonHoc();
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
                _comboItems.Add(new Data{ Name = khoa.TenKhoa, ID = khoa.MaKhoa });
            }
            cbKhoa.DataSource = _comboItems;
            cbKhoa.DisplayMember = "Name";
            cbKhoa.ValueMember = "ID";
            if (cbKhoa.Items.Count > 0)
                cbKhoa.SelectedIndex = 0;
        }

        //Load mon hoc
        public void LoadMonHoc()
        {
            dataGridView2.Rows.Clear();
            int stt = 0;
            String tenKhoa = null;
            List<MONHOC> listMonHoc = bll_MonHoc.SelectAll();
            foreach (MONHOC mon in listMonHoc)
            {
                foreach (usp_SelectKhoaResult khoa in bll_Khoa.Select(mon.MaKhoa))
                {
                    tenKhoa = khoa.TenKhoa;
                }
                stt++;
                dataGridView2.Rows.Add(stt, mon.MaMonHoc, mon.TenMonHoc, mon.SoTinChi, tenKhoa, mon.MaKhoa);
            }
        }
        #endregion
        public FmQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void FmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(String.IsNullOrEmpty(tbMaMon.Text) || String.IsNullOrEmpty(tbTenMon.Text) || String.IsNullOrEmpty(tbSoTinChi.Text)
                    || String.IsNullOrEmpty(cbKhoa.Text)))
                {
                    bll_MonHoc.Insert(tbMaMon.Text, tbTenMon.Text, int.Parse(tbSoTinChi.Text), cbKhoa.SelectedValue.ToString());
                    LoadMonHoc();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Mã môn học không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                tbMaMon.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["MaMH"].Value.ToString().Trim());
                tbTenMon.Text = Convert.ToString(dataGridView2.CurrentRow.Cells["TenMH"].Value.ToString().Trim());
                cbKhoa.SelectedValue = dataGridView2.CurrentRow.Cells["MaKhoa"].Value.ToString();
                tbSoTinChi.Text = dataGridView2.CurrentRow.Cells["SoTinChi"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(String.IsNullOrEmpty(tbMaMon.Text) || String.IsNullOrEmpty(tbTenMon.Text) || String.IsNullOrEmpty(tbSoTinChi.Text)
                    || String.IsNullOrEmpty(cbKhoa.Text)))
                {
                    bll_MonHoc.Update(dataGridView2.CurrentRow.Cells["MaMH"].Value.ToString(), tbTenMon.Text, int.Parse(tbSoTinChi.Text), cbKhoa.SelectedValue.ToString());
                    LoadMonHoc();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Mã môn học không được trùng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView2.CurrentRow != null)
            {
                bll_MonHoc.Delete(dataGridView2.CurrentRow.Cells["MaMH"].Value.ToString());
                LoadMonHoc();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMonTienQuyet_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                FmQuanLyMonHocTienQuyet MTQ = new FmQuanLyMonHocTienQuyet(dataGridView2.CurrentRow.Cells["MaMH"].Value.ToString());
                MTQ.Show();
            }
            else
            {
                FmQuanLyMonHocTienQuyet MTQ = new FmQuanLyMonHocTienQuyet();
                MTQ.Show();
            }
        }
    }
}