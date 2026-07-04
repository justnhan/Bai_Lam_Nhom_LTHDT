using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Lam_Nhom_LTHDT.Entity
{
    public class CanhBao
    {
        public int STT { get; set; }

        // Ví dụ: Lịch hẹn
        public string LoaiCanhBao { get; set; }

        // Ví dụ: BN Nguyễn Văn A đang chờ khám với BS Lê Quang Huy
        public string NoiDung { get; set; }

        // Cao / Trung bình / Thấp
        public string MucDo { get; set; }

        // Giờ hẹn
        public string ThoiGian { get; set; }
    }
}