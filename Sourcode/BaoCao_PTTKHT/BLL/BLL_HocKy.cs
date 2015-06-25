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
    class BLL_HocKy
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca hoc ky
        public List<HOCKY> SelectAll()
        {
            return DB.HOCKies.ToList();
        }

        //Lay hoc ky theo ma hoc ky
        public ISingleResult<usp_SelectHockyResult> Select(int? _MaHocKy)
        {
            return DB.usp_SelectHocky(_MaHocKy);
        }

        //Lay hoc ky theo ma nam hoc
        public ISingleResult<usp_SelectHockiesByMaNamHocResult> SelectHocKyByMaNamHoc(int _MaNamHoc)
        {
            return DB.usp_SelectHockiesByMaNamHoc(_MaNamHoc);
        }

        //Insert hoc ky moi
        public void Insert(int _MaHocKy, String _TenHocKy, int _MaNamHoc)
        {
            DB.usp_InsertHocky(_MaHocKy, _MaNamHoc,_TenHocKy);
        }

        //Cap nhat hoc ky
        public void Update(int _MaHocKy, String _TenHocKy, int _MaNamHoc)
        {
            DB.usp_UpdateHocky(_MaHocKy, _MaNamHoc, _TenHocKy);
        }

        //Xoa hoc ky
        public void Delete(int _MaHocKy)
        {
            DB.usp_DeleteHocky(_MaHocKy);
        }
    }
}
