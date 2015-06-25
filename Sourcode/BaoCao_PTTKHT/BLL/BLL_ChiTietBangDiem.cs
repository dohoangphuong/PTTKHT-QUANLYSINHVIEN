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
    class BLL_ChiTietBangDiem
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat chi tiet bang diem
        public List<CHITIETBANGDIEM> SelectAll()
        {
            return DB.CHITIETBANGDIEMs.ToList();
        }

        //Lay chi tiet bang diem theo ma bang diem
        public ISingleResult<usp_SelectChitietbangdiemsByMaBangDiemResult> SelectByMaBangDiem(int _MaBangDiem)
        {
            return DB.usp_SelectChitietbangdiemsByMaBangDiem(_MaBangDiem);
        }

        //Insert chi tiet bang diem moi
        public void Insert(int _MaCTBangDiem, int _MaBangDiem, int _MaDiem)
        {
            DB.usp_InsertChitietbangdiem(_MaCTBangDiem, _MaBangDiem, _MaDiem);
        }

        //Cap nhat chi tiet bang diem
        public void Update(int _MaCTBangDiem, int _MaBangDiem, int _MaDiem)
        {
            DB.usp_UpdateChitietbangdiem(_MaCTBangDiem, _MaBangDiem, _MaDiem);
        }

        //Xoa chi tiet bang diem
        public void Delete(int _MaCTBangDiem)
        {
            DB.usp_DeleteChitietbangdiem(_MaCTBangDiem);
        }
    }
}
