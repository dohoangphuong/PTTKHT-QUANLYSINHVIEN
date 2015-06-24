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
    class BLL_NamHoc
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca nam hoc
        public List<NAMHOC> SelectAll()
        {
            return DB.NAMHOCs.ToList();
        }

        //Lay nam hoc the ma nam
        public ISingleResult<usp_SelectNamhocResult> Select(int _MaNam)
        {
            return DB.usp_SelectNamhoc(_MaNam);
        }

        //Insert nam hoc moi
        public void Insert(int _MaNam, String _NamHoc)
        {
            DB.usp_InsertNamhoc(_MaNam, _NamHoc);
        }

        //Cap nhat nam hoc
        public void Update(int _MaNam, String _NamHoc)
        {
            DB.usp_UpdateNamhoc(_MaNam, _NamHoc);
        }

        //Xoa nam hoc
        public void Delete(int _MaNam)
        {
            DB.usp_DeleteNamhoc(_MaNam);
        }
    }
}
