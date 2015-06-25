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
        public ISingleResult<usp_SelectGiangvienResult> Select(String _MaGiangVien)
        {
            return DB.usp_SelectGiangvien(_MaGiangVien);
        }

        //Insert gv moi
        public void Insert(String MaGV, String _HoTen, String _DiaChi, DateTime _NgaySinh, String _GioiTinh, String _DienThoai, String _ChucVu, String _TrinhDo, String _MaKhoa)
        {
            DB.usp_InsertGiangvien(MaGV, _HoTen, _NgaySinh, _DiaChi, _GioiTinh, _DienThoai, _ChucVu, _TrinhDo, _MaKhoa);
        }

        //Cap nhat gv
        public void Update(String MaGV, String _HoTen, String _DiaChi, DateTime _NgaySinh, String _GioiTinh, String _DienThoai, String _ChucVu, String _TrinhDo, String _MaKhoa)
        {
            DB.usp_UpdateGiangvien(MaGV, _HoTen, _NgaySinh, _DiaChi, _GioiTinh, _DienThoai, _ChucVu, _TrinhDo, _MaKhoa);
        }

        //Xoa gv
        public void Delete(String _MaGiangVien)
        {
            DB.usp_DeleteGiangvien(_MaGiangVien);
        }
    }
}
