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
    class BLL_LienKetTaiKhoan
    {
        DAL.QLDTDataContext DB = new DAL.QLDTDataContext(Settings.Default.ConnectString);

        //Lay tat ca lien ket tai khoan
        public List<LIENKETTK> SelectAll()
        {
            return DB.LIENKETTKs.ToList();
        }

        //Lay lien ket tk theo ma lien ket
        public ISingleResult<usp_SelectLienKetTKResult> Select(int _MaLK)
        {
            return DB.usp_SelectLienKetTK(_MaLK);
        }

        //Lay lien ket tk theo ten tai khoan
        public ISingleResult<usp_SelectLienKetTKsByTenTaiKhoanResult> SelectLienKetTKByTenTaiKhoan(String _TenTaiKhoan)
        {
            return DB.usp_SelectLienKetTKsByTenTaiKhoan(_TenTaiKhoan);
        }

        //Insert lien ket tk moi
        public void Insert(int _MaLK, String _TenTaiKhoan, String _MSSV, String _MaGV)
        {
            DB.usp_InsertLienKetTK(_MaLK, _TenTaiKhoan, _MSSV, _MaGV);
        }

        //Cap nhat lien ket tk
        public void Update(int _MaLK, String _TenTaiKhoan, String _MSSV, String _MaGV)
        {
            DB.usp_UpdateLienKetTK(_MaLK, _TenTaiKhoan, _MSSV, _MaGV);
        }

        //Xoa lien ket tk
        public void Delete(int _MaLK)
        {
            DB.usp_DeleteLienKetTK(_MaLK);
        }

        //Xoa lien ket tk bang ten tai khoan
        public void DeleteByTenTaiKhaon(String _TenTaiKhoan)
        {
            DB.usp_DeleteLienKetTKsByTenTaiKhoan(_TenTaiKhoan);
        }
    }
}
