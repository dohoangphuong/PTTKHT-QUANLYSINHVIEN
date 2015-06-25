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
    public partial class FmQuanLyMonHocTienQuyet : DevComponents.DotNetBar.Metro.MetroForm
    {
        /*
         * YÊU CẦU: tìm sv      -> group sinh viên không được bỏ trống
         *          tìm lớp học -> group lớp học k được bỏ trống
         * LƯU Ý: Các combobox: thể hiện cho việc lựa chọn
         *          Còn các texbox chỉ cho hiện các lựa chọn nhưng bị Enable
         */
        #region Khai bao bien
        BLL_Khoa bll_Khoa = new BLL_Khoa();
        BLL_MonHoc bll_MonHoc = new BLL_MonHoc();
        BLL_MonTienQuyet bll_MonTienQuyet = new BLL_MonTienQuyet();
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
        //Load mon hoc
        public void LoadMonHoc()
        {
            BindingList<Data> _comboItemsMonHoc = new BindingList<Data>();
            BindingList<Data> _comboItemsMaMonHoc = new BindingList<Data>();
            BindingList<Data> _comboItemsMonTienQuyet = new BindingList<Data>();
            BindingList<Data> _comboItemsMaMonTienQuyet = new BindingList<Data>();
            List<MONHOC> listMonHoc = bll_MonHoc.SelectAll();
            foreach (MONHOC monHoc in listMonHoc)
            {
                _comboItemsMonHoc.Add(new Data { Name = monHoc.TenMonHoc, ID = monHoc.MaMonHoc });
                _comboItemsMaMonHoc.Add(new Data { Name = monHoc.MaMonHoc, ID = monHoc.TenMonHoc });
                _comboItemsMonTienQuyet.Add(new Data { Name = monHoc.TenMonHoc, ID = monHoc.MaMonHoc });
                _comboItemsMaMonTienQuyet.Add(new Data { Name = monHoc.MaMonHoc, ID = monHoc.TenMonHoc });
            }
            //Add vao combobox ten mon hoc
            cbMonHoc.DisplayMember = "Name";
            cbMonHoc.ValueMember = "ID";
            cbMonHoc.DataSource = _comboItemsMonHoc;
            if (cbMonHoc.Items.Count > 0)
                cbMonHoc.SelectedIndex = 0;

            //Add vao combobox ten mon hoc tien quyet
            cbMonTienQuyet.DisplayMember = "Name";
            cbMonTienQuyet.ValueMember = "ID";
            cbMonTienQuyet.DataSource = _comboItemsMonTienQuyet;
            if (cbMonTienQuyet.Items.Count > 0)
                cbMonTienQuyet.SelectedIndex = 0;

            //Add vao combobox ma mon hoc
            cbMaMonHoc.DisplayMember = "Name";
            cbMaMonHoc.ValueMember = "ID";
            cbMaMonHoc.DataSource = _comboItemsMaMonHoc;
            if (cbMaMonHoc.Items.Count > 0)
                cbMaMonHoc.SelectedIndex = 0;

            //Add vao combobox ma mon hoc tien quyet
            cbMaMonTienQuyet.DisplayMember = "Name";
            cbMaMonTienQuyet.ValueMember = "ID";
            cbMaMonTienQuyet.DataSource = _comboItemsMaMonTienQuyet;
            if (cbMaMonTienQuyet.Items.Count > 0)
                cbMaMonTienQuyet.SelectedIndex = 0;
        }

        //Load mon tien quyet vao datagridview
        public void LoadMonTienQuyet()
        {
            datagridview1.Rows.Clear();
            int stt = 0;
            String tenKhoa = null;
            foreach (usp_SelectMontienquyetsByMaMonHocResult montienquyet in bll_MonTienQuyet.SelectMonTienQuyetByMaMon(cbMaMonHoc.Text))
            {
                foreach (usp_SelectMonhocResult monhoc in bll_MonHoc.Select(montienquyet.MaMonTienQuyet))
                {
                    foreach (usp_SelectKhoaResult khoa in bll_Khoa.Select(monhoc.MaKhoa))
                    {
                        tenKhoa = khoa.TenKhoa;
                    }
                    stt++;
                    datagridview1.Rows.Add(stt, monhoc.MaMonHoc, monhoc.TenMonHoc, monhoc.SoTinChi, tenKhoa, monhoc.MaKhoa, montienquyet.MaMTQ);
                }
            }
        }

        //load data vao cac textbox
        public void LoadTbMonHoc()
        {
            foreach (usp_SelectMonhocResult monhoc in bll_MonHoc.Select(cbMaMonHoc.Text))
            {
                tbSoTinChi.Text = monhoc.SoTinChi.ToString();
                foreach (usp_SelectKhoaResult khoa in bll_Khoa.Select(monhoc.MaKhoa))
                {
                    tbKhoa.Text = khoa.TenKhoa;
                }
            }
        }
        #endregion

        public FmQuanLyMonHocTienQuyet()
        {
            InitializeComponent();
            LoadMonHoc();
        }

        public FmQuanLyMonHocTienQuyet(String _MaMonHoc)
        {
            InitializeComponent();
            LoadMonHoc();
            cbMonHoc.SelectedValue = _MaMonHoc;
        }

        private void datagridview1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (datagridview1.CurrentRow != null)
            {
                cbMonTienQuyet.SelectedValue = datagridview1.CurrentRow.Cells["MaMH"].Value.ToString();
            }
        }

        private void cbMaMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbMaMonHoc.Text))
            {
                cbMonHoc.SelectedValue = cbMaMonHoc.Text;
                LoadMonTienQuyet();
                LoadTbMonHoc();
            }
        }

        private void cbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbMonHoc.Text))
            {
                cbMaMonHoc.SelectedValue = cbMonHoc.Text;
                LoadMonTienQuyet();
                LoadTbMonHoc();
            }
        }

        private void cbMaMonTienQuyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbMonTienQuyet.Text))
            {
                cbMonTienQuyet.SelectedValue = cbMaMonTienQuyet.Text;
            }
        }

        private void cbMonTienQuyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbMaMonTienQuyet.Text))
            {
                cbMaMonTienQuyet.SelectedValue = cbMonTienQuyet.Text;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbMaMonTienQuyet.Text != cbMaMonHoc.Text)
            {
                bool Flag = true;
                foreach (DataGridViewRow row in datagridview1.Rows)
                {
                    if (cbMaMonTienQuyet.Text == row.Cells["MaMH"].Value.ToString())
                    {
                        Flag = false;
                        break;
                    }
                }
                if (Flag)
                {
                    bll_MonTienQuyet.Insert(bll_BoDem.SelectSoDem("MONTIENQUYET"), cbMaMonHoc.Text, cbMaMonTienQuyet.Text);
                    LoadMonTienQuyet();
                }
                else
                {
                    MessageBox.Show("Môn tiên quyết đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Môn tiên quyết không được trùng môn chọn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (datagridview1.CurrentRow != null)
            {
                bll_MonTienQuyet.Delete(int.Parse(datagridview1.CurrentRow.Cells["MaMTQ"].Value.ToString()));
                LoadMonTienQuyet();
            }
        }
    }
}