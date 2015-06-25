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
    class BLL_GiangDay
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca giang day
        public List<GIANGDAY> SelectAll()
        {
            return DB.GIANGDAYs.ToList();
        }

        //Lay giang day theo giang vien
        public ISingleResult<usp_SelectGiangdaysByMaGiangVienResult> SelectGiangDayByMaGiangVien(String _MaGiangVien)
        {
            return DB.usp_SelectGiangdaysByMaGiangVien(_MaGiangVien);
        }

        //Lay giang day theo Ma lop
        public ISingleResult<usp_SelectGiangdaysByMaLopHocResult> SelectGiangDayByMaLopHoc(int _MaLopHoc)
        {
            return DB.usp_SelectGiangdaysByMaLopHoc(_MaLopHoc);
        }

        //Insert giang day
        public void Insert(int _MaGiangDay, int _MaLopHoc, String _MaGiangVien)
        {
            DB.usp_InsertGiangday(_MaGiangDay, _MaLopHoc, _MaGiangVien);
        }

        //Cap nhat giang day
        public void Update(int _MaGiangDay, int _MaLopHoc, String _MaGiangVien)
        {
            DB.usp_UpdateGiangday(_MaGiangDay, _MaLopHoc, _MaGiangVien);
        }

        //Xoa mon hoc
        public void Delete(int _MaGiangDay)
        {
            DB.usp_DeleteGiangday(_MaGiangDay);
        }
    }
}
