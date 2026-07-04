using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai_Lam_Nhom_LTHDT.Entity;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class ThongKeBacSiDAL
    {
        private LichHenDAL lichHenDAL = new LichHenDAL();
        private KhungGioDAL khungGioDAL = new KhungGioDAL();
        private LichTrucDAL lichTrucDAL = new LichTrucDAL();
        private BacSiDAL bacSiDAL = new BacSiDAL();

        public List<ThongKeBacSi> GetThongKeBacSi()
        {
            List<ThongKeBacSi> list = new List<ThongKeBacSi>();

            List<LichHen> dsHen = lichHenDAL.GetAllLichHen();
            List<KhungGio> dsGio = khungGioDAL.GetAllKhungGio();
            List<LichTruc> dsLich = lichTrucDAL.GetAllLichTruc();
            List<BacSi> dsBS = bacSiDAL.GetAllBacSi();

            foreach (BacSi bs in dsBS)
            {
                ThongKeBacSi tk = new ThongKeBacSi();

                tk.MaBS = bs.MaBS;
                tk.TenBacSi = bs.HoTen;
                tk.ChuyenKhoa = bs.MaChuyenKhoa;

                tk.SoLichHen = 0;
                tk.DaKham = 0;
                tk.Huy = 0;

                foreach (LichHen lh in dsHen)
                {
                    KhungGio kg = dsGio.FirstOrDefault(x => x.MaGio == lh.MaGio);

                    if (kg == null)
                        continue;

                    LichTruc lt = dsLich.FirstOrDefault(x => x.MaLich == kg.MaLich);

                    if (lt == null)
                        continue;

                    if (lt.MaBS == bs.MaBS)
                    {
                        tk.SoLichHen++;

                        if (lh.TrangThai == "Da kham")
                            tk.DaKham++;

                        if (lh.TrangThai == "Da huy")
                            tk.Huy++;
                    }
                }

                list.Add(tk);
            }

            return list;
        }
        public List<ThongKeBacSi> GetThongKeBacSiTheoThang(int thang)
        {
            List<ThongKeBacSi> list = GetThongKeBacSi();

            List<LichHen> dsHen = lichHenDAL.GetAllLichHen()
                                            .Where(x => x.NgayDat.Month == thang)
                                            .ToList();

            foreach (ThongKeBacSi item in list)
            {
                item.SoLichHen = 0;
                item.DaKham = 0;
                item.Huy = 0;

                foreach (LichHen lh in dsHen)
                {
                    KhungGio kg = khungGioDAL.GetAllKhungGio()
                                            .FirstOrDefault(x => x.MaGio == lh.MaGio);

                    if (kg == null) continue;

                    LichTruc lt = lichTrucDAL.GetAllLichTruc()
                                             .FirstOrDefault(x => x.MaLich == kg.MaLich);

                    if (lt == null) continue;

                    if (lt.MaBS == item.MaBS)
                    {
                        item.SoLichHen++;

                        if (lh.TrangThai == "Da kham")
                            item.DaKham++;

                        if (lh.TrangThai == "Da huy")
                            item.Huy++;
                    }
                }
            }

            return list;
        }
    }
}