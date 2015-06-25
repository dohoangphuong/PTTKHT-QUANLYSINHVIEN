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
    public partial class FmThongTinDangKyHocPhanHieuChinh : DevComponents.DotNetBar.Metro.MetroForm
    {

        #region Khai bao bien
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        BLL_MonHoc bll_MonHoc = new BLL_MonHoc();
        BLL_HocKy bll_HocKy = new BLL_HocKy();
        BLL_LopHoc bll_LopHoc = new BLL_LopHoc();
        BLL_ChiTietLopHoc bll_ChiTietLopHoc = new BLL_ChiTietLopHoc();
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
            int stt = 0;
            List<LOPHOC> listLopHoc = bll_LopHoc.SelectAll();
            foreach (usp_SelectLophocsByMaHocKyResult lophoc in bll_LopHoc.SelectByMaHocKy(int.Parse(cbHocKy.SelectedValue.ToString())))
            {
                int soLuongDK = 0;
                foreach (usp_SelectMonhocResult mh in bll_MonHoc.Select(lophoc.MaMonHoc))
                {
                    TenMonHoc = mh.TenMonHoc;
                }
                foreach (usp_SelectChitietlophocsByMaLopHocResult ctlh in bll_ChiTietLopHoc.SelectChiTietLopHocByMaLop(lophoc.MaLopHoc))
                {
                    soLuongDK++;
                }
                bool flag = false;
                foreach (usp_SelectChitietlophocsByMSSVResult ctlh in bll_ChiTietLopHoc.SelectChiTietLopHocByMSSV(tbMaSinhVien.Text))
                {
                    if (ctlh.MaLopHoc == lophoc.MaLopHoc)
                    {
                        flag = true;
                        break;
                    }
                }
                stt++;
                dataGridView2.Rows.Add(new DataGridViewCheckBoxCell(flag), stt, lophoc.MaLopHoc, lophoc.TenLopHoc, TenMonHoc, lophoc.Thu, lophoc.Tiet, soLuongDK);
            }
        }
        #endregion

        public FmThongTinDangKyHocPhanHieuChinh()
        {
            InitializeComponent();
        }

        private void FmThongTinDangKyHocPhanHieuChinh_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
        }

        private void btnHieuChinh_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];
                try
                {
                    if ((bool)cell.EditedFormattedValue == true)
                    {
                        bool flagInsert = true;
                        foreach (usp_SelectChitietlophocsByMSSVResult ctlh in bll_ChiTietLopHoc.SelectChiTietLopHocByMSSV(tbMaSinhVien.Text))
                        {
                            if (ctlh.MaLopHoc.ToString() == row.Cells["MaLop"].Value.ToString())
                            {
                                flagInsert = false;
                                break;
                            }
                        }
                        if (flagInsert)
                        {
                            bll_ChiTietLopHoc.Insert(bll_BoDem.SelectSoDem("CHITIETLOPHOC") + 1, int.Parse(row.Cells["MaLop"].Value.ToString()), tbMaSinhVien.Text);
                        }
                    }
                    else
                    {
                        bool flagDelete = false;
                        int MaCTLH = -1;
                        foreach (usp_SelectChitietlophocsByMSSVResult ctlh in bll_ChiTietLopHoc.SelectChiTietLopHocByMSSV(tbMaSinhVien.Text))
                        {
                            if (ctlh.MaLopHoc.ToString() == row.Cells["MaLop"].Value.ToString())
                            {
                                flagDelete = false;
                                MaCTLH = ctlh.MaCTLopHoc;
                                break;
                            }
                        }
                        if (flagDelete)
                        {
                            bll_ChiTietLopHoc.Delete(MaCTLH);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHocKy();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLopHoc();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}