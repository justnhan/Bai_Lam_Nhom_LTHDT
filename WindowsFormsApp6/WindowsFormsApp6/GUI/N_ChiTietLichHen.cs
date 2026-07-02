using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT.GUI
{
    public partial class N_ChiTietLichHen : Form
    {
        public N_ChiTietLichHen()
        {
            InitializeComponent();
            DuLieuMau();
            MauDGV(dgvDanhSachBenhNhan);
        }
        private void DuLieuMau()
        {
            txtMaBS.Text = "BS001";
            txtHoTenBS.Text = "Nguyễn Văn A";
            cboChuyenKhoa.Items.AddRange(new string[] { "Nội", "Ngoại", "Sản", "Nhi" });
            cboChuyenKhoa.SelectedIndex = 0;
            dtpNgayLamViec.Value = DateTime.Now;
            // 1. Khởi tạo DataTable mới cho Bệnh Nhân
            DataTable dtBenhNhan = new DataTable();

            // 2. Định nghĩa các cột cho bảng bệnh nhân
            dtBenhNhan.Columns.Add("MaBN", typeof(string));
            dtBenhNhan.Columns.Add("HoTen", typeof(string));
            dtBenhNhan.Columns.Add("NgaySinh", typeof(string)); // Có thể dùng typeof(DateTime)
            dtBenhNhan.Columns.Add("GioiTinh", typeof(string));
            dtBenhNhan.Columns.Add("SoDienThoai", typeof(string));
            dtBenhNhan.Columns.Add("DiaChi", typeof(string));

            // 3. Thêm các dòng dữ liệu mẫu
            dtBenhNhan.Rows.Add("BN001", "Phạm Minh Hoàng", "12/05/1990", "Nam", "0905123456", "123 Lê Lợi, Đà Nẵng");
            dtBenhNhan.Rows.Add("BN002", "Nguyễn Thị Mai", "25/08/1995", "Nữ", "0914789321", "45 Nguyễn Huệ, Huế");
            dtBenhNhan.Rows.Add("BN003", "Trần Văn Hùng", "03/11/1988", "Nam", "0935112233", "78 Hùng Vương, TP.HCM");
            dtBenhNhan.Rows.Add("BN004", "Lê Thu Thảo", "19/02/2002", "Nữ", "0888445566", "12 Trần Hưng Đạo, Hà Nội");

            // 4. Gán DataTable vào DataGridView dgvDanhSachBenhNhan
            dgvDanhSachBenhNhan.DataSource = dtBenhNhan;

            // 5. Cấu hình giao diện chuẩn (Tràn bảng, Chọn nguyên dòng)
            dgvDanhSachBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachBenhNhan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSachBenhNhan.MultiSelect = false;

            // 6. Đổi tiêu đề cột sang tiếng Việt có dấu
            dgvDanhSachBenhNhan.Columns["MaBN"].HeaderText = "Mã BN";
            dgvDanhSachBenhNhan.Columns["HoTen"].HeaderText = "Họ và Tên";
            dgvDanhSachBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvDanhSachBenhNhan.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvDanhSachBenhNhan.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvDanhSachBenhNhan.Columns["DiaChi"].HeaderText = "Địa Chỉ";

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
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
