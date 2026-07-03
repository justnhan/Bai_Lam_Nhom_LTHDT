using Bai_Lam_Nhom_LTHDT.Entity;
using System.Collections.Generic;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public interface ILichHenDAL
    {
        List<LichHen> GetAllLichHen();

        LichHen GetByMaHen(string maHen);

        bool Add(LichHen lichHen);

        bool Update(LichHen lichHen);

        bool DeleteByMaHen(string maHen);

        string GetError();
    }
}