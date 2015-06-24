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
    class BLL_Lop
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca lop
        public List<LOP> SelectAll()
        {
            return DB.LOPs.ToList();
        }

        //Lay lop theo ma lop
        public ISingleResult<usp_SelectLopResult> Select(String _MaLop)
        {
            return DB.usp_SelectLop(_MaLop);
        }

        //Lay lop theo nam hoc
        public ISingleResult<usp_SelectLopsByMaNamHocResult> SelectLopByMaNamHoc(int _MaNam)
        {
            try
            {
                return DB.usp_SelectLopsByMaNamHoc(_MaNam);
            }
            catch
            {
                return null;
            }
        }

        //Lay lop theo ma khoa
        public ISingleResult<usp_SelectLopsByMaKhoaResult> SelectLopByMaKhoa(String _MaKhoa)
        {
            return DB.usp_SelectLopsByMaKhoa(_MaKhoa);
        }

        //Insert lop moi
        public void Insert(String _MaLop, String _TenLop, String _MaKhoa, int _MaNamHoc)
        {
            DB.usp_InsertLop(_MaLop, _TenLop, _MaKhoa, _MaNamHoc);
        }

        //Cap nhat lop
        public void Update(String _MaLop, String _TenLop, String _MaKhoa, int _MaNamHoc)
        {
            DB.usp_UpdateLop(_MaLop, _TenLop, _MaKhoa, _MaNamHoc);
        }

        //Xoa lop hoc
        public void Delete(String _MaLop)
        {
            DB.usp_DeleteLop(_MaLop);
        }
    }
}
