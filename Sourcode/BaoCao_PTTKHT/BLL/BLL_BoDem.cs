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
    class BLL_BoDem
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca bo dem
        public List<BODEM> SelectAll()
        {
            return DB.BODEMs.ToList();
        }

        //Lay so dem cua bo dem
        public int SelectSoDem(String _TenBang)
        {
            return (int)DB.usp_SelectBodem(_TenBang).First().SoDem;
        }
    }
}
