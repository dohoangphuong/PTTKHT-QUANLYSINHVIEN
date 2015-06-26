using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using Settings = BaoCao_PTTKHT.Properties.Settings;

namespace BaoCao_PTTKHT.GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmQuanLy());

            //if (String.IsNullOrEmpty(Settings.Default.ConnectString))
            //{
            //    Application.Run(new GUI.FmConnectDatabase());
            //}
            //else
            //{
            //    try
            //    {
            //        using (SqlConnection connection = new SqlConnection(Settings.Default.ConnectString))
            //        {
            //            connection.Open();
            //            connection.Close();
            //        }
            //    }
            //    catch
            //    {
            //        Settings.Default.ConnectString = null;
            //        MessageBox.Show("Cơ sở dữ liệu của bạn đã bị lỗi, vui lòng tạo cơ sở dữ liệu mới", "Error");
            //        Application.Run(new FmConnectDatabase());
            //    }
            //}

            //if (!String.IsNullOrEmpty(Settings.Default.ConnectString))
            //    Application.Run(new FmMain());
        }
    }
}
