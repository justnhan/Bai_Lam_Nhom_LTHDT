using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT.Entity
{
    public class BaoCao
    {
        public int STT { get; set; }

        public string MaHoaDon { get; set; }

        public string BenhNhan { get; set; }

        public string BacSi { get; set; }

        public string DichVu { get; set; }

        public DateTime NgayKham { get; set; }

        public decimal ThanhTien { get; set; }
    }
}