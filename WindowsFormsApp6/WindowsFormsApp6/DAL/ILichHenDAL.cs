using Bai_Lam_Nhom_LTHDT.Entity;
using System.Collections.Generic;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public interface ILichHenDAL
    {
        bool ExistsMaHen(string maHen);
        List<LichHen> GetAllLichHen();
        List<LichHen> SearchByMaChuyenKhoa(string maChuyenKhoa);
        List<LichHen> SearchByMaBacSi(string maBacSi);

        LichHen GetByMaHen(string maHen);
        string GetHoTenBSByMaHen(string maHen);

        bool Add(LichHen lichHen);

        bool Update(LichHen lichHen);

        bool DeleteByMaHen(string maHen);

        string GetError();
        List<ThongTinLichHen> GetDanhSachThongKe();
        Dictionary<string, int> GetThongKeTheoThu();
        List<CanhBao> GetDanhSachCanhBao();
        int GetTongQuaGio();
        int GetTongCanhBaoKhan();
        int TongCanhBao();
        Dictionary<string, int> GetThongKeTrangThai();
    }
}