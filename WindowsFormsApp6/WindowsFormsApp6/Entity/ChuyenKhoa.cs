using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_Lam_Nhom_LTHDT.Entity
{
    public class ChuyenKhoa
    {
        public string MaChuyenKhoa { get; set; }
        public string TenChuyenKhoa { get; set; }
        public string SDT { get; set; }
        public ChuyenKhoa() {
        }
        public ChuyenKhoa(string maChuyenKhoa, string tenChuyenKhoa, string SDT)
        {
            this.MaChuyenKhoa = maChuyenKhoa;
            this.TenChuyenKhoa = tenChuyenKhoa;
            this.SDT = SDT;
        }
    }
}
