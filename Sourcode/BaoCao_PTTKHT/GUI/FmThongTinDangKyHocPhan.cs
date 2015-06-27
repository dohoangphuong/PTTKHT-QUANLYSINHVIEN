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
    public partial class FmThongTinDangKyHocPhan : DevComponents.DotNetBar.Metro.MetroForm
    {

        #region Khai bao bien
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        BLL_MonHoc bll_MonHoc = new BLL_MonHoc();
        BLL_HocKy bll_HocKy = new BLL_HocKy();
        BLL_LopHoc bll_LopHoc = new BLL_LopHoc();
        BLL_ChiTietLopHoc bll_ChiTietLopHoc = new BLL_ChiTietLopHoc();
        BLL_GiangDay bll_GiangDay = new BLL_GiangDay();
        BLL_GiangVien bll_GiangVien = new BLL_GiangVien();
        BLL_SinhVien bll_SinhVien = new BLL_SinhVien();
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
            int stt = 0;
            foreach (usp_SelectChitietlophocsByMSSVResult ctlh in bll_ChiTietLopHoc.SelectChiTietLopHocByMSSV(tbMaSinhVien.Text))
            {
                String TenGiangVien = null;
                String TenMonHoc = null;
                int SoTinChi = -1;           
                foreach(usp_SelectLophocResult lophoc in bll_LopHoc.SelectByMaLopHoc(ctlh.MaLopHoc))
                {
                    if (lophoc.MaHocKy.ToString() == cbHocKy.SelectedValue.ToString())
                    { 
                        foreach(usp_SelectMonhocResult mh in bll_MonHoc.Select(lophoc.MaMonHoc))
                        {
                            TenMonHoc = mh.TenMonHoc;
                            SoTinChi = mh.SoTinChi;
                        }
                        foreach (usp_SelectGiangdaysByMaLopHocResult gd in bll_GiangDay.SelectGiangDayByMaLopHoc(lophoc.MaLopHoc))
                        {
                            foreach (usp_SelectGiangvienResult gv in bll_GiangVien.Select(gd.MaGiangVien))
                            {
                                TenGiangVien += (gv.TenGiangVien + "-");
                            }                  
                        }
                        TenGiangVien = TenGiangVien.Remove(TenGiangVien.Length - 1);
                        stt++;
                        dataGridView2.Rows.Add(stt, lophoc.MaLopHoc, lophoc.TenLopHoc, TenMonHoc, TenGiangVien, SoTinChi, lophoc.Thu, lophoc.Tiet);
                    }
                }
            }
            
        }
        #endregion

        public FmThongTinDangKyHocPhan()
        {
            InitializeComponent();
        }

        public FmThongTinDangKyHocPhan(String _MSSV)
        {
            InitializeComponent();
            tbMaSinhVien.Text = _MSSV;
            foreach (usp_SelectSinhvienResult sv in bll_SinhVien.Select(_MSSV))
            {
                tbTenSinhVien.Text = sv.TenSinhVien;
            }
        }

        private void FmThongTinDangKyHocPhan_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHocKy();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(String.IsNullOrEmpty(tbMaSinhVien.Text) || String.IsNullOrEmpty(tbTenSinhVien.Text)))
            {
                LoadLopHoc();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}