using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

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

        public List<LichHen> SearchByMaChuyenKhoa(string maChuyenKhoa)
        {
            error = "";
            List<LichHen> list = new List<LichHen>();

            try
            {
                con.Open();

                string sql = @"
        SELECT LH.*
        FROM LICHHEN LH
        JOIN KHUNGGIO KG ON LH.MAGIO = KG.MAGIO
        JOIN LICHTRUC LT ON KG.MALICH = LT.MALICH
        JOIN BACSI BS ON LT.MABS = BS.MABS
        WHERE BS.MACHUYENKHOA = @MaChuyenKhoa
        ORDER BY LH.MAHEN";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaChuyenKhoa", maChuyenKhoa);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new LichHen(
                                reader["MAHEN"].ToString(),
                                reader["MABN"].ToString(),
                                reader["MAGIO"].ToString(),
                                Convert.ToDateTime(reader["NGAYDAT"]),
                                reader["TRANGTHAI"].ToString(),
                                reader["LYDOKHAM"].ToString(),
                                reader["GHICHU"].ToString()
                            ));
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

            return list;
        }
        public List<LichHen> SearchByMaBacSi(string maBacSi)
        {
            error = "";
            List<LichHen> list = new List<LichHen>();

            try
            {
                con.Open();

                string sql = @"
        SELECT LH.*
        FROM LICHHEN LH
        JOIN KHUNGGIO KG ON LH.MAGIO = KG.MAGIO
        JOIN LICHTRUC LT ON KG.MALICH = LT.MALICH
        WHERE LT.MABS = @MaBacSi
        ORDER BY LH.MAHEN";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBacSi", maBacSi);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new LichHen(
                                reader["MAHEN"].ToString(),
                                reader["MABN"].ToString(),
                                reader["MAGIO"].ToString(),
                                Convert.ToDateTime(reader["NGAYDAT"]),
                                reader["TRANGTHAI"].ToString(),
                                reader["LYDOKHAM"].ToString(),
                                reader["GHICHU"].ToString()
                            ));
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





        public string GetError()
        {
            return error;
        }
    }
}