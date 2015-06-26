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
    public partial class FmQuanLyDiemSinhVienCT : DevComponents.DotNetBar.Metro.MetroForm
    {
        #region khai bao bien
        BLL_SinhVien bll_SinhVien = new BLL_SinhVien();
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        BLL_Khoa bll_Khoa = new BLL_Khoa();
        BLL_Lop bll_Lop = new BLL_Lop();
        BLL_BangDiem bll_BangDiem = new BLL_BangDiem();
        BLL_Diem bll_Diem = new BLL_Diem();
        BLL_MonHoc bll_MonHoc = new BLL_MonHoc();
        BLL_ChiTietLopHoc bll_ChiTietLopHoc = new BLL_ChiTietLopHoc();
        BLL_LopHoc bll_LopHoc = new BLL_LopHoc();
        BLL_HocKy bll_HocKy = new BLL_HocKy();
        BLL_HeSoLopHoc bll_HeSoLopHoc = new BLL_HeSoLopHoc();
        String MSSV = null;
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
        public void LoadNamHoc()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            List<NAMHOC> listNamHoc = bll_NamHoc.SelectAll();
            int NamHocSV = 0;
            foreach(usp_SelectSinhvienResult sv in bll_SinhVien.Select(MSSV))
            {
                foreach (usp_SelectLopResult lh in bll_Lop.Select(sv.MaLop))
                {
                    foreach (usp_SelectNamhocResult nh in bll_NamHoc.Select(lh.MaNamHoc))
                    {
                        NamHocSV = int.Parse(nh.NamHoc.Substring(0, 4));
                    }
                }
            }
            foreach (NAMHOC namhoc in listNamHoc)
            {
                if (int.Parse(namhoc.NamHoc1.Substring(0, 4)) >= NamHocSV)
                {
                    _comboItems.Add(new Data { Name = namhoc.NamHoc1, ID = namhoc.MaNamHoc.ToString() });
                }
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

        //Load Sinh vien
        public void LoadThongTinSV()
        {
            foreach (usp_SelectSinhvienResult sv in bll_SinhVien.Select(MSSV))
            {
                tbMaSinhVien.Text = MSSV;
                tbTenSinhVien.Text = sv.TenSinhVien;
                tbDiaChi.Text = sv.DiaChi;
                tbDienThoai.Text = sv.DienThoai;
                tbGioiTinh.Text = sv.GioiTinh;
                dtpNgaySinh.Value = sv.NgaySinh;
                foreach (usp_SelectLopResult lop in bll_Lop.Select(sv.MaLop))
                {
                    tbLopKhoa.Text = lop.TenLop;
                    foreach (usp_SelectKhoaResult khoa in bll_Khoa.Select(lop.MaKhoa))
                    {
                        tbKhoa.Text = khoa.TenKhoa;
                    }
                }
            }
        }

        //Load Diem
        public void LoadDiem()
        {
            datagridview1.Rows.Clear();
            int stt = 0;
            int rowIndex = -1;
            foreach (usp_SelectBangdiemsByMSSVResult bd in bll_BangDiem.SelectBangDiemByMSSV(MSSV))
            {
                foreach (usp_SelectLophocResult lh in bll_LopHoc.SelectByMaLopHoc(bd.MaLopHoc))
                {
                    if (lh.MaHocKy.ToString() == cbHocKy.SelectedValue.ToString())
                    {
                        foreach (usp_SelectMonhocResult mh in bll_MonHoc.Select(lh.MaMonHoc))
                        { 
                            stt++;
                            rowIndex = datagridview1.Rows.Add(stt, mh.MaMonHoc, mh.TenMonHoc, mh.SoTinChi);
                        }

                        var row = datagridview1.Rows[rowIndex];
                        foreach (usp_SelectDiemsByMaBangDiemResult diem in bll_Diem.SelectByMaBangDiem(bd.MaBangDiem))
                        {
                            foreach (usp_SelectHesolophocResult hslh in bll_HeSoLopHoc.Select(diem.MaHeSo))
                            {
                                switch (hslh.LoaiDiem)
                                {
                                    case "GK":
                                        row.Cells["DiemGK"].Value = diem.SoDiem;
                                        break;
                                    case "TH":
                                        row.Cells["DiemTH"].Value = diem.SoDiem;
                                        break;
                                    default:
                                        row.Cells["DiemCK"].Value = diem.SoDiem;
                                        break;
                                }
                            }
                        }

                        foreach (usp_SelectDiemTrungBinhByMaBangDiemResult dtb in bll_BangDiem.SelectDiemTrungBinhByMaBangDiem(bd.MaBangDiem))
                        {
                            row.Cells["DiemHP"].Value = dtb.Column1;
                        }
                    }
                }
                
            }
        }
        #endregion

        public FmQuanLyDiemSinhVienCT()
        {
            InitializeComponent();
        }

        public FmQuanLyDiemSinhVienCT(String _MSSV)
        {
            InitializeComponent();
            MSSV = _MSSV;
        }

        private void FmQuanLyDiemSinhVienCT_Load(object sender, EventArgs e)
        {
            LoadThongTinSV();
            LoadNamHoc();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHocKy();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiem();
        }
    }
}