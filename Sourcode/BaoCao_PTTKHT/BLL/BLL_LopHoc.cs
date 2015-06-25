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
    class BLL_LopHoc
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca lop hoc
        public List<LOPHOC> SelectAll()
        {
            return DB.LOPHOCs.ToList();
        }

        //Lay lop hoc theo ma lop
        public ISingleResult<usp_SelectLophocResult> SelectByMaLopHoc(int? _MaLopHoc)
        {
            return DB.usp_SelectLophoc(_MaLopHoc);
        }

        //Lay lop hoc theo hoc ky
        public ISingleResult<usp_SelectLophocsByMaHocKyResult> SelectByMaHocKy(int _MaHocKy)
        {
            return DB.usp_SelectLophocsByMaHocKy(_MaHocKy);
        }

        //Insert lop hoc moi
        public void Insert(int _MaLopHoc, String _TenLopHoc, String _Tiet, String _Thu, String _MaMonHoc, int _MaHocKy)
        {
            DB.usp_InsertLophoc(_MaLopHoc, _TenLopHoc, _Tiet, _Thu, _MaMonHoc, _MaHocKy);
        }

        //Cap nhat lop hoc
        public void Update(int _MaLopHoc, String _TenLopHoc, String _Tiet, String _Thu, String _MaMonHoc, int _MaHocKy)
        {
            DB.usp_UpdateLophoc(_MaLopHoc, _TenLopHoc, _Tiet, _Thu, _MaMonHoc, _MaHocKy);
        }

        //Xoa lop hoc
        public void Delete(int _MaLopHoc)
        {
            DB.usp_DeleteLophoc(_MaLopHoc);
        }
    }
}
