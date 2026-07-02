using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Entity
{
    public class KhungGio
    {
        public string MaGio { get; set; }
        public string MaLich { get; set; }
        public string GioBatDau { get; set; }
        public string GioKetThuc { get; set; }
        public string TrangThai { get; set; }
        
        public KhungGio(string maGio, string maLich, string gioBatDau, string gioKetThuc, string trangThai)
        {
            MaGio = maGio;
            MaLich = maLich;
            GioBatDau = gioBatDau;
            GioKetThuc = gioKetThuc;
            TrangThai = trangThai;
        }
        public KhungGio() { }

    }
}
