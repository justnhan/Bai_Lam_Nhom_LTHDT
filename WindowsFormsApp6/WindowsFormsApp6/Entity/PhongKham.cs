using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT
{
    public class PhongKham
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string MaChuyenKhoa { get; set; }    
        
        public PhongKham() { }
        public PhongKham(string maPhong, string tenPhong, string trangThai, string ghiChu, string maChuyenKhoa)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            TrangThai = trangThai;
            GhiChu = ghiChu;
            MaChuyenKhoa = maChuyenKhoa;
        }
    }
}
