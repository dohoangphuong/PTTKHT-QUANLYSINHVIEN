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
    public partial class FmQuanLyDiemLopCT : DevComponents.DotNetBar.Metro.MetroForm
    {
        #region khai bao bien
        BLL_SinhVien bll_SinhVien = new BLL_SinhVien();
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        BLL_BangDiem bll_BangDiem = new BLL_BangDiem();
        BLL_Diem bll_Diem = new BLL_Diem();
        BLL_HeSoLopHoc bll_HeSoLopHoc = new BLL_HeSoLopHoc();
        BLL_HocKy bll_HocKy = new BLL_HocKy();
        BLL_BoDem bll_BoDem = new BLL_BoDem();
        BLL_LopHoc bll_LopHoc = new BLL_LopHoc();
        BLL_MonHoc bll_MonHoc = new BLL_MonHoc();
        BLL_ChiTietLopHoc bll_ChiTietLopHoc = new BLL_ChiTietLopHoc();
        double? PreviousValue;
        List<int> ListRowIndexChanged = new List<int>();
        #endregion

        #region wrapper
        public class Data
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
            BindingList<Data> _comboItems = new BindingList<Data>();
            BindingList<Data> _comboItems2 = new BindingList<Data>();
            foreach (usp_SelectLophocsByMaHocKyResult lophoc in bll_LopHoc.SelectByMaHocKy(int.Parse(cbHocKy.SelectedValue.ToString())))
            {
                _comboItems.Add(new Data { Name = lophoc.TenLopHoc, ID = lophoc.MaLopHoc.ToString() });
                _comboItems2.Add(new Data { Name = lophoc.MaLopHoc.ToString(), ID = lophoc.TenLopHoc });
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

        //Load he so
        public void LoadHeSo()
        {
            int i = 0;
            int maLop = int.Parse(cbMaLop.Text);
            foreach (usp_SelectHesolophocsByMaLopHocResult heso in bll_HeSoLopHoc.SelectHeSoLopHocByMaLopHoc(maLop))
            {
                switch (heso.LoaiDiem)
                { 
                    case "GK":
                        tbHSGiuaKy.Text = heso.HeSo.ToString();
                        tbHSGiuaKy.Tag = heso.MaHeSo;
                        break;
                    case "TH":
                        tbHSThucHanh.Text = heso.HeSo.ToString();
                        tbHSThucHanh.Tag = heso.MaHeSo;
                        break;
                    default:
                        tbHSCuoiKy.Text = heso.HeSo.ToString();
                        tbHSCuoiKy.Tag = heso.MaHeSo;
                        break;
                }
                i++;
            }
        }

        //Load textbox 
        public void LoadTextBox()
        {
            foreach (usp_SelectLophocResult lh in bll_LopHoc.SelectByMaLopHoc(int.Parse(cbMaLop.Text)))
            {
                foreach (usp_SelectMonhocResult mh in bll_MonHoc.Select(lh.MaMonHoc))
                {
                    tbMonHoc.Text = mh.TenMonHoc;
                }
            }

            int SiSo = 0;
            foreach (usp_SelectChitietlophocsByMaLopHocResult ctlh in bll_ChiTietLopHoc.SelectChiTietLopHocByMaLop(int.Parse(cbMaLop.Text)))
            {
                SiSo++;
            }
            tbSiSo.Text = SiSo.ToString();
        }

        //Load datagridview
        public void LoadDataGridView()
        {
            dataGridView2.Rows.Clear();
            int stt = 0;
            foreach (usp_SelectChitietlophocsByMaLopHocResult ctlh in bll_ChiTietLopHoc.SelectChiTietLopHocByMaLop(int.Parse(cbMaLop.Text)))
            {
                foreach (usp_SelectSinhvienResult sv in bll_SinhVien.Select(ctlh.MSSV))
                {
                    stt++;
                    int rowIndex = dataGridView2.Rows.Add(stt, sv.MSSV, sv.TenSinhVien);
                    var row = dataGridView2.Rows[rowIndex];
                    foreach (usp_SelectBangdiemsByMaLopHoc_MSSVResult bd in bll_BangDiem.SelectBangDiemByMaLop_MSSV(int.Parse(cbMaLop.Text), sv.MSSV))
                    {
                        foreach (usp_SelectDiemsByMaBangDiemResult diem in bll_Diem.SelectByMaBangDiem(bd.MaBangDiem))
                        {
                            foreach (usp_SelectHesolophocResult hslh in bll_HeSoLopHoc.Select(diem.MaHeSo))
                            {
                                switch (hslh.LoaiDiem)
                                {
                                    case "GK":
                                        row.Cells["DiemGK"].Value = diem.SoDiem;
                                        row.Cells["MaDiemGK"].Value = diem.MaDiem;
                                        break;
                                    case "TH":
                                        row.Cells["DiemTH"].Value = diem.SoDiem;
                                        row.Cells["MaDiemTH"].Value = diem.MaDiem;
                                        break;
                                    default:
                                        row.Cells["DiemCK"].Value = diem.SoDiem;
                                        row.Cells["MaDiemCK"].Value = diem.MaDiem;
                                        break;
                                }
                            }
                        }
                        foreach(usp_SelectDiemTrungBinhByMaBangDiemResult dtb in bll_BangDiem.SelectDiemTrungBinhByMaBangDiem(bd.MaBangDiem))
                        {
                            row.Cells["DiemHP"].Value = dtb.Column1;
                        }
                        row.Cells["MaBangDiem"].Value = bd.MaBangDiem;
                    }
                }
            }
        }
        #endregion

        public FmQuanLyDiemLopCT()
        {
            InitializeComponent();
        }

        private void FmQuanLyDiemLopCT_Load(object sender, EventArgs e)
        {
            LoadNam();
        }

        private void cbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHocKy();
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLopHoc();
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListRowIndexChanged.Clear();
            cbTenLop.SelectedValue = cbMaLop.Text;
            LoadTextBox();
            LoadHeSo();
            LoadDataGridView();
        }

        private void cbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaLop.SelectedValue = cbTenLop.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            foreach (int index in ListRowIndexChanged)
            {
                //Khong ton tai bang diem truoc
                if (dataGridView2.Rows[index].Cells["MaBangDiem"].Value == null)
                {
                    int maBangDiem = bll_BoDem.SelectSoDem("BANGDIEM") + 1;
                    bll_BangDiem.Insert(maBangDiem, int.Parse(cbMaLop.Text), dataGridView2.Rows[index].Cells["MaSV"].Value.ToString());
                    //Them diem giua ky
                    if (dataGridView2.Rows[index].Cells["DiemGK"].Value != null)
                    {
                        bll_Diem.Insert(bll_BoDem.SelectSoDem("DIEM") + 1, int.Parse(dataGridView2.Rows[index].Cells["DiemGK"].Value.ToString()), int.Parse(tbHSGiuaKy.Tag.ToString()), maBangDiem);
                    }
                    //Them diem thuc hanh
                    if (dataGridView2.Rows[index].Cells["DiemTH"].Value != null)
                    {
                        bll_Diem.Insert(bll_BoDem.SelectSoDem("DIEM") + 1, int.Parse(dataGridView2.Rows[index].Cells["DiemTH"].Value.ToString()), int.Parse(tbHSThucHanh.Tag.ToString()), maBangDiem);
                    }
                    //Them diem cuoi ky
                    if (dataGridView2.Rows[index].Cells["DiemCK"].Value != null)
                    {
                        bll_Diem.Insert(bll_BoDem.SelectSoDem("DIEM") + 1, int.Parse(dataGridView2.Rows[index].Cells["DiemCK"].Value.ToString()), int.Parse(tbHSCuoiKy.Tag.ToString()), maBangDiem);
                    }
                }
                else
                {
                    if (dataGridView2.Rows[index].Cells["DiemGK"].Value != null)
                    {
                        //Neu diem giua ky chua co
                        if (dataGridView2.Rows[index].Cells["MaDiemGK"].Value == null)
                        {
                            bll_Diem.Insert(bll_BoDem.SelectSoDem("DIEM") + 1, int.Parse(dataGridView2.Rows[index].Cells["DiemGK"].Value.ToString()), int.Parse(tbHSGiuaKy.Tag.ToString()), int.Parse(dataGridView2.Rows[index].Cells["MaBangDiem"].Value.ToString()));
                        }
                        else
                        {
                            bll_Diem.Update(int.Parse(dataGridView2.Rows[index].Cells["MaDiemGK"].Value.ToString()), int.Parse(dataGridView2.Rows[index].Cells["DiemGK"].Value.ToString()), int.Parse(tbHSGiuaKy.Tag.ToString()), int.Parse(dataGridView2.Rows[index].Cells["MaBangDiem"].Value.ToString()));
                        }
                        //Neu diem thuc hanh chua co
                        if (dataGridView2.Rows[index].Cells["MaDiemTH"].Value == null)
                        {
                            bll_Diem.Insert(bll_BoDem.SelectSoDem("DIEM") + 1, int.Parse(dataGridView2.Rows[index].Cells["DiemTH"].Value.ToString()), int.Parse(tbHSThucHanh.Tag.ToString()), int.Parse(dataGridView2.Rows[index].Cells["MaBangDiem"].Value.ToString()));
                        }
                        else
                        {
                            bll_Diem.Update(int.Parse(dataGridView2.Rows[index].Cells["MaDiemTH"].Value.ToString()), int.Parse(dataGridView2.Rows[index].Cells["DiemTH"].Value.ToString()), int.Parse(tbHSThucHanh.Tag.ToString()), int.Parse(dataGridView2.Rows[index].Cells["MaBangDiem"].Value.ToString()));
                        }
                        //Neu diem cuoi ky chua co
                        if (dataGridView2.Rows[index].Cells["MaDiemCK"].Value == null)
                        {
                            bll_Diem.Insert(bll_BoDem.SelectSoDem("DIEM") + 1, int.Parse(dataGridView2.Rows[index].Cells["DiemCK"].Value.ToString()), int.Parse(tbHSCuoiKy.Tag.ToString()), int.Parse(dataGridView2.Rows[index].Cells["MaBangDiem"].Value.ToString()));
                        }
                        else
                        {
                            bll_Diem.Update(int.Parse(dataGridView2.Rows[index].Cells["MaDiemCK"].Value.ToString()), int.Parse(dataGridView2.Rows[index].Cells["DiemCK"].Value.ToString()), int.Parse(tbHSCuoiKy.Tag.ToString()), int.Parse(dataGridView2.Rows[index].Cells["MaBangDiem"].Value.ToString()));
                        }
                    }
                }
            }
            ListRowIndexChanged.Clear();
            LoadDataGridView();
        }

        private void btnSuaHeSo_Click(object sender, EventArgs e)
        {
            bll_HeSoLopHoc.Update(int.Parse(tbHSGiuaKy.Tag.ToString()), int.Parse(cbMaLop.Text), int.Parse(tbHSGiuaKy.Text), "GK");
            bll_HeSoLopHoc.Update(int.Parse(tbHSThucHanh.Tag.ToString()), int.Parse(cbMaLop.Text), int.Parse(tbHSThucHanh.Text), "TH");
            bll_HeSoLopHoc.Update(int.Parse(tbHSCuoiKy.Tag.ToString()), int.Parse(cbMaLop.Text), int.Parse(tbHSCuoiKy.Text), "CK");
            LoadDataGridView();
            MessageBox.Show("Sửa hệ số thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double _Diem = -1;
            if (double.TryParse(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out _Diem))
            {
                if (_Diem > 10 || _Diem < 0)
                {
                    MessageBox.Show("Điểm không được vượt quá 10 hay nhỏ hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = PreviousValue;
                    dataGridView2.CancelEdit();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Điểm chỉ có thể là số", "Errow", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = PreviousValue;
                dataGridView2.CancelEdit();
                return;
            }
            double TongDiem = 0;
            int TongHeSo = 0;
            if (dataGridView2.Rows[e.RowIndex].Cells["DiemGK"].Value != null)
            {
                TongDiem += int.Parse(dataGridView2.Rows[e.RowIndex].Cells["DiemGK"].Value.ToString()) * int.Parse(tbHSGiuaKy.Text);
                TongHeSo += int.Parse(tbHSGiuaKy.Text);
            }
            if (dataGridView2.Rows[e.RowIndex].Cells["DiemTH"].Value != null)
            {
                TongDiem += int.Parse(dataGridView2.Rows[e.RowIndex].Cells["DiemTH"].Value.ToString()) * int.Parse(tbHSThucHanh.Text);
                TongHeSo += int.Parse(tbHSThucHanh.Text);
            }
            if (dataGridView2.Rows[e.RowIndex].Cells["DiemCK"].Value != null)
            {
                TongDiem += int.Parse(dataGridView2.Rows[e.RowIndex].Cells["DiemCK"].Value.ToString()) * int.Parse(tbHSCuoiKy.Text);
                TongHeSo += int.Parse(tbHSCuoiKy.Text);
            }
            ListRowIndexChanged.Add(e.RowIndex);
            dataGridView2.Rows[e.RowIndex].Cells["DiemHP"].Value = TongDiem / TongHeSo;
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                PreviousValue = double.Parse(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
            catch
            {
                PreviousValue = null;
            }
        }
    }
}