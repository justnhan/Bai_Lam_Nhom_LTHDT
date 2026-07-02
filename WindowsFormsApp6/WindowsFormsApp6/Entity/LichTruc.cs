using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT
{
    public class LichTruc
    {
        public string MaLich { get; set; }
        public string MaBS { get; set; }
        public string MaPhong { get; set; }
        public DateTime NgayTruc { get; set; }
        public string GioBatDau { get; set; }
        public string GioKetThuc { get; set; }
        public int SoLuongToiDa { get; set; }
        
        public LichTruc() { }

        public LichTruc(string maLich, string maBS, string maPhong, DateTime ngayTruc, string gioBatDau, string gioKetThuc, int soLuongToiDa)
        {
            MaLich = maLich;
            MaBS = maBS;
            MaPhong = maPhong;
            NgayTruc = ngayTruc;
            GioBatDau = gioBatDau;
            GioKetThuc = gioKetThuc;
            SoLuongToiDa = soLuongToiDa;
        }
    }

}