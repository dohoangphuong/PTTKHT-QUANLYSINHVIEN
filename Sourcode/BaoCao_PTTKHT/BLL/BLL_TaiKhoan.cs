using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaoCao_PTTKHT.DAL;
using System.Data.Linq;
using Settings = BaoCao_PTTKHT.Properties.Settings;

namespace BaoCao_PTTKHT.BLL
{
    class BLL_TaiKhoan
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca tai khoan
        public List<TAIKHOAN> SelectAll()
        {
            return DB.TAIKHOANs.ToList();
        }

        //Lay tai khoan theo ten tai khoan
        public ISingleResult<usp_SelectTaikhoanResult> Select(String _TenTaiKhoan)
        {
            return DB.usp_SelectTaikhoan(_TenTaiKhoan);
        }

        //Insert tai khoan moi
        public void Insert(String _TenTaiKhoan, String _MatKhau, String _TenNguoiDung, int _LoaiTaiKhoan)
        {
            DB.usp_InsertTaikhoan(_TenTaiKhoan, _MatKhau, _TenNguoiDung, _LoaiTaiKhoan);
        }

        //Cap nhat tai khoan
        public void Update(String _TenTaiKhoan, String _MatKhau, String _TenNguoiDung, int _LoaiTaiKhoan)
        {
            DB.usp_UpdateTaikhoan(_TenTaiKhoan, _MatKhau, _TenNguoiDung, _LoaiTaiKhoan);
        }

        //Xoa tai khoan
        public void Delete(String _TenTaiKhoan)
        {
            DB.usp_DeleteTaikhoan(_TenTaiKhoan);
        }
    }
}
