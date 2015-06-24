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
    class BLL_Khoa
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca khoa
        public List<KHOA> SelectAll()
        {
            return DB.KHOAs.ToList();
        }

        //Lay khoa theo ma khoa
        public ISingleResult<usp_SelectKhoaResult> Select(String _MaKhoa)
        {
            return DB.usp_SelectKhoa(_MaKhoa);
        }

        //Insert khoa moi
        public void Insert(String _MaKhoa, String _TenKhoa)
        {
            DB.usp_InsertKhoa(_MaKhoa, _TenKhoa);
        }

        //Cap nhat khoa
        public void Update(String _MaKhoa, String _TenKhoa)
        {
            DB.usp_UpdateKhoa(_MaKhoa, _TenKhoa);
        }

        //Xoa khoa
        public void Delete(String _MaKhoa)
        {
            DB.usp_DeleteKhoa(_MaKhoa);
        }
    }
}
