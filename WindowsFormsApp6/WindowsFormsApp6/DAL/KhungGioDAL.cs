using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class KhungGioDAL : IKhungGioDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";

        public KhungGioDAL()
        {
            con = Database.GetConnection();
        }



        public bool ExistsMaGio(string maGio)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM KhungGio WHERE MaGio=@MaGio";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaGio", maGio);

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




        public List<KhungGio> GetAllKhungGio()
        {
            error = "";

            List<KhungGio> list = new List<KhungGio>();

            try
            {
                con.Open();

                string sql = "SELECT * FROM KhungGio ORDER BY MaGio";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KhungGio kg = new KhungGio(
                            reader["MaGio"].ToString(),
                            reader["MaLich"].ToString(),
                            reader["GioBatDau"].ToString(),
                            reader["GioKetThuc"].ToString(),
                            reader["TrangThai"].ToString()
                        );

                        list.Add(kg);
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




        public KhungGio GetByMaGio(string maGio)
        {
            error = "";

            KhungGio kg = null;

            try
            {
                con.Open();

                string sql = "SELECT * FROM KhungGio WHERE MaGio=@MaGio";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaGio", maGio);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kg = new KhungGio(
                                reader["MaGio"].ToString(),
                                reader["MaLich"].ToString(),
                                reader["GioBatDau"].ToString(),
                                reader["GioKetThuc"].ToString(),
                                reader["TrangThai"].ToString()
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

            return kg;
        }





        public bool Add(KhungGio kg)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"INSERT INTO KhungGio
                       (MaGio, MaLich, GioBatDau, GioKetThuc, TrangThai)
                       VALUES
                       (@MaGio, @MaLich, @GioBatDau, @GioKetThuc, @TrangThai)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaGio", kg.MaGio);
                    cmd.Parameters.AddWithValue("@MaLich", kg.MaLich);
                    cmd.Parameters.AddWithValue("@GioBatDau", kg.GioBatDau);
                    cmd.Parameters.AddWithValue("@GioKetThuc", kg.GioKetThuc);
                    cmd.Parameters.AddWithValue("@TrangThai", kg.TrangThai);

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





        public bool Update(KhungGio kg)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"UPDATE KhungGio
                       SET MaLich=@MaLich,
                           GioBatDau=@GioBatDau,
                           GioKetThuc=@GioKetThuc,
                           TrangThai=@TrangThai
                       WHERE MaGio=@MaGio";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaGio", kg.MaGio);
                    cmd.Parameters.AddWithValue("@MaLich", kg.MaLich);
                    cmd.Parameters.AddWithValue("@GioBatDau", kg.GioBatDau);
                    cmd.Parameters.AddWithValue("@GioKetThuc", kg.GioKetThuc);
                    cmd.Parameters.AddWithValue("@TrangThai", kg.TrangThai);

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





        public bool DeleteByMaGio(string maGio)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "DELETE FROM KhungGio WHERE MaGio=@MaGio";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaGio", maGio);

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