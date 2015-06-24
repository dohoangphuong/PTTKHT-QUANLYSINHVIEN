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
    class BLL_MonHoc
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca nam hoc
        public List<MONHOC> SelectAll()
        {
            return DB.MONHOCs.ToList();
        }

        //Lay nam hoc the ma mon
        public ISingleResult<usp_SelectMonhocResult> Select(String _MaMon)
        {
            return DB.usp_SelectMonhoc(_MaMon);
        }

        //Insert mon hoc moi
        public void Insert(String _MaMon, String _TenMon, int  _SoTinChi)
        {
            DB.usp_InsertMonhoc(_MaMon, _TenMon, _SoTinChi);
        }

        //Cap nhat mon hoc
        public void Update(String _MaMon, String _TenMon, int _SoTinChi)
        {
            DB.usp_UpdateMonhoc(_MaMon, _TenMon, _SoTinChi);
        }

        //Xoa mon hoc
        public void Delete(String _MaMon)
        {
            DB.usp_DeleteMonhoc(_MaMon);
        }

        
    }
}
