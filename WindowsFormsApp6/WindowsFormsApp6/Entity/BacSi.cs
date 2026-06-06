using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Lam_Nhom_LTHDT.Entity
{
    public class BacSi
    {
        public string MaBS { get; set; }
        public string HoTenBS { get; set; }
        public string GioiTinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string MaChuyenKhoa { get; set; }

        public BacSi() {
        }

        public BacSi(string maBS, string hoTenBS, string gioiTinh, string sdt, string email, string maChuyenKhoa)
        {
            MaBS = maBS;
            HoTenBS = hoTenBS;
            GioiTinh = gioiTinh;
            Sdt = sdt;
            Email = email;
            MaChuyenKhoa = maChuyenKhoa;    
        }
    }
}
