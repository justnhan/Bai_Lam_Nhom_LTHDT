using Bai_Lam_Nhom_LTHDT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public interface ILichTrucDAL
    {
        // validate
        bool existMaLich(string maLT);

        bool ExistsDoctorSchedule(string maBS,DateTime ngayTruc,TimeSpan gioBatDau,TimeSpan gioKetThuc);

        bool ExistsRoomSchedule(string maPhong, DateTime ngayTruc, TimeSpan gioBatDau, TimeSpan gioKetThuc);

        List<LichTruc> GetByMaBS(string maBS);
        List <LichTruc> GetAllLichTruc();
        LichTruc GetByMaLT(string maLT);
        bool Add(LichTruc lichTruc);
        bool Update(LichTruc lichTruc);
        bool DeleteByMaLT(string maLT);
        string GetError();
    }
}
