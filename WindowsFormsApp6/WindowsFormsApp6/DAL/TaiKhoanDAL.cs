using _Bai_Lam_Nhom_LTHDT.Entity;
using Bai_Lam_Nhom_LTHDT;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace _Bai_Lam_Nhom_LTHDT.DAL
{
    public class TaiKhoanDAL : ITaiKhoanDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";

        public TaiKhoanDAL()
        {
            con = Database.GetConnection();
        }

        // ===========================
        // VALIDATE
        // ===========================

        public bool ExistsTenDangNhap(string tenDangNhap)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENDANGNHAP=@TENDANGNHAP";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TENDANGNHAP", tenDangNhap);

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

        public void ktr()
        {
            con.Open();

            MessageBox.Show("Connected");

            con.Close();
        }

        // ===========================
        // CRUD
        // ===========================

        public List<TaiKhoan> GetAllTaiKhoan()
        {
            error = "";

            List<TaiKhoan> list = new List<TaiKhoan>();

            try
            {
                con.Open();

                string sql = "SELECT * FROM TAIKHOAN ORDER BY TENDANGNHAP";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaiKhoan tk = new TaiKhoan(
                            reader["TENDANGNHAP"].ToString(),
                            reader["MATKHAU"].ToString(),
                            reader["MAQUYEN"].ToString(),
                            reader["TRANGTHAI"].ToString()
                        );

                        list.Add(tk);
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
        public TaiKhoan GetByTenDangNhap(string tenDangNhap)
        {
            TaiKhoan tk = null;
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT * FROM TAIKHOAN WHERE TENDANGNHAP = @TENDANGNHAP";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TENDANGNHAP", tenDangNhap);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tk = new TaiKhoan(
                                reader["TENDANGNHAP"].ToString(),
                                reader["MATKHAU"].ToString(),
                                reader["MAQUYEN"].ToString(),
                                reader["TRANGTHAI"].ToString()
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

            return tk;
        }

        public bool Add(TaiKhoan taiKhoan)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"INSERT INTO TAIKHOAN
                               (TENDANGNHAP, MATKHAU, MAQUYEN, TRANGTHAI)
                               VALUES
                               (@TENDANGNHAP, @MATKHAU, @MAQUYEN, @TRANGTHAI)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TENDANGNHAP", taiKhoan.TenDangNhap);
                    cmd.Parameters.AddWithValue("@MATKHAU", taiKhoan.MatKhau);
                    cmd.Parameters.AddWithValue("@MAQUYEN", taiKhoan.MaQuyen);
                    cmd.Parameters.AddWithValue("@TRANGTHAI", taiKhoan.TrangThai);

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

        public bool Update(TaiKhoan taiKhoan)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"UPDATE TAIKHOAN
                               SET MATKHAU = @MATKHAU,
                                   MAQUYEN = @MAQUYEN,
                                   TRANGTHAI = @TRANGTHAI
                               WHERE TENDANGNHAP = @TENDANGNHAP";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MATKHAU", taiKhoan.MatKhau);
                    cmd.Parameters.AddWithValue("@MAQUYEN", taiKhoan.MaQuyen);
                    cmd.Parameters.AddWithValue("@TRANGTHAI", taiKhoan.TrangThai);
                    cmd.Parameters.AddWithValue("@TENDANGNHAP", taiKhoan.TenDangNhap);

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
        public bool Delete(string tenDangNhap)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "DELETE FROM TAIKHOAN WHERE TENDANGNHAP = @TENDANGNHAP";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TENDANGNHAP", tenDangNhap);

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