using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT
{
    public class BenhNhan
    {
        public string MaBN { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }



        public BenhNhan() { }
        public BenhNhan(string maBN, string hoTen, string gioiTinh, DateTime ngaySinh, string sdt, string diaChi, string email)
        {
            MaBN = maBN;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Sdt = sdt;
            DiaChi = diaChi;
            Email = email;
        }

    }
}
