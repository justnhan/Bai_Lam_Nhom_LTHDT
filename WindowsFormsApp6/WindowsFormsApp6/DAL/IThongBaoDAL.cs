using System.Collections.Generic;
using Bai_Lam_Nhom_LTHDT;

namespace Bai_Lam_Nhom_LTHDT.DAL
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