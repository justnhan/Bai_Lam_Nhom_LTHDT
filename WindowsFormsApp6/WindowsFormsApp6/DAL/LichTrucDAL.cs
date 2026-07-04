using Bai_Lam_Nhom_LTHDT.DAL;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bai_Lam_Nhom_LTHDT;


namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class LichTrucDAL : ILichTrucDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";

        public LichTrucDAL()
        {
            con = Database.GetConnection();
        }
        public bool existMaLich (string maLT)
        {
            error = "";
            try
            {
                con.Open ();
                string sql = "SELECT COUNT(*) FROM LichTruc WHERE MaLich = @maLT";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maLT", maLT);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                con.Close ();
            }
        }
        public bool ExistsDoctorSchedule(string maBS, DateTime ngayTruc, TimeSpan gioBatDau, TimeSpan gioKetThuc)
        {
            error = "";
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM LichTruc WHERE MaBS = @maBS AND NgayTruc = @ngayTruc AND ((GioBatDau < @gioKetThuc) AND (GioKetThuc > @gioBatDau))";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maBS", maBS);
                    cmd.Parameters.AddWithValue("@ngayTruc", ngayTruc);
                    cmd.Parameters.AddWithValue("@gioBatDau", gioBatDau);
                    cmd.Parameters.AddWithValue("@gioKetThuc", gioKetThuc);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
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

        public bool ExistsRoomSchedule(string maPhong, DateTime ngayTruc, TimeSpan gioBatDau, TimeSpan gioKetThuc)
        {
            error = "";
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM LichTruc WHERE MaPhong = @maPhong AND NgayTruc = @ngayTruc AND ((GioBatDau < @gioKetThuc) AND (GioKetThuc > @gioBatDau))";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maPhong", maPhong);
                    cmd.Parameters.AddWithValue("@ngayTruc", ngayTruc);
                    cmd.Parameters.AddWithValue("@gioBatDau", gioBatDau);
                    cmd.Parameters.AddWithValue("@gioKetThuc", gioKetThuc);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
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
        public List <LichTruc> GetAllLichTruc()
        {
            error = "";
            List <LichTruc> list = new List<LichTruc>();
            try
            {
                con.Open();
                string sql = "SELECT * FROM LichTruc order by NgayTruc";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LichTruc lichTruc = new LichTruc
                            {
                                MaLich = reader["MaLich"].ToString(),
                                MaBS = reader["MaBS"].ToString(),
                                MaPhong = reader["MaPhong"].ToString(),
                                NgayTruc = Convert.ToDateTime(reader["NgayTruc"]),
                                GioBatDau = TimeSpan.Parse(reader["GioBatDau"].ToString()),
                                GioKetThuc = TimeSpan.Parse(reader["GioKetThuc"].ToString()),
                                SoLuongToiDa = Convert.ToInt32(reader["SoLuongToiDa"])
                            };
                            list.Add(lichTruc);
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
        public List<LichTruc> GetByMaBS(string maBS)
        {
            error = "";

            List<LichTruc> list = new List<LichTruc>();

            try
            {
                con.Open();

                string sql = @"SELECT *
                       FROM LichTruc
                       WHERE MaBS=@MaBS
                       ORDER BY NgayTruc,GioBatDau";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBS", maBS);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LichTruc lt = new LichTruc
                            {
                                MaLich = reader["MaLich"].ToString(),
                                MaBS = reader["MaBS"].ToString(),
                                MaPhong = reader["MaPhong"].ToString(),
                                NgayTruc = Convert.ToDateTime(reader["NgayTruc"]),
                                GioBatDau = TimeSpan.Parse(reader["GioBatDau"].ToString()),
                                GioKetThuc = TimeSpan.Parse(reader["GioKetThuc"].ToString()),
                                SoLuongToiDa = Convert.ToInt32(reader["SoLuongToiDa"])
                            };

                            list.Add(lt);
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
        public LichTruc GetByMaLT(string maLT)
        {
            LichTruc lichTruc = null;
            error = "";
            try
            {
                con.Open();
                string sql = "SELECT * FROM LichTruc WHERE MaLich = @maLT";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maLT", maLT);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lichTruc = new LichTruc
                            {
                                MaLich = reader["MaLich"].ToString(),
                                MaBS = reader["MaBS"].ToString(),
                                MaPhong = reader["MaPhong"].ToString(),
                                NgayTruc = Convert.ToDateTime(reader["NgayTruc"]),
                                GioBatDau = TimeSpan.Parse(reader["GioBatDau"].ToString()),
                                GioKetThuc = TimeSpan.Parse(reader["GioKetThuc"].ToString()),
                                SoLuongToiDa = Convert.ToInt32(reader["SoLuongToiDa"])
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

            return lichTruc;
        }
        public bool Add(LichTruc lichTruc)
        {
            error = "";
            try
            {
                con.Open();
                string sql = "INSERT INTO LichTruc (MaLich, MaBS, MaPhong, NgayTruc, GioBatDau, GioKetThuc, SoLuongToiDa) VALUES (@maLich, @maBS, @maPhong, @ngayTruc, @gioBatDau, @gioKetThuc, @soLuongToiDa)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maLich", lichTruc.MaLich);
                    cmd.Parameters.AddWithValue("@maBS", lichTruc.MaBS);
                    cmd.Parameters.AddWithValue("@maPhong", lichTruc.MaPhong);
                    cmd.Parameters.AddWithValue("@ngayTruc", lichTruc.NgayTruc);
                    cmd.Parameters.AddWithValue("@gioBatDau", lichTruc.GioBatDau);
                    cmd.Parameters.AddWithValue("@gioKetThuc", lichTruc.GioKetThuc);
                    cmd.Parameters.AddWithValue("@soLuongToiDa", lichTruc.SoLuongToiDa);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
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
        public bool Update(LichTruc lichTruc)
        {
            error = "";
            try
            {
                con.Open();
                string sql = "UPDATE LichTruc SET MaBS = @maBS, MaPhong = @maPhong, NgayTruc = @ngayTruc, GioBatDau = @gioBatDau, GioKetThuc = @gioKetThuc, SoLuongToiDa = @soLuongToiDa WHERE MaLich = @maLich";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maLich", lichTruc.MaLich);
                    cmd.Parameters.AddWithValue("@maBS", lichTruc.MaBS);
                    cmd.Parameters.AddWithValue("@maPhong", lichTruc.MaPhong);
                    cmd.Parameters.AddWithValue("@ngayTruc", lichTruc.NgayTruc);
                    cmd.Parameters.AddWithValue("@gioBatDau", lichTruc.GioBatDau);
                    cmd.Parameters.AddWithValue("@gioKetThuc", lichTruc.GioKetThuc);
                    cmd.Parameters.AddWithValue("@soLuongToiDa", lichTruc.SoLuongToiDa);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
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
        
        public bool DeleteByMaLT(string maLT)
        {
            error = "";
            try
            {
                con.Open();
                string sql = "DELETE FROM LichTruc WHERE MaLich = @maLich";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@maLich", maLT);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
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
