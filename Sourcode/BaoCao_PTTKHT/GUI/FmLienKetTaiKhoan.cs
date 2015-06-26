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
    public partial class FmLienKetTaiKhoan : DevComponents.DotNetBar.Metro.MetroForm
    {
        #region Khai bao bien
        BLL_TaiKhoan bll_TaiKhoan = new BLL_TaiKhoan();
        BLL_SinhVien bll_SinhVien = new BLL_SinhVien();
        BLL_GiangVien bll_GiangVien = new BLL_GiangVien();
        BLL_LienKetTaiKhoan bll_LienKetTaiKhoan = new BLL_LienKetTaiKhoan();
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
        //Load giang vien
        public void LoadGiangVien()
        { 
            BindingList<Data> _comboItems = new BindingList<Data>();
            foreach (GIANGVIEN gv in bll_GiangVien.SelectAll())
            { 
                _comboItems.Add(new Data { Name = gv.MaGiangVien, ID = gv.TenGiangVien });
            }

            cbMaGiangVien.DisplayMember = "Name";
            cbMaGiangVien.ValueMember = "ID";
            cbMaGiangVien.DataSource = _comboItems;
            if (cbMaGiangVien.Items.Count > 0)
                cbMaGiangVien.SelectedIndex = 0;
        }

        //Load sinh vien
        public void LoadSinhVien()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            foreach (SINHVIEN sv in bll_SinhVien.SelectAll())
            {
                _comboItems.Add(new Data { Name = sv.MSSV, ID = sv.TenSinhVien });
            }

            cbMSSV.DisplayMember = "Name";
            cbMSSV.ValueMember = "ID";
            cbMSSV.DataSource = _comboItems;
            if (cbMSSV.Items.Count > 0)
                cbMSSV.SelectedIndex = 0;
        }

        //Load tai khoan
        public void LoadTaiKhoan()
        {
            BindingList<Data> _comboItems = new BindingList<Data>();
            foreach (TAIKHOAN tk in bll_TaiKhoan.SelectAll())
            {
                _comboItems.Add(new Data { Name = tk.TenTaiKhoan, ID = tk.LoaiTaiKhoan.ToString() });
            }

            cbTaiKhoan.DisplayMember = "Name";
            cbTaiKhoan.ValueMember = "ID";
            cbTaiKhoan.DataSource = _comboItems;
            if (cbTaiKhoan.Items.Count > 0)
                cbTaiKhoan.SelectedIndex = 0;
        }
        #endregion

        public FmLienKetTaiKhoan()
        {
            InitializeComponent();
        }

        private void FmLienKetTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadTaiKhoan();
            LoadSinhVien();
            LoadGiangVien();
        }

        private void cbTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbTaiKhoan.SelectedValue.ToString())
            { 
                case "1":
                    cbMSSV.Enabled = true;
                    cbMaGiangVien.Enabled = false;
                    foreach (usp_SelectLienKetTKsByTenTaiKhoanResult lk in bll_LienKetTaiKhoan.SelectLienKetTKByTenTaiKhoan(cbTaiKhoan.Text))
                    {
                        cbMSSV.Text = lk.MSSV;
                    }
                    break;
                case "2":
                    cbMSSV.Enabled = false;
                    cbMaGiangVien.Enabled = true;
                    foreach (usp_SelectLienKetTKsByTenTaiKhoanResult lk in bll_LienKetTaiKhoan.SelectLienKetTKByTenTaiKhoan(cbTaiKhoan.Text))
                    {
                        cbMaGiangVien.Text = lk.MaGiangVien;
                    }
                    break;
                default:
                    cbMSSV.Enabled = false;
                    cbMaGiangVien.Enabled = false;
                    break;
            }
        }

        private void cbMSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTenSinhVien.Text = cbMSSV.SelectedValue.ToString();
        }

        private void cbMaGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTenGiangVien.Text = cbMaGiangVien.SelectedValue.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            switch (cbTaiKhoan.SelectedValue.ToString())
            { 
                case "1":
                    try
                    {
                        bool flagSV = true;
                        foreach (usp_SelectLienKetTKsByTenTaiKhoanResult lk in bll_LienKetTaiKhoan.SelectLienKetTKByTenTaiKhoan(cbTaiKhoan.Text))
                        {
                            flagSV = false;
                            bll_LienKetTaiKhoan.Update(lk.MaLK, cbTaiKhoan.Text, cbMSSV.Text, null);
                        }
                        if (flagSV)
                        {
                            bll_LienKetTaiKhoan.Insert(bll_BoDem.SelectSoDem("LIENKETTK") + 1, cbTaiKhoan.Text, cbMSSV.Text, null);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "2":
                    try
                    {
                        bool flagGV = true;
                        foreach (usp_SelectLienKetTKsByTenTaiKhoanResult lk in bll_LienKetTaiKhoan.SelectLienKetTKByTenTaiKhoan(cbTaiKhoan.Text))
                        {
                            flagGV = false;
                            bll_LienKetTaiKhoan.Update(lk.MaLK, cbTaiKhoan.Text, null, cbMaGiangVien.Text);
                        }
                        if (flagGV)
                        {
                            bll_LienKetTaiKhoan.Insert(bll_BoDem.SelectSoDem("LIENKETTK") + 1, cbTaiKhoan.Text, null, cbMaGiangVien.Text);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    MessageBox.Show("Tài khoản không thể liên kết", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            bll_LienKetTaiKhoan.DeleteByTenTaiKhaon(cbTaiKhoan.Text);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}