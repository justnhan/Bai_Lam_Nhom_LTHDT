using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public class thongbap
    {
        public string MATB { get; set; }
        public string TIEUDE { get; set; }
        public string NOIDUNG { get; set; }
        public string NGAYTAO { get; set; }
        public string NGUOITAO { get; set; }
        public thongbap()
        {
        }

        public thongbap(string matb, string tieude, string noidung, string ngaytao, string nguoitao)
        {
            this.MATB = matb;
            this.TIEUDE = tieude;
            this.NOIDUNG = noidung;
            this.NGAYTAO = ngaytao;
            this.NGUOITAO = nguoitao;
        }
    }


}
