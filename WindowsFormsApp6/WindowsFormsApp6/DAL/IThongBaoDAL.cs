using System.Collections.Generic;
using _Bai_Lam_Nhom_LTHDT;

namespace _Bai_Lam_Nhom_LTHDT.DAL
{
    public interface IThongBaoDAL
    {
        List<ThongBao> GetAllThongBao();

        ThongBao GetByMaTB(string maTB);

        bool Add(ThongBao thongBao);

        bool Update(ThongBao thongBao);

        bool DeleteByMaTB(string maTB);

        string GetError();
    }
}