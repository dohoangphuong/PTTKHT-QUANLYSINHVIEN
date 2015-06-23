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
    class BLL_SinhVien
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca sinh vien
        public List<SINHVIEN> SelectAll()
        {
            return DB.SINHVIENs.ToList();
        }

        //Lay sv theo mssv
        public ISingleResult<usp_SelectSinhvienResult> SelectByMSSV(String _MSSV)
        {
            return DB.usp_SelectSinhvien(_MSSV);
        }

        //Insert sv moi
        public void Insert(String _MSSV, String _HoTen, String _DiaChi, DateTime _NgaySinh, String _GioiTinh, String _DienThoai, String _MaLop)
        {
            DB.usp_InsertSinhvien(_MSSV, _HoTen, _NgaySinh, _DiaChi, _GioiTinh, _DienThoai, _MaLop);
        }

        //Cap nhat sv
        public void Update(String _MSSV, String _HoTen, String _DiaChi, DateTime _NgaySinh, String _GioiTinh, String _DienThoai, String _MaLop)
        {
            DB.usp_UpdateSinhvien(_MSSV, _HoTen, _NgaySinh, _DiaChi, _GioiTinh, _DienThoai, _MaLop);
        }

        //Xoa sv
        public void Delete(String _MSSV)
        {
            DB.usp_DeleteSinhvien(_MSSV);
        }

        //Lay ma sinh vien cuoi theo nam
        public String SelectMssvByNam(int _Nam)
        {
            try
            {
                return DB.usp_SelectLastSinhviensByNam(_Nam).First().MSSV;
            }
            catch
            {
                return "-1";
            }
        }
    }
}
