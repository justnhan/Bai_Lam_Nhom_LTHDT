using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class LichHenDAL : ILichHenDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";

        public LichHenDAL()
        {
            con = Database.GetConnection();
        }

        public bool ExistsMaHen(string maHen)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM LichHen WHERE MaHen=@MaHen";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaHen", maHen);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }



        public List<LichHen> GetAllLichHen()
        {
            error = "";

            List<LichHen> list = new List<LichHen>();

            try
            {
                con.Open();

                string sql = "SELECT * FROM LichHen ORDER BY MaHen";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        LichHen lh = new LichHen(
                            reader["MaHen"].ToString(),
                            reader["MaBN"].ToString(),
                            reader["MaGio"].ToString(),
                            Convert.ToDateTime(reader["NgayDat"]),
                            reader["TrangThai"].ToString(),
                            reader["LyDoKham"].ToString(),
                            reader["GhiChu"].ToString()
                        );

                        list.Add(lh);
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return list;
        }




        public LichHen GetByMaHen(string maHen)
        {
            error = "";

            LichHen lh = null;

            try
            {
                con.Open();

                string sql = "SELECT * FROM LichHen WHERE MaHen=@MaHen";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaHen", maHen);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lh = new LichHen(
                                reader["MaHen"].ToString(),
                                reader["MaBN"].ToString(),
                                reader["MaGio"].ToString(),
                                Convert.ToDateTime(reader["NgayDat"]),
                                reader["TrangThai"].ToString(),
                                reader["LyDoKham"].ToString(),
                                reader["GhiChu"].ToString()
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            finally
            {
                con.Close();
            }

            return lh;
        }






        public bool Add(LichHen lh)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"INSERT INTO LichHen
                       (MaHen, MaBN, MaGio, NgayDat, TrangThai, LyDoKham, GhiChu)
                       VALUES
                       (@MaHen, @MaBN, @MaGio, @NgayDat, @TrangThai, @LyDoKham, @GhiChu)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaHen", lh.MaHen);
                    cmd.Parameters.AddWithValue("@MaBN", lh.MaBN);
                    cmd.Parameters.AddWithValue("@MaGio", lh.MaGio);
                    cmd.Parameters.AddWithValue("@NgayDat", lh.NgayDat);
                    cmd.Parameters.AddWithValue("@TrangThai", lh.TrangThai);
                    cmd.Parameters.AddWithValue("@LyDoKham", lh.LyDoKham);
                    cmd.Parameters.AddWithValue("@GhiChu", lh.GhiChu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }





        public bool Update(LichHen lh)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"UPDATE LichHen
                       SET MaBN=@MaBN,
                           MaGio=@MaGio,
                           NgayDat=@NgayDat,
                           TrangThai=@TrangThai,
                           LyDoKham=@LyDoKham,
                           GhiChu=@GhiChu
                       WHERE MaHen=@MaHen";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaHen", lh.MaHen);
                    cmd.Parameters.AddWithValue("@MaBN", lh.MaBN);
                    cmd.Parameters.AddWithValue("@MaGio", lh.MaGio);
                    cmd.Parameters.AddWithValue("@NgayDat", lh.NgayDat);
                    cmd.Parameters.AddWithValue("@TrangThai", lh.TrangThai);
                    cmd.Parameters.AddWithValue("@LyDoKham", lh.LyDoKham);
                    cmd.Parameters.AddWithValue("@GhiChu", lh.GhiChu);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }




        public bool DeleteByMaHen(string maHen)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "DELETE FROM LichHen WHERE MaHen=@MaHen";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaHen", maHen);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public List<ThongTinLichHen> GetDanhSachThongKe()
        {
            List<ThongTinLichHen> list = new List<ThongTinLichHen>();

            // Lấy dữ liệu từ các bảng
            List<LichHen> dsHen = GetAllLichHen();

            BenhNhanDAL benhNhanDAL = new BenhNhanDAL();
            KhungGioDAL khungGioDAL = new KhungGioDAL();
            LichTrucDAL lichTrucDAL = new LichTrucDAL();
            BacSiDAL bacSiDAL = new BacSiDAL();

            List<BenhNhan> dsBN = benhNhanDAL.GetAllBenhNhan();
            List<KhungGio> dsGio = khungGioDAL.GetAllKhungGio();
            List<LichTruc> dsLich = lichTrucDAL.GetAllLichTruc();
            List<BacSi> dsBS = bacSiDAL.GetAllBacSi();

            foreach (LichHen lh in dsHen)
            {
                // Bệnh nhân
                BenhNhan bn = dsBN.FirstOrDefault(x => x.MaBN == lh.MaBN);

                // Khung giờ
                KhungGio kg = dsGio.FirstOrDefault(x => x.MaGio == lh.MaGio);

                // Lịch trực
                LichTruc lt = null;
                if (kg != null)
                {
                    lt = dsLich.FirstOrDefault(x => x.MaLich == kg.MaLich);
                }

                // Bác sĩ
                BacSi bs = null;
                if (lt != null)
                {
                    bs = dsBS.FirstOrDefault(x => x.MaBS == lt.MaBS);
                }

                list.Add(new ThongTinLichHen()
                {
                    MaHen = lh.MaHen,
                    MaBN = lh.MaBN,
                    TenBenhNhan = bn != null ? bn.HoTen : "",
                    GioHen = kg != null ? kg.GioBatDau + " - " + kg.GioKetThuc : "",
                    TenBacSi = bs != null ? bs.HoTen : "",
                    TrangThai = lh.TrangThai
                });
            }

            return list;
        }
        public Dictionary<string, int> GetThongKeTheoThu()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();

            List<LichHen> ds = GetAllLichHen();

            foreach (LichHen lh in ds)
            {
                string thu = "";

                switch (lh.NgayDat.DayOfWeek)
                {
                    case DayOfWeek.Monday: thu = "T2"; break;
                    case DayOfWeek.Tuesday: thu = "T3"; break;
                    case DayOfWeek.Wednesday: thu = "T4"; break;
                    case DayOfWeek.Thursday: thu = "T5"; break;
                    case DayOfWeek.Friday: thu = "T6"; break;
                    case DayOfWeek.Saturday: thu = "T7"; break;
                    case DayOfWeek.Sunday: thu = "CN"; break;
                }

                if (!data.ContainsKey(thu))
                    data.Add(thu, 0);

                data[thu]++;
            }

            return data;
        }
        public List<CanhBao> GetDanhSachCanhBao()
        {
            List<CanhBao> list = new List<CanhBao>();

            List<ThongTinLichHen> ds = GetDanhSachThongKe();

            int stt = 1;

            foreach (ThongTinLichHen item in ds)
            {
                if (item.TrangThai == "Cho kham")
                {
                    list.Add(new CanhBao()
                    {
                        STT = stt++,

                        LoaiCanhBao = "Lịch hẹn",

                        NoiDung = $"BN {item.TenBenhNhan} đang chờ khám với BS {item.TenBacSi}",

                        MucDo = "Cao",

                        ThoiGian = item.GioHen
                    });
                }
            }

            return list;
        }
        public int GetTongQuaGio()
        {
            return GetAllLichHen()
                .Count(x => x.TrangThai == "Qua gio");
        }
        public int GetTongCanhBaoKhan()
        {
            return GetAllLichHen()
                    .Count(x => x.TrangThai == "Cho kham");
        }
        public int TongCanhBao()
        {
            int dem = 0;

            foreach (LichHen lh in GetAllLichHen())
            {
                if (lh.TrangThai == "Cho kham")
                    dem++;
            }

            return dem;
        }
        public Dictionary<string, int> GetThongKeTrangThai()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();

            List<LichHen> ds = GetAllLichHen();

            foreach (LichHen lh in ds)
            {
                if (!data.ContainsKey(lh.TrangThai))
                    data[lh.TrangThai] = 0;

                data[lh.TrangThai]++;
            }

            return data;
        }


        public string GetError()
        {
            return error;
        }
    }
}