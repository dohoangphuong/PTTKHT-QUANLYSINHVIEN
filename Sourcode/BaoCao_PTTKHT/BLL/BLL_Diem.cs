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
    class BLL_Diem
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca diem
        public List<DIEM> SelectAll()
        {
            return DB.DIEMs.ToList();
        }

        //Lay diem theo ma diem
        public ISingleResult<usp_SelectDiemResult> SelectByMaDiem(int _MaDiem)
        {
            return DB.usp_SelectDiem(_MaDiem);
        }

        //Lay diem theo ma bang diem
        public ISingleResult<usp_SelectDiemsByMaBangDiemResult> SelectByMaBangDiem(int _MaBangDiem)
        {
            return DB.usp_SelectDiemsByMaBangDiem(_MaBangDiem);
        }

        //Insert diem
        public void Insert(int _MaDiem, double _SoDiem, int _HeSo, int _MaBangDiem)
        {
            DB.usp_InsertDiem(_MaDiem, _SoDiem, _HeSo, _MaBangDiem);
        }

        //Cap nhat diem
        public void Update(int _MaDiem, double _SoDiem, int _HeSo, int _MaBangDiem)
        {
            DB.usp_UpdateDiem(_MaDiem, _SoDiem, _HeSo, _MaBangDiem);
        }

        //Xoa diem
        public void Delete(int _MaDiem)
        {
            DB.usp_DeleteDiem(_MaDiem);
        }
    }
}
