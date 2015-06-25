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
    class BLL_BangDiem
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca bang diem
        public List<BANGDIEM> SelectAll()
        {
            return DB.BANGDIEMs.ToList();
        }

        //Lay bang diem theo ma bang diem
        public ISingleResult<usp_SelectBangdiemResult> Select(int _MaBangDiem)
        {
            return DB.usp_SelectBangdiem(_MaBangDiem);
        }

        //Insert bang diem moi
        public void Insert(int _MaBangDiem, int _MaLopHoc)
        {
            DB.usp_InsertBangdiem(_MaBangDiem, _MaLopHoc);
        }

        //Cap nhat bang diem
        public void Update(int _MaBangDiem, int _MaLopHoc)
        {
            DB.usp_UpdateBangdiem(_MaBangDiem, _MaLopHoc);
        }

        //Xoa sv
        public void Delete(int _MaBangDiem)
        {
            DB.usp_DeleteBangdiem(_MaBangDiem);
        }
    }
}
