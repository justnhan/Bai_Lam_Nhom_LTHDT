using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class BaoCaoDAL
    {
        private LichHenDAL lichHenDAL = new LichHenDAL();
        private BenhNhanDAL benhNhanDAL = new BenhNhanDAL();
        private KhungGioDAL khungGioDAL = new KhungGioDAL();
        private LichTrucDAL lichTrucDAL = new LichTrucDAL();
        private BacSiDAL bacSiDAL = new BacSiDAL();
     
        public List<BaoCao> GetDanhSachBaoCao()
        {
            List<BaoCao> list = new List<BaoCao>();

            List<LichHen> dsHen = lichHenDAL.GetAllLichHen();
            List<BenhNhan> dsBN = benhNhanDAL.GetAllBenhNhan();
            List<KhungGio> dsGio = khungGioDAL.GetAllKhungGio();
            List<LichTruc> dsLich = lichTrucDAL.GetAllLichTruc();
            List<BacSi> dsBS = bacSiDAL.GetAllBacSi();

            int stt = 1;

            foreach (LichHen lh in dsHen)
            {
                BenhNhan bn = dsBN.FirstOrDefault(x => x.MaBN == lh.MaBN);
                KhungGio kg = dsGio.FirstOrDefault(x => x.MaGio == lh.MaGio);
                LichTruc lt = dsLich.FirstOrDefault(x => x.MaLich == kg.MaLich);
                BacSi bs = dsBS.FirstOrDefault(x => x.MaBS == lt.MaBS);

                list.Add(new BaoCao()
                {
                    STT = stt++,
                    MaHoaDon = "HD" + lh.MaHen.Substring(2),
                    BenhNhan = bn?.HoTen,
                    BacSi = bs?.HoTen,
                    DichVu = lh.LyDoKham,
                    NgayKham = lh.NgayDat,
                    ThanhTien = 300000
                });
            }

            return list;
        }
        public int TongLichHen()
        {
            return lichHenDAL.GetAllLichHen().Count;
        }
        public int TongBenhNhan()
        {
            return benhNhanDAL.GetAllBenhNhan().Count;
        }
        public decimal TongDoanhThu()
        {
            return GetDanhSachBaoCao().Sum(x => x.ThanhTien);
        }
        public Dictionary<string, decimal> DoanhThuTheoNgay()
        {
            Dictionary<string, decimal> data = new Dictionary<string, decimal>();

            foreach (BaoCao bc in GetDanhSachBaoCao())
            {
                string ngay = bc.NgayKham.ToString("dd/MM");

                if (!data.ContainsKey(ngay))
                    data.Add(ngay, 0);

                data[ngay] += bc.ThanhTien;
            }

            return data;
        }
        public List<BaoCao> GetBaoCaoTheoThangNam(int thang, int nam)
        {
            List<BaoCao> list = new List<BaoCao>();

            foreach (BaoCao item in GetDanhSachBaoCao())
            {

                if (item.NgayKham.Month == thang &&
                    item.NgayKham.Year == nam)
                {
                    list.Add(item);
                }
            }

            return list;
        }
        public Dictionary<string, decimal> DoanhThuTheoNgay(int thang, int nam)
        {
            Dictionary<string, decimal> data = new Dictionary<string, decimal>();

            var ds = GetBaoCaoTheoThangNam(thang, nam);

            foreach (BaoCao item in ds)
            {
                string ngay = item.NgayKham.ToString("dd/MM");

                if (!data.ContainsKey(ngay))
                    data.Add(ngay, 0);

                data[ngay] += item.ThanhTien;
            }

            return data;
        }
    }
}