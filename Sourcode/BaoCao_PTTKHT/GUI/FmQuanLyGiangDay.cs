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
    public partial class FmQuanLyGiangDay : DevComponents.DotNetBar.Metro.MetroForm
    {
        /*
         * LƯU Ý: Mã Giảng Dạy nếu chọn vào mới thì sẽ tự động sinh khi chọn hết giá trị.->Tạo mới giảng dạy
         * và khi chọn lại giảng dạy thì sẽ cập nhật thêm thông tin.
         * */
        public FmQuanLyGiangDay()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}