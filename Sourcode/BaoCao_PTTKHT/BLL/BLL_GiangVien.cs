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
    class BLL_GiangVien
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca giang vien
        public List<GIANGVIEN> SelectAll()
        {
            return DB.GIANGVIENs.ToList();
        }

        //Lay gv theo ma giang vien
        public ISingleResult<usp_SelectGiangvienResult> SelectByMSSV(String _MaGiangVien)
        {
            return DB.usp_SelectGiangvien(_MaGiangVien);
        }

        //Insert gv moi
        public void Insert(String MSSV, String _HoTen, String _DiaChi, DateTime _NgaySinh, String _GioiTinh, String _ChucVu, String _MaLop)
        {
            DB.usp_InsertGiangvien(MSSV, _HoTen, _NgaySinh, _DiaChi, _GioiTinh, _ChucVu, _MaLop);
        }

        //Cap nhat gv
        public void Update(String MSSV, String _HoTen, String _DiaChi, DateTime _NgaySinh, String _GioiTinh, String _ChucVu, String _MaLop)
        {
            DB.usp_UpdateGiangvien(MSSV, _HoTen, _NgaySinh, _DiaChi, _GioiTinh, _ChucVu, _MaLop);
        }

        //Xoa gv
        public void Delete(String MSSV)
        {
            DB.usp_DeleteGiangvien(MSSV);
        }
    }
}
