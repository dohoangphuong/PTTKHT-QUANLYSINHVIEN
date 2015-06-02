using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace BaoCao_PTTKHT
{
    public partial class FmQuanLyMonHocTienQuyet : DevComponents.DotNetBar.Metro.MetroForm
    {
        /*
         * YÊU CẦU: tìm sv      -> group sinh viên không được bỏ trống
         *          tìm lớp học -> group lớp học k được bỏ trống
         * LƯU Ý: Các combobox: thể hiện cho việc lựa chọn
         *          Còn các texbox chỉ cho hiện các lựa chọn nhưng bị Enable
         */
        public FmQuanLyMonHocTienQuyet()
        {
            InitializeComponent();
        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}