using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using Bai_Lam_Nhom_LTHDT;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class ThongBaoDAL : IThongBaoDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";

        public ThongBaoDAL()
        {
            con = Database.GetConnection();
        }

        public bool ExistsMaTB(string maTB)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM THONGBAO WHERE MATB=@MATB";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MATB", maTB);

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

        public List<ThongBao> GetAllThongBao()
        {
            error = "";

            List<ThongBao> list = new List<ThongBao>();

            try
            {
                con.Open();

                string sql = "SELECT * FROM THONGBAO ORDER BY MATB";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ThongBao tb = new ThongBao(
                            reader["MATB"].ToString(),
                            reader["TIEUDE"].ToString(),
                            reader["NOIDUNG"].ToString(),
                            reader["NGAYTAO"].ToString(),
                            reader["NGUOITAO"].ToString()
                        );

                        list.Add(tb);
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

        public ThongBao GetByMaTB(string maTB)
        {
            ThongBao tb = null;
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT * FROM THONGBAO WHERE MATB=@MATB";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MATB", maTB);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tb = new ThongBao(
                                reader["MATB"].ToString(),
                                reader["TIEUDE"].ToString(),
                                reader["NOIDUNG"].ToString(),
                                reader["NGAYTAO"].ToString(),
                                reader["NGUOITAO"].ToString()
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

            return tb;
        }

        public bool Add(ThongBao thongBao)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"INSERT INTO THONGBAO
                            (MATB,TIEUDE,NOIDUNG,NGAYTAO,NGUOITAO)
                            VALUES
                            (@MATB,@TIEUDE,@NOIDUNG,@NGAYTAO,@NGUOITAO)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MATB", thongBao.MATB);
                    cmd.Parameters.AddWithValue("@TIEUDE", thongBao.TIEUDE);
                    cmd.Parameters.AddWithValue("@NOIDUNG", thongBao.NOIDUNG);
                    cmd.Parameters.AddWithValue("@NGAYTAO", thongBao.NGAYTAO);
                    cmd.Parameters.AddWithValue("@NGUOITAO", thongBao.NGUOITAO);

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

        public bool Update(ThongBao thongBao)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"UPDATE THONGBAO
                               SET TIEUDE=@TIEUDE,
                                   NOIDUNG=@NOIDUNG,
                                   NGAYTAO=@NGAYTAO,
                                   NGUOITAO=@NGUOITAO
                               WHERE MATB=@MATB";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TIEUDE", thongBao.TIEUDE);
                    cmd.Parameters.AddWithValue("@NOIDUNG", thongBao.NOIDUNG);
                    cmd.Parameters.AddWithValue("@NGAYTAO", thongBao.NGAYTAO);
                    cmd.Parameters.AddWithValue("@NGUOITAO", thongBao.NGUOITAO);
                    cmd.Parameters.AddWithValue("@MATB", thongBao.MATB);

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

        public bool DeleteByMaTB(string maTB)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "DELETE FROM THONGBAO WHERE MATB=@MATB";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MATB", maTB);

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