using Bai_Lam_Nhom_LTHDT;
using System.Collections.Generic;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public interface IPhongKhamDAL
    {
        List<PhongKham> GetAllPhongKham();

        PhongKham GetByMaPhong(string maPhong);

        bool Add(PhongKham phongKham);

        bool Update(PhongKham phongKham);

        bool DeleteByMaPhong(string maPhong);

        string GetError();
    }
}