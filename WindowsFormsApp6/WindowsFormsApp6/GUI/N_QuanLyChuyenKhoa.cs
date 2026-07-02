using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT.GUI
{
    public partial class N_QuanLyChuyenKhoa : Form
    {
        public N_QuanLyChuyenKhoa()
        {
            InitializeComponent();
            DuLieuMau();
            MauDGV(dgvBSThuocKhoa);
            MauDGV(dgvDanhSachChuyenKhoa);
            MauDGV(dgvDanhSachPhongKham);
        }

        private void DuLieuMau()
        {
            txtMaKhoa.Text = "CK01";
            txtTenKhoa.Text = "Chuyên khoa 1";
            txtSDT.Text = "0123456789";
            txtEmail.Text = "chuyenkhoa1@example.com";
            dtpNgayThanhLap.Value = new DateTime(2020, 1, 1);
            nudSoLuongBS.Value = 10;
            nudSoLuongPK.Value = 5;
            cboLoai.Items.AddRange(new string[] { "Mã", "Tên", "SDT", "Email"  });
            dgvBSThuocKhoa.DataSource = new List<BacSi>
            {
                new BacSi { MaBS = "BS01", HoTenBS = "Bác sĩ 1", Sdt = "0123456789", Email = "bacsi1@example.com" },
                new BacSi { MaBS = "BS02", HoTenBS = "Bác sĩ 2", Sdt = "0123456789", Email = "bacsi2@example.com" },
                new BacSi { MaBS = "BS03", HoTenBS = "Bác sĩ 3", Sdt = "0123456789", Email = "bacsi3@example.com" }
            };
            dgvDanhSachChuyenKhoa.DataSource = new List<ChuyenKhoa>
            {
                new ChuyenKhoa { MaChuyenKhoa = "CK01", TenChuyenKhoa = "Chuyên khoa 1", SDT = "0123456789" }
            };
            DataTable dt = new DataTable();

            // 2. Thêm các cột (DataColumn) cho DataTable
            dt.Columns.Add("MaPhongKham", typeof(string));
            dt.Columns.Add("TenPhongKham", typeof(string));
            dt.Columns.Add("ChuyenKhoa", typeof(string));
            dt.Columns.Add("TrangThai", typeof(string));

            // 3. Thêm các hàng (DataRow) dữ liệu mẫu
            dt.Rows.Add("PK001", "Phòng khám Đa khoa Quốc tế", "Đa khoa", "Hoạt động");
            dt.Rows.Add("PK002", "Phòng khám Nhi đồng", "Nhi khoa", "Hoạt động");
            dt.Rows.Add("PK003", "Phòng khám Răng Hàm Mặt", "Răng Hàm Mặt", "Bảo trì");

            // 4. Gán DataTable làm nguồn dữ liệu cho DataGridView
            dgvDanhSachPhongKham.DataSource = dt;

        }
        private void MauDGV(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            // Header
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(30, 136, 229); // #1E88E5

            dgv.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            // Dòng thường
            dgv.DefaultCellStyle.BackColor =
                Color.White;

            dgv.DefaultCellStyle.ForeColor =
                Color.FromArgb(33, 33, 33); // #212121

            // Dòng xen kẽ
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(248, 251, 255); // xanh rất nhạt

            // Dòng được chọn
            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(187, 222, 251); // #BBDEFB

            dgv.DefaultCellStyle.SelectionForeColor =
                Color.Black;

            // Màu lưới
            dgv.GridColor =
                Color.FromArgb(227, 242, 253); // #E3F2FD
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
