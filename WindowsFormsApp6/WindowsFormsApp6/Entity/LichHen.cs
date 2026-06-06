using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Lam_Nhom_LTHDT.Entity
{
    public class LichHen
    {
        public string MaHen { get; set; }
        public string MaBN { get; set; }
        public string MaGio { get; set; }
        public DateTime NgayDat { get; set; }
        public string TrangThai { get; set; }
        public string LyDoKham { get; set; }
        public string GhiChu { get; set; }  

        public LichHen() {
        }

        public LichHen(string maHen, string maBN, string maGio, DateTime ngayDat, string trangThai, string lyDoKham, string ghiChu)
        {
            MaHen = maHen;
            MaBN = maBN;
            MaGio = maGio;
            NgayDat = ngayDat;
            TrangThai = trangThai;
            LyDoKham = lyDoKham;
            GhiChu = ghiChu;
        }
    }
}
