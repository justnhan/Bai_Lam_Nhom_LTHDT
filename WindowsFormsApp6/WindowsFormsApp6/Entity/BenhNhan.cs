using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT
{
    public class BenhNhan
    {
        public string MaBenhNhan { get; set; }
        public string TenBenhNhan { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }


        public BenhNhan() { }
        public BenhNhan(string maBenhNhan, string tenBenhNhan, string diaChi, string soDienThoai, string gioiTinh, DateTime ngaySinh)
        {
            MaBenhNhan = maBenhNhan;
            TenBenhNhan = tenBenhNhan;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
        }
    }
}
