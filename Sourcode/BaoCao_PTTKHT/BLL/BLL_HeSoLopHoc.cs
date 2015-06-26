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
    class BLL_HeSoLopHoc
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat he so lop hoc
        public List<HESOLOPHOC> SelectAll()
        {
            return DB.HESOLOPHOCs.ToList();
        }

        //Lay he so theo ma he so
        public ISingleResult<usp_SelectHesolophocResult> Select(int? _MaHeSo)
        {
            return DB.usp_SelectHesolophoc(_MaHeSo);
        }

        //Lay he so theo ma lop
        public ISingleResult<usp_SelectHesolophocsByMaLopHocResult> SelectHeSoLopHocByMaLopHoc(int _MaLopHoc)
        {
            return DB.usp_SelectHesolophocsByMaLopHoc(_MaLopHoc);
        }

        //Insert he so lop hoc
        public void Insert(int _MaHeSo, int _MaLopHoc, int _HeSo, String _LoaiDiem)
        {
            DB.usp_InsertHesolophoc(_MaHeSo, _MaLopHoc, _HeSo, _LoaiDiem);
        }

        //Cap nhat he so lop hoc
        public void Update(int _MaHeSo, int _MaLopHoc, int _HeSo, String _LoaiDiem)
        {
            DB.usp_UpdateHesolophoc(_MaHeSo, _MaLopHoc, _HeSo, _LoaiDiem);
        }

        //Xoa diem
        public void Delete(int _MaHeSo)
        {
            DB.usp_DeleteHesolophoc(_MaHeSo);
        }
    }
}
