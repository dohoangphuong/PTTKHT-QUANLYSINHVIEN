using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace BaoCao_PTTKHT.GUI
{
    public partial class FmQuanLyTaiKhoan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (textBox1.Text.Length >= 30 && key != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (textBox6.Text.Length >= 100 && key != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = Convert.ToInt16(e.KeyChar);
            if (textBox6.Text.Length >= 50 && key != 8)
            {
                e.Handled = true;
            }
        }
    }
}