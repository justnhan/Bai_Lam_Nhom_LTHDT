using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT
{
    public class PhongKham
    {
        public string MaPhongKham { get; set; }
        public string TenPhongKham { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string MaChuyenKhoa { get; set; }    
        
        public PhongKham() { }
        public PhongKham(string maPhongKham, string tenPhongKham, string trangThai, string ghiChu, string maChuyenKhoa)
        {
            MaPhongKham = maPhongKham;
            TenPhongKham = tenPhongKham;
            TrangThai = trangThai;
            GhiChu = ghiChu;
            MaChuyenKhoa = maChuyenKhoa;
        }
    }
}
