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
    class BLL_BangDiem
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca bang diem
        public List<BANGDIEM> SelectAll()
        {
            return DB.BANGDIEMs.ToList();
        }

        //Lay bang diem theo ma bang diem
        public ISingleResult<usp_SelectBangdiemResult> Select(int _MaBangDiem)
        {
            return DB.usp_SelectBangdiem(_MaBangDiem);
        }

        //Lay diem trung binh theo ma bang diem
        public ISingleResult<usp_SelectDiemTrungBinhByMaBangDiemResult> SelectDiemTrungBinhByMaBangDiem(int _MaBangDiem)
        {
            return DB.usp_SelectDiemTrungBinhByMaBangDiem(_MaBangDiem);
        }

        //Lay bang diem theo ma lop
        public ISingleResult<usp_SelectBangdiemsByMaLopHocResult> SelectBangDiemByMaLop(int _MaLop)
        {
            return DB.usp_SelectBangdiemsByMaLopHoc(_MaLop);
        }

        //Lay bang diem theo MSSV
        public ISingleResult<usp_SelectBangdiemsByMSSVResult> SelectBangDiemByMSSV(String _MSSV)
        {
            return DB.usp_SelectBangdiemsByMSSV(_MSSV);
        }

        //Lay bang diem theo ma lop va mssv
        public ISingleResult<usp_SelectBangdiemsByMaLopHoc_MSSVResult> SelectBangDiemByMaLop_MSSV(int _MaLop, String _MSSV)
        {
            return DB.usp_SelectBangdiemsByMaLopHoc_MSSV(_MaLop, _MSSV);
        }

        //Insert bang diem moi
        public void Insert(int _MaBangDiem, int _MaLopHoc, String  _MSSV)
        {
            DB.usp_InsertBangdiem(_MaBangDiem, _MaLopHoc, _MSSV);
        }

        //Cap nhat bang diem
        public void Update(int _MaBangDiem, int _MaLopHoc, String _MSSV)
        {
            DB.usp_UpdateBangdiem(_MaBangDiem, _MaLopHoc, _MSSV);
        }

        //Xoa sv
        public void Delete(int _MaBangDiem)
        {
            DB.usp_DeleteBangdiem(_MaBangDiem);
        }
    }
}
