
using Bai_Lam_Nhom_LTHDT.Entity;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class BacSiDAL : IBacSiDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";

        // lấy kết nối trước từ class Database rồi sau đó mới mở sử dụng ở các hàm dưới
        public BacSiDAL()
        {
            con = Database.GetConnection();
        }


        // Các hàm validate kiểm tra dữ liệu tránh lỗi database
        public bool ExistsMaBS(string maBS)
        {
            error = "";
            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM BacSi WHERE MaBS = @MaBS";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBS", maBS);

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

        public bool ExistsEmail(string email)
        {
            error = "";
            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM BacSi WHERE Email = @Email";

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
        public bool ExistsSdt(string sdt)
        {
            error = "";
            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM BacSi WHERE Sdt = @Sdt";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Sdt", sdt);

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

        public bool ExistsByMaChuyenKhoa(string maChuyenKhoa)
        {
            error = "";
            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM BacSi WHERE MaChuyenKhoa = @MaChuyenKhoa";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaChuyenKhoa", maChuyenKhoa);

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
        
        
        //CÁC HÀM CRUD CƠ BẢN.
        
        public List<BacSi> GetAllBacSi()
        {
            error = "";
            List<BacSi> list = new List<BacSi>();

            try
            {

                con.Open();

                string sql = "SELECT * FROM BacSi ORDER BY MaBS";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BacSi bs = new BacSi(
                            reader["MaBS"].ToString(),
                            reader["HoTen"].ToString(),
                            reader["GioiTinh"].ToString(),
                            reader["Sdt"].ToString(),
                            reader["Email"].ToString(),
                            reader["MaChuyenKhoa"].ToString(),
                            Convert.ToDateTime(reader["NgaySinh"])
                        );

                        list.Add(bs);
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

        
        public BacSi GetByMaBS(string maBS)
        {
            BacSi bs = null;
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT * FROM BacSi WHERE MaBS = @MaBS";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBS", maBS);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            bs = new BacSi(
                                reader["MaBS"].ToString(),
                                reader["HoTen"].ToString(),
                                reader["GioiTinh"].ToString(),
                                reader["Sdt"].ToString(),
                                reader["Email"].ToString(),
                                reader["MaChuyenKhoa"].ToString(),
                                Convert.ToDateTime(reader["NgaySinh"])
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

            return bs;
        }

        
        public bool Add(BacSi bacSi)
        {
            error = "";
            try
            {
                con.Open();

                string sql = @"INSERT INTO BacSi
                           (MaBS, HoTen, GioiTinh, Sdt, Email, MaChuyenKhoa, NgaySinh)
                           VALUES
                           (@MaBS, @HoTen, @GioiTinh, @Sdt, @Email, @MaChuyenKhoa, @NgaySinh)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBS", bacSi.MaBS);
                    cmd.Parameters.AddWithValue("@HoTen", bacSi.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", bacSi.GioiTinh);
                    cmd.Parameters.AddWithValue("@Sdt", bacSi.Sdt);
                    cmd.Parameters.AddWithValue("@Email", bacSi.Email);
                    cmd.Parameters.AddWithValue("@MaChuyenKhoa", bacSi.MaChuyenKhoa);
                    cmd.Parameters.AddWithValue("@NgaySinh", bacSi.NgaySinh);

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

        
        public bool Update(BacSi bacSi)
        {
            error = "";
            try
            {
                con.Open();

                string sql = @"UPDATE BacSi
                           SET HoTen = @HoTen,
                               GioiTinh = @GioiTinh,
                               Sdt = @Sdt,
                               Email = @Email,
                               MaChuyenKhoa = @MaChuyenKhoa,
                               NgaySinh = @NgaySinh
                           WHERE MaBS = @MaBS";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@HoTen", bacSi.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", bacSi.GioiTinh);
                    cmd.Parameters.AddWithValue("@Sdt", bacSi.Sdt);
                    cmd.Parameters.AddWithValue("@Email", bacSi.Email);
                    cmd.Parameters.AddWithValue("@MaChuyenKhoa", bacSi.MaChuyenKhoa);
                    cmd.Parameters.AddWithValue("@NgaySinh", bacSi.NgaySinh);
                    cmd.Parameters.AddWithValue("@MaBS", bacSi.MaBS);

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

        
        public bool DeleteByMaBS(string maBS)
        {
            error = "";
            try
            {
                con.Open();

                string sql = "DELETE FROM BacSi WHERE MaBS = @MaBS";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MaBS", maBS);

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
