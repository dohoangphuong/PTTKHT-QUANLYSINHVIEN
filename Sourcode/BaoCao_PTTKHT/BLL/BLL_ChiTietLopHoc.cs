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
    class BLL_ChiTietLopHoc
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca chi tiet lop hoc
        public List<CHITIETLOPHOC> SelectAll()
        {
            return DB.CHITIETLOPHOCs.ToList();
        }

        //Lay chi tiet lop hoc theo ma lop
        public ISingleResult<usp_SelectChitietlophocsByMaLopHocResult> SelectChiTietLopHocByMaLop(int _MaLopHoc)
        {
            return DB.usp_SelectChitietlophocsByMaLopHoc(_MaLopHoc);
        }

        //Lay chi tiet lop hoc theo ma chi tiet lop
        public ISingleResult<usp_SelectChitietlophocResult> Select(int _MaCTLopHoc)
        {
            return DB.usp_SelectChitietlophoc(_MaCTLopHoc);
        }

        //Insert lop hoc moi
        public void Insert(int _MaCTLopHoc, int _MaLopHoc, String _MSSV)
        {
            DB.usp_InsertChitietlophoc(_MaCTLopHoc, _MaLopHoc, _MSSV);
        }

        //Cap nhat lo hoc
        public void Update(int _MaCTLopHoc, int _MaLopHoc, String _MSSV)
        {
            DB.usp_UpdateChitietlophoc(_MaCTLopHoc, _MaLopHoc, _MSSV);
        }

        //Xoa lop hoc
        public void Delete(int _MaCTLopHoc)
        {
            DB.usp_DeleteChitietlophoc(_MaCTLopHoc);
        }

        //Xoa lop hoc theo ma lop hoc
        public void DeleteByMaLopHoc(int _MaLopHoc)
        {
            DB.usp_DeleteChitietlophocsByMaLopHoc(_MaLopHoc);
        }
    }
}
