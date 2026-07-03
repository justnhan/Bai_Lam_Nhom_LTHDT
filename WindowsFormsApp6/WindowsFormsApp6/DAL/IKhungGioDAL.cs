using Bai_Lam_Nhom_LTHDT.Entity;
using System.Collections.Generic;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public interface IKhungGioDAL
    {
        List<KhungGio> GetAllKhungGio();

        KhungGio GetByMaGio(string maGio);

        bool Add(KhungGio khungGio);

        bool Update(KhungGio khungGio);

        bool DeleteByMaGio(string maGio);

        string GetError();
    }
}