using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT
{
    public class SlotInfo
    {
        public string STT { get; set; }
        public string Ngay { get; set; }
        public string GioBatDau { get; set; }
        public string GioKetThuc { get; set; }
        public string BacSi { get; set; }
        public string Phong { get; set; }
        public string TrangThai { get; set; }
        public string BenhNhan { get; set; }
    }

    public static class DuLieuSlot
    {
        public static List<SlotInfo> DanhSachSlot = new List<SlotInfo>();

        public static void TaoDuLieuMau()
        {
            if (DanhSachSlot.Count > 0)
                return;

            DanhSachSlot.Add(new SlotInfo { STT = "1", Ngay = "03/06/2026", GioBatDau = "08:00", GioKetThuc = "08:20", BacSi = "BS. Nguyễn Văn A", Phong = "Phòng 101", TrangThai = "Trống", BenhNhan = "-" });
            DanhSachSlot.Add(new SlotInfo { STT = "2", Ngay = "03/06/2026", GioBatDau = "08:20", GioKetThuc = "08:40", BacSi = "BS. Nguyễn Văn A", Phong = "Phòng 101", TrangThai = "Đã đặt", BenhNhan = "Nguyễn Thị B" });
            DanhSachSlot.Add(new SlotInfo { STT = "3", Ngay = "03/06/2026", GioBatDau = "08:40", GioKetThuc = "09:00", BacSi = "BS. Trần Thị B", Phong = "Phòng 102", TrangThai = "Đang khám", BenhNhan = "Trần Văn C" });
            DanhSachSlot.Add(new SlotInfo { STT = "4", Ngay = "03/06/2026", GioBatDau = "09:00", GioKetThuc = "09:20", BacSi = "BS. Lê Văn C", Phong = "Phòng 103", TrangThai = "Trống", BenhNhan = "-" });
            DanhSachSlot.Add(new SlotInfo { STT = "5", Ngay = "03/06/2026", GioBatDau = "09:20", GioKetThuc = "09:40", BacSi = "BS. Phạm Thị D", Phong = "Phòng 104", TrangThai = "Đã đặt", BenhNhan = "Lê Thị D" });
        }
    }
}