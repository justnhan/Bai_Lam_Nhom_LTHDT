using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai_Lam_Nhom_LTHDT.Entity;
using System.Data.SQLite;
using _Bai_Lam_Nhom_LTHDT.DAL;

namespace WindowsFormsApp6.DAL
{
    internal class ChuyenKhoaDAL : IChuyenKhoaDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";
        public ChuyenKhoaDAL() {
            con = Database.GetConnection();
        }

        public bool ExistsMaCK(string maCK)
        {
            error = "";
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM ChuyenKhoa WHERE MaCK = @maCK";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maCK", maCK);
                    return Convert.ToInt32(cmd.ExecuteScalar())>0;
                    
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
        public List<ChuyenKhoa> GetAllChuyenKhoa()
        {
            error = "";
            List <ChuyenKhoa> list = new List<ChuyenKhoa>();
            try
            {
                con.Open();
                string sql = "SELECT * FROM ChuyenKhoa order by MaChuyenKhoa";

                using (SQLiteCommand cmd = new SQLiteCommand(sql,con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChuyenKhoa chuyenKhoa = new ChuyenKhoa
                        {
                            MaChuyenKhoa = reader["MaChuyenKhoa"].ToString(),
                            TenChuyenKhoa = reader["TenChuyenKhoa"].ToString(),
                            MoTa = reader["MoTa"].ToString()
                        };
                        list.Add(chuyenKhoa);
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

        public ChuyenKhoa GetByMaCK(string maCK)
        {
            ChuyenKhoa ck = null;
            error = "";
            try
            {
                con.Open();
                string sql = "SELECT * FROM ChuyenKhoa WHERE MaCK = @maCK";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maCK", maCK);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ck = new ChuyenKhoa
                            {
                                MaChuyenKhoa = reader["MaChuyenKhoa"].ToString(),
                                TenChuyenKhoa = reader["TenChuyenKhoa"].ToString(),
                                MoTa = reader["MoTa"].ToString()
                            };
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
            return ck;
        }

        public bool Add(ChuyenKhoa chuyenKhoa)
        {
            error = "";
            try
            {
                con.Open();

                string sql = "INSERT INTO ChuyenKhoa (MaChuyenKhoa, TenChuyenKhoa, MoTa) VALUES (@maCK, @tenCK, @moTa)";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maCK", chuyenKhoa.MaChuyenKhoa);
                    cmd.Parameters.AddWithValue("@tenCK", chuyenKhoa.TenChuyenKhoa);
                    cmd.Parameters.AddWithValue("@moTa", chuyenKhoa.MoTa);
                    
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

        public bool Update(ChuyenKhoa chuyenKhoa)
        {
            error = "";
            try
            {
                con.Open();

                string  sql = "update ChuyenKhoa set TenChuyenKhoa = @tenCK, MoTa = @moTa where MaChuyenKhoa = @maCK";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maCK", chuyenKhoa.MaChuyenKhoa);
                    cmd.Parameters.AddWithValue("@tenCK", chuyenKhoa.TenChuyenKhoa);
                    cmd.Parameters.AddWithValue("@moTa", chuyenKhoa.MoTa);

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

        public bool DeleteByMaCK(string maCK)
        {
            error = "";
            try
            {
                con.Open();

                string sql = "DELETE FROM ChuyenKhoa WHERE MaChuyenKhoa = @maCK";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maCK", maCK);
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
