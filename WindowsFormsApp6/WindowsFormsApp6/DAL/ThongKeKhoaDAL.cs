using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai_Lam_Nhom_LTHDT.Entity;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class ThongKeKhoaDAL
    {
        private ChuyenKhoaDAL chuyenKhoaDAL = new ChuyenKhoaDAL();
        private BacSiDAL bacSiDAL = new BacSiDAL();
        private LichHenDAL lichHenDAL = new LichHenDAL();
        private KhungGioDAL khungGioDAL = new KhungGioDAL();
        private LichTrucDAL lichTrucDAL = new LichTrucDAL();

        public List<ThongKeKhoa> GetThongKeKhoa()
        {
            List<ThongKeKhoa> list = new List<ThongKeKhoa>();

            List<ChuyenKhoa> dsKhoa = chuyenKhoaDAL.GetAllChuyenKhoa();
            List<BacSi> dsBS = bacSiDAL.GetAllBacSi();
            List<LichHen> dsHen = lichHenDAL.GetAllLichHen();
            List<KhungGio> dsGio = khungGioDAL.GetAllKhungGio();
            List<LichTruc> dsLich = lichTrucDAL.GetAllLichTruc();

            foreach (ChuyenKhoa ck in dsKhoa)
            {
                ThongKeKhoa tk = new ThongKeKhoa();

                tk.MaKhoa = ck.MaChuyenKhoa;
                tk.TenKhoa = ck.TenChuyenKhoa;

                tk.SoBacSi = dsBS.Count(x => x.MaChuyenKhoa == ck.MaChuyenKhoa);

                tk.SoBenhNhan = 0;

                tk.DoanhThu = 0;

                foreach (LichHen lh in dsHen)
                {
                    KhungGio kg = dsGio.FirstOrDefault(x => x.MaGio == lh.MaGio);

                    if (kg == null) continue;

                    LichTruc lt = dsLich.FirstOrDefault(x => x.MaLich == kg.MaLich);

                    if (lt == null) continue;

                    BacSi bs = dsBS.FirstOrDefault(x => x.MaBS == lt.MaBS);

                    if (bs == null) continue;

                    if (bs.MaChuyenKhoa == ck.MaChuyenKhoa)
                    {
                        tk.SoBenhNhan++;

                        // Mỗi lượt khám giả sử 300.000
                        tk.DoanhThu += 300000;
                    }
                }

                list.Add(tk);
            }

            return list;
        }
        public int TongNoiTongQuat()
        {
            return bacSiDAL.GetAllBacSi()
                .Count(x => x.MaChuyenKhoa == "CK001");
        }

        public int TongNhiKhoa()
        {
            return bacSiDAL.GetAllBacSi()
                .Count(x => x.MaChuyenKhoa == "CK002");
        }

        public int TongTimMach()
        {
            return bacSiDAL.GetAllBacSi()
                .Count(x => x.MaChuyenKhoa == "CK003");
        }

        public int TongKhoa()
        {
            return chuyenKhoaDAL.GetAllChuyenKhoa().Count;
        }
    }
}