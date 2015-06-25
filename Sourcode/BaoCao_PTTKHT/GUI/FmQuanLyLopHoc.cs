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
    public partial class FmQuanLyLopHoc : DevComponents.DotNetBar.Metro.MetroForm
    {

        #region Khai bao bien
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        BLL_MonHoc bll_MonHoc = new BLL_MonHoc();
        BLL_HocKy bll_HocKy = new BLL_HocKy();
        BLL_LopHoc bll_LopHoc = new BLL_LopHoc();
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

        //Load mon hoc
        public void LoadMonHoc()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            List<MONHOC> listMonHoc = bll_MonHoc.SelectAll();
            foreach (MONHOC mon in listMonHoc)
            {
                _comboItems.Add(new Data { Name = mon.TenMonHoc, ID = mon.MaMonHoc });
            }
            cbMonHoc.DisplayMember = "Name";
            cbMonHoc.ValueMember = "ID";
            cbMonHoc.DataSource = _comboItems;
            if (cbMonHoc.Items.Count > 0)
                cbMonHoc.SelectedIndex = 0;
        }

        //Load Hoc Ky
        public void LoadHocKy()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            foreach (usp_SelectHockiesByMaNamHocResult hk in bll_HocKy.SelectHocKyByMaNamHoc(int.Parse(cbNamHoc.SelectedValue.ToString())))
            {
                _comboItems.Add(new Data { Name = hk.HocKy, ID = hk.MaHocKy.ToString() });
            }
            cbHocKy.DisplayMember = "Name";
            cbHocKy.ValueMember = "ID";
            cbHocKy.DataSource = _comboItems;
            if (cbHocKy.Items.Count > 0)
                cbHocKy.SelectedIndex = 0;
        }

        //Load Lop hoc
        public void LoadLopHoc()
        {
            dataGridView2.Rows.Clear();
            String TenMonHoc = null;
            String TenHocKy = null;
            String TenNamHoc = null;
            String MaNamHoc = null;
            int stt = 0;
            List<LOPHOC> listLopHoc = bll_LopHoc.SelectAll();
            foreach (LOPHOC lophoc in listLopHoc)
            { 
                foreach(usp_SelectMonhocResult mh in bll_MonHoc.Select(lophoc.MaMonHoc))
                {
                    TenMonHoc = mh.TenMonHoc;
                }
                foreach(usp_SelectHockyResult hk in bll_HocKy.Select(lophoc.MaHocKy))
                {
                    TenHocKy = hk.HocKy;
                    foreach(usp_SelectNamhocResult nh in bll_NamHoc.Select(hk.MaNamHoc))
                    {
                        TenNamHoc = nh.NamHoc;
                    }
                    MaNamHoc = hk.MaNamHoc.ToString();
                }
                
                stt++;
                dataGridView2.Rows.Add(stt,lophoc.MaLopHoc, lophoc.TenLopHoc, TenMonHoc, TenNamHoc, TenHocKy, lophoc.Thu, lophoc.Tiet, MaNamHoc, lophoc.MaHocKy, lophoc.MaMonHoc);
            }
            tbMaLop.Text = (bll_BoDem.SelectSoDem("LOPHOC") + 1).ToString();
        }

        //Check checkedListItem
        public void CheckListItem(String Tiet)
        {
            foreach(int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            String[] tiets = Tiet.Split('-');
            foreach (String tiet in tiets)
            {
                checkedListBox1.SetItemCheckState(int.Parse(tiet) - 1, CheckState.Checked);
            }
        }

        //Clear
        public void Clear()
        {
            tbTenLop.Clear();
            checkedListBox1.ClearSelected();
        }
        #endregion

        public FmQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void FmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            LoadNamHoc();
            LoadLopHoc();
            cbThu.SelectedIndex = 0;
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNamHoc.SelectedIndex != -1)
            {
                LoadHocKy();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(!(String.IsNullOrEmpty(tbTenLop.Text) || String.IsNullOrEmpty(cbHocKy.Text) 
                || String.IsNullOrEmpty(cbMonHoc.Text) || String.IsNullOrEmpty(cbNamHoc.Text)))
            {
                String temp = null;
                foreach (object obj in checkedListBox1.CheckedItems)
                {
                    temp += obj.ToString() + "-";
                }
                temp = temp.Remove(temp.Length - 1);
                bll_LopHoc.Insert(bll_BoDem.SelectSoDem("LOPHOC") + 1, tbTenLop.Text, temp, cbThu.Text, cbMonHoc.SelectedValue.ToString(), int.Parse(cbHocKy.SelectedValue.ToString()));
                LoadLopHoc();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbTenLop.Text) || String.IsNullOrEmpty(cbHocKy.Text)
                || String.IsNullOrEmpty(cbMonHoc.Text) || String.IsNullOrEmpty(cbNamHoc.Text)
                || dataGridView2.CurrentRow == null))
            {
                String temp = null;
                foreach (object obj in checkedListBox1.CheckedItems)
                {
                    temp += obj.ToString() + "-";
                }
                temp = temp.Remove(temp.Length - 1);
                bll_LopHoc.Update(int.Parse(dataGridView2.CurrentRow.Cells["MaLopHoc"].Value.ToString()), tbTenLop.Text, temp, cbThu.Text, cbMonHoc.SelectedValue.ToString(), int.Parse(cbHocKy.SelectedValue.ToString()));
                LoadLopHoc();
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
                bll_LopHoc.Delete(int.Parse(dataGridView2.CurrentRow.Cells["MaLopHoc"].Value.ToString()));
            }
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                tbMaLop.Text = dataGridView2.CurrentRow.Cells["MaLopHoc"].Value.ToString();
                tbTenLop.Text = dataGridView2.CurrentRow.Cells["TenLopHoc"].Value.ToString();
                cbNamHoc.SelectedValue = dataGridView2.CurrentRow.Cells["MaNamHoc"].Value.ToString();
                cbHocKy.SelectedValue = dataGridView2.CurrentRow.Cells["MaHocKy"].Value.ToString();
                cbMonHoc.SelectedValue = dataGridView2.CurrentRow.Cells["MaMonHoc"].Value.ToString();
                cbThu.SelectedItem = dataGridView2.CurrentRow.Cells["Thu"].Value.ToString();
                CheckListItem(dataGridView2.CurrentRow.Cells["Tiet"].Value.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}