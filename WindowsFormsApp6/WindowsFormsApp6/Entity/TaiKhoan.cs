using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Entity
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string MaQuyen { get; set; }
        public string TrangThai { get; set; }
        public TaiKhoan() { }

        public TaiKhoan(string tenDangNhap, string matKhau, string maQuyen, string trangThai)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            MaQuyen = maQuyen;
            TrangThai = trangThai;
        }
    }

    public class TaiKhoanBS : TaiKhoan
    {
        public string MaBS { get; set; }

        public TaiKhoanBS() { }
        public TaiKhoanBS(string tenDangNhap, string matKhau, string maQuyen, string trangThai, string maBS)
            : base(tenDangNhap, matKhau, maQuyen, trangThai)
        {
            MaBS = maBS;
        }
    }
}
