using Bai_Lam_Nhom_LTHDT.Entity;
using Bai_Lam_Nhom_LTHDT;
using System.Collections.Generic;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public interface ITaiKhoanDAL
    {
        List<TaiKhoan> GetAllTaiKhoan();

        TaiKhoan GetByTenDangNhap(string tenDangNhap);

        bool Add(TaiKhoan taiKhoan);

        bool Update(TaiKhoan taiKhoan);

        bool Delete(string tenDangNhap);

        string GetError();
    }
}