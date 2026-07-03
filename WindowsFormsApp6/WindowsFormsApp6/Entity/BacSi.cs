using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Lam_Nhom_LTHDT.Entity
{
    public class BacSi
    {
        public string MaBS { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string MaChuyenKhoa { get; set; }

        public DateTime NgaySinh { get; set; }

        public BacSi() {
        }

        public BacSi(string maBS, string hoTen, string gioiTinh, string sdt, string email, string maChuyenKhoa, DateTime ngaySinh)
        {
            MaBS = maBS;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            Sdt = sdt;
            Email = email;
            MaChuyenKhoa = maChuyenKhoa;
            NgaySinh = ngaySinh;
        }
    }
}
