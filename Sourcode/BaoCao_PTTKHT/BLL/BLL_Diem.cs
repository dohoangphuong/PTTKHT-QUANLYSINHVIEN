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

        //Insert diem
        public void Insert(int _MaDiem, int _MaBangDiem, double _SoDiem, int _HeSo)
        {
            DB.usp_InsertDiem(_MaDiem, _MaBangDiem, _SoDiem, _HeSo);
        }

        //Cap nhat diem
        public void Update(int _MaDiem, int _MaBangDiem, double _SoDiem, int _HeSo)
        {
            DB.usp_UpdateDiem(_MaDiem, _MaBangDiem, _SoDiem, _HeSo);
        }

        //Xoa diem
        public void Delete(int _MaDiem)
        {
            DB.usp_DeleteDiem(_MaDiem);
        }
    }
}
