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
    class BLL_MonTienQuyet
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay mon tien quyet theo ma mon
        public ISingleResult<usp_SelectMontienquyetsByMaMonHocResult> SelectMonTienQuyetByMaMon(String _MaMon)
        {
            return DB.usp_SelectMontienquyetsByMaMonHoc(_MaMon);
        }

        //Insert mon hoc tien quyet
        public void Insert(int _MaMTQ, String _TenMon, String _TenMonTienQuyet)
        {
            DB.usp_InsertMontienquyet(_MaMTQ, _TenMon, _TenMonTienQuyet);
        }

        //Cap nhat mon tien quyet
        public void Update(int _MaMTQ, String _TenMon, String _TenMonTienQuyet)
        {
            DB.usp_UpdateMontienquyet(_MaMTQ, _TenMon, _TenMonTienQuyet);
        }

        //Xoa mon hoc
        public void Delete(String _MaMon)
        {
            DB.usp_DeleteMonhoc(_MaMon);
        }
    }
}
