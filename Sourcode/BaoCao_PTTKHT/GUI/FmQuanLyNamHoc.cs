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
    public partial class FmQuanLyNamHoc : DevComponents.DotNetBar.Metro.MetroForm
    {
        #region khai bao bien
        BLL_NamHoc bll_NamHoc = new BLL_NamHoc();
        BLL_BoDem bll_BoDem = new BLL_BoDem();
        BLL_HocKy bll_HocKy = new BLL_HocKy();
        #endregion

        #region Ham
        //Load nam hoc
        public void LoadNam()
        {
            dataGridView2.Rows.Clear();
            List<NAMHOC> listNamHoc = bll_NamHoc.SelectAll();
            int stt = 0;
            foreach (NAMHOC namhoc in listNamHoc)
            {
                stt++;
                dataGridView2.Rows.Add(stt, namhoc.MaNamHoc, namhoc.NamHoc1);
            }
        }
        #endregion

        public FmQuanLyNamHoc()
        {
            InitializeComponent();
        }

        private void tbNamBatDau_TextChanged(object sender, EventArgs e)
        {
            if (tbNamBatDau.Text.Length > 0)
            {
                tbNamKetThuc.Text = (int.Parse(tbNamBatDau.Text) + 1).ToString();
            }
            else
            {
                tbNamKetThuc.Text = "";
            }
        }

        private void tbNamKetThuc_TextChanged(object sender, EventArgs e)
        {
            if (tbNamKetThuc.Text.Length > 0)
            {
                tbNamBatDau.Text = (int.Parse(tbNamKetThuc.Text) - 1).ToString();
            }
            else
            {
                tbNamBatDau.Text = "";
            }
        }

        private void tbNamBatDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (tbNamBatDau.Text.Length >= 4 && key != 8)
            {
                e.Handled = true;
            }
        }

        private void tbNamKetThuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (key > 47 && key < 58 || key == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (tbNamKetThuc.Text.Length >= 4 && key != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                tbMaNamHoc.Text = dataGridView2.CurrentRow.Cells["MaNH"].Value.ToString();
                string[] temp = dataGridView2.CurrentRow.Cells["NamHoc"].Value.ToString().Split('-');
                tbNamBatDau.Text = temp[0];
            }
        }

        private void FmQuanLyNamHoc_Load(object sender, EventArgs e)
        {
            LoadNam();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNamKetThuc.Text) >= 2000)
            {
                String namHoc = tbNamBatDau.Text + "-" + tbNamKetThuc.Text;
                bool flag = true;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells["NamHoc"].Value.ToString() == namHoc)
                    {  
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    int MaNH = bll_BoDem.SelectSoDem("NAMHOC") + 1;
                    bll_NamHoc.Insert(MaNH, tbNamBatDau.Text + "-" + tbNamKetThuc.Text);
                    bll_HocKy.Insert(bll_BoDem.SelectSoDem("HOCKY") + 1, "HK I", MaNH);
                    bll_HocKy.Insert(bll_BoDem.SelectSoDem("HOCKY") + 1, "HK II", MaNH);
                    bll_HocKy.Insert(bll_BoDem.SelectSoDem("HOCKY") + 1, "HK Hè", MaNH);
                    LoadNam();
                }
                else
                {
                    MessageBox.Show("Năm học đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Năm học phải từ năm 2000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("Dữ liệu có thể sẽ bị mất nếu bạn xóa năm học. Bạn có chắc chắn không", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (DialogResult.Yes == dr)
                {
                    bll_NamHoc.Delete(int.Parse(dataGridView2.CurrentRow.Cells["MaNH"].Value.ToString()));
                    LoadNam();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}