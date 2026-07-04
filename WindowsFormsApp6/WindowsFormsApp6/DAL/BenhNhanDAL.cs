using Bai_Lam_Nhom_LTHDT;
using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class BenhNhanDAL : IBenhNhanDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";

        public BenhNhanDAL()
        {
            con = Database.GetConnection();
        }

        // Kiểm tra mã bệnh nhân đã tồn tại
        public bool ExistsMaBN(string maBN)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM BenhNhan WHERE MaBN = @MaBN";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBN", maBN);
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

        // Kiểm tra số điện thoại đã tồn tại
        public bool ExistsSDT(string sdt)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM BenhNhan WHERE SDT = @SDT";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@SDT", sdt);
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

        // Kiểm tra Email đã tồn tại
        public bool ExistsEmail(string email)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM BenhNhan WHERE Email = @Email";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
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

        // Lấy danh sách toàn bộ bệnh nhân
        public List<BenhNhan> GetAllBenhNhan()
        {
            error = "";

            List<BenhNhan> list = new List<BenhNhan>();

            try
            {
                con.Open();

                string sql = "SELECT * FROM BenhNhan ORDER BY MaBN";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BenhNhan bn = new BenhNhan(
                                reader["MaBN"].ToString(),
                                reader["HoTen"].ToString(),
                                reader["GioiTinh"].ToString(),
                                Convert.ToDateTime(reader["NgaySinh"]),
                                reader["SDT"].ToString(),
                                reader["DiaChi"].ToString(),
                                reader["Email"].ToString());

                            list.Add(bn);
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

        // Tìm kiếm bệnh nhân theo mã bệnh nhân
        public BenhNhan GetByMaBN(string maBN)
        {
            error = "";

            BenhNhan bn = null;

            try
            {
                con.Open();

                string sql = "SELECT * FROM BenhNhan WHERE MaBN=@MaBN";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBN", maBN);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bn = new BenhNhan(
                                reader["MaBN"].ToString(),
                                reader["HoTen"].ToString(),
                                reader["GioiTinh"].ToString(),
                                Convert.ToDateTime(reader["NgaySinh"]),
                                reader["SDT"].ToString(),
                                reader["DiaChi"].ToString(),
                                reader["Email"].ToString());
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

            return bn;
        }

        // Tìm kiếm bệnh nhân theo số điện thoại (Nhánh tuyen)
        public BenhNhan GetBySDT(string sdt)
        {
            error = "";

            BenhNhan bn = null;

            try
            {
                con.Open();

                string sql = "SELECT * FROM BenhNhan WHERE SDT = @SDT";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@SDT", sdt);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bn = new BenhNhan(
                                reader["MaBN"].ToString(),
                                reader["HoTen"].ToString(),
                                reader["GioiTinh"].ToString(),
                                Convert.ToDateTime(reader["NgaySinh"]),
                                reader["SDT"].ToString(),
                                reader["DiaChi"].ToString(),
                                reader["Email"].ToString()
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

            return bn;
        }

        // Tìm kiếm bệnh nhân bằng từ khóa Mã hoặc SĐT (Nhánh tuyen)
        public BenhNhan Search(string keyword)
        {
            error = "";

            BenhNhan bn = null;

            try
            {
                con.Open();

                string sql = @"SELECT *
                               FROM BenhNhan
                               WHERE MaBN=@keyword
                                  OR SDT=@keyword";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@keyword", keyword);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bn = new BenhNhan(
                                reader["MaBN"].ToString(),
                                reader["HoTen"].ToString(),
                                reader["GioiTinh"].ToString(),
                                Convert.ToDateTime(reader["NgaySinh"]),
                                reader["SDT"].ToString(),
                                reader["DiaChi"].ToString(),
                                reader["Email"].ToString()
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

            return bn;
        }

        // Lấy họ tên bệnh nhân từ mã lịch hẹn (Nhánh main)
        public string GetHoTenByMaHen(string maHen)
        {
            error = "";
            string hoTen = null;

            try
            {
                con.Open();
                string sql = @"SELECT BN.HoTen
                               FROM BenhNhan BN
                               INNER JOIN LichHen LH ON BN.MaBN = LH.MaBN
                               WHERE LH.MaHen=@MaHen";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaHen", maHen);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hoTen = reader["HoTen"].ToString();
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

            return hoTen;
        }

        // Lấy số điện thoại bệnh nhân từ mã lịch hẹn (Nhánh main)
        public string GetSDTByMaHen(string maHen)
        {
            error = "";
            string sdt = null;

            try
            {
                con.Open();
                string sql = @"SELECT BN.SDT
                               FROM BenhNhan BN
                               INNER JOIN LichHen LH ON BN.MaBN = LH.MaBN
                               WHERE LH.MaHen=@MaHen";
