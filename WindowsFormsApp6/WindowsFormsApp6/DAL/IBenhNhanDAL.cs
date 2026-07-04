using Bai_Lam_Nhom_LTHDT;
using Bai_Lam_Nhom_LTHDT.Entity;
using System.Collections.Generic;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public interface    IBenhNhanDAL
    {
        List<BenhNhan> GetAllBenhNhan();

        BenhNhan GetByMaBN(string maBN);

        bool Add(BenhNhan benhNhan);

        bool Update(BenhNhan benhNhan);

        bool DeleteByMaBN(string maBN);

        string GetError();
    }
}