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
        public bool Add(BenhNhan bn)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"INSERT INTO BenhNhan
                       (MaBN,HoTen,GioiTinh,NgaySinh,SDT,DiaChi,Email)
                       VALUES
                       (@MaBN,@HoTen,@GioiTinh,@NgaySinh,@SDT,@DiaChi,@Email)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBN", bn.MaBN);
                    cmd.Parameters.AddWithValue("@HoTen", bn.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh);
                    cmd.Parameters.AddWithValue("@SDT", bn.Sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", bn.DiaChi);
                    cmd.Parameters.AddWithValue("@Email", bn.Email);

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


        public bool Update(BenhNhan bn)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"UPDATE BenhNhan
                       SET HoTen=@HoTen,
                           GioiTinh=@GioiTinh,
                           NgaySinh=@NgaySinh,
                           SDT=@SDT,
                           DiaChi=@DiaChi,
                           Email=@Email
                       WHERE MaBN=@MaBN";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBN", bn.MaBN);
                    cmd.Parameters.AddWithValue("@HoTen", bn.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", bn.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", bn.NgaySinh);
                    cmd.Parameters.AddWithValue("@SDT", bn.Sdt);
                    cmd.Parameters.AddWithValue("@DiaChi", bn.DiaChi);
                    cmd.Parameters.AddWithValue("@Email", bn.Email);

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


        public bool DeleteByMaBN(string maBN)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "DELETE FROM BenhNhan WHERE MaBN=@MaBN";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBN", maBN);

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
        public List<BenhNhan> TimKiem(string cot, string tuKhoa)
        {
            error = "";

            List<BenhNhan> list = new List<BenhNhan>();

            try
            {
                con.Open();

                string sql = $"SELECT * FROM BenhNhan WHERE {cot} LIKE @TuKhoa";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

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


        public string GetError()
        {
            return error;
        }
    }
}
