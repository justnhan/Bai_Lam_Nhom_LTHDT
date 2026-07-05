using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;
using Bai_Lam_Nhom_LTHDT;

namespace Bai_Lam_Nhom_LTHDT.DAL
{
    public class PhongKhamDAL : IPhongKhamDAL
    {
        private readonly SQLiteConnection con;
        private string error = "";

        public PhongKhamDAL()
        {
            con = Database.GetConnection();
        }

        // ===========================
        // VALIDATE
        // ===========================

        public bool ExistsMaPhong(string maPhong)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT COUNT(*) FROM PHONGKHAM WHERE MAPHONG=@MAPHONG";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", maPhong);

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

                string sql = "SELECT COUNT(*) FROM PHONGKHAM WHERE MACHUYENKHOA=@MACHUYENKHOA";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MACHUYENKHOA", maChuyenKhoa);

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

        public string MaPhongGenerator()
        {
            error = "";
            string nextMaPhong = "PK001"; // Gán mặc định phòng đầu tiên ở đây

            try
            {
                con.Open();
                string sql = "SELECT MAX(MAPHONG) FROM PHONGKHAM";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    object result = cmd.ExecuteScalar();
                    // SQLite trả về null hoặc DBNull nếu bảng trống
                    if (result != null && result != DBNull.Value && !string.IsNullOrEmpty(result.ToString()))
                    {
                        string maxMaPhong = result.ToString();
                        // Cắt chuỗi từ vị trí thứ 2 đến hết
                        int nextNumber = int.Parse(maxMaPhong.Substring(2)) + 1;

                        // Trả về định dạng PK001, PK010, PK100...
                        nextMaPhong = "PK" + nextNumber.ToString("D3");
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null; // Trả về null nếu lỗi để tầng giao diện biết và xử lý
            }
            finally
            {
                con.Close();
            }

            return nextMaPhong;
        }
        // ===========================
        // CRUD
        // ===========================

        public List<PhongKham> GetAllPhongKham()
        {
            error = "";

            List<PhongKham> list = new List<PhongKham>();

            try
            {
                con.Open();

                string sql = "SELECT * FROM PHONGKHAM ORDER BY MAPHONG";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PhongKham pk = new PhongKham(
                            reader["MAPHONG"].ToString(),
                            reader["TENPHONG"].ToString(),
                            reader["TRANGTHAI"].ToString(),
                            reader["GHICHU"].ToString(),
                            reader["MACHUYENKHOA"].ToString()
                        );

                        list.Add(pk);
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
        public PhongKham GetByMaPhong(string maPhong)
        {
            PhongKham pk = null;
            error = "";

            try
            {
                con.Open();

                string sql = "SELECT * FROM PHONGKHAM WHERE MAPHONG = @MAPHONG";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", maPhong);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pk = new PhongKham(
                                reader["MAPHONG"].ToString(),
                                reader["TENPHONG"].ToString(),
                                reader["TRANGTHAI"].ToString(),
                                reader["GHICHU"].ToString(),
                                reader["MACHUYENKHOA"].ToString()
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

            return pk;
        }

        public List<PhongKham> GetByMaChuyenKhoa(string maChuyenKhoa)
        {
            List<PhongKham> list = new List<PhongKham>();
            error = "";
            try
            {
                con.Open();
                string sql = "SELECT * FROM PHONGKHAM WHERE MACHUYENKHOA = @MACHUYENKHOA";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MACHUYENKHOA", maChuyenKhoa);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhongKham pk = new PhongKham(
                                reader["MAPHONG"].ToString(),
                                reader["TENPHONG"].ToString(),
                                reader["TRANGTHAI"].ToString(),
                                reader["GHICHU"].ToString(),
                                reader["MACHUYENKHOA"].ToString()
                            );
                            list.Add(pk);
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

        public List <PhongKham> SearchByTenPhong(string tenPhong)
        {
            List<PhongKham> list = new List<PhongKham>();
            error = "";
            try
            {
                con.Open();
                string sql = "SELECT * FROM PHONGKHAM WHERE TENPHONG LIKE @TENPHONG";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TENPHONG", "%" + tenPhong + "%");
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PhongKham pk = new PhongKham(
                                reader["MAPHONG"].ToString(),
                                reader["TENPHONG"].ToString(),
                                reader["TRANGTHAI"].ToString(),
                                reader["GHICHU"].ToString(),
                                reader["MACHUYENKHOA"].ToString()
                            );
                            list.Add(pk);
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
        public bool Add(PhongKham phongKham)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"INSERT INTO PHONGKHAM
                            (MAPHONG, TENPHONG, TRANGTHAI, GHICHU, MACHUYENKHOA)
                            VALUES
                            (@MAPHONG, @TENPHONG, @TRANGTHAI, @GHICHU, @MACHUYENKHOA)";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", phongKham.MaPhong);
                    cmd.Parameters.AddWithValue("@TENPHONG", phongKham.TenPhong);
                    cmd.Parameters.AddWithValue("@TRANGTHAI", phongKham.TrangThai);
                    cmd.Parameters.AddWithValue("@GHICHU", phongKham.GhiChu);
                    cmd.Parameters.AddWithValue("@MACHUYENKHOA", phongKham.MaChuyenKhoa);

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


        public bool Update(PhongKham phongKham)
        {
            error = "";

            try
            {
                con.Open();

                string sql = @"UPDATE PHONGKHAM
                            SET TENPHONG = @TENPHONG,
                                TRANGTHAI = @TRANGTHAI,
                                GHICHU = @GHICHU,
                                MACHUYENKHOA = @MACHUYENKHOA
                            WHERE MAPHONG = @MAPHONG";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@TENPHONG", phongKham.TenPhong);
                    cmd.Parameters.AddWithValue("@TRANGTHAI", phongKham.TrangThai);
                    cmd.Parameters.AddWithValue("@GHICHU", phongKham.GhiChu);
                    cmd.Parameters.AddWithValue("@MACHUYENKHOA", phongKham.MaChuyenKhoa);
                    cmd.Parameters.AddWithValue("@MAPHONG", phongKham.MaPhong);

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
        public bool DeleteByMaPhong(string maPhong)
        {
            error = "";

            try
            {
                con.Open();

                string sql = "DELETE FROM PHONGKHAM WHERE MAPHONG = @MAPHONG";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", maPhong);

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