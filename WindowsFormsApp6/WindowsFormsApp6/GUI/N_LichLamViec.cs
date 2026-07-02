using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT.GUI
{
    public partial class N_LichLamViec : Form
    {
        public N_LichLamViec()
        {
            InitializeComponent();
            DuLieuMau();
            MauDGV(dgvLichLamViec);
        }
        private void DuLieuMau(){
            txtHoTenBS.Text = "Nguyễn Văn A";
            txtMaBS.Text = "BS001";
            dtpNgayLamViec.Value = DateTime.Now;
            nudGioBatDau.Value = 8;
            nudGioKetThuc.Value = 17;
            nudSoBenhNhanToiDa.Value = 20;
            // 1. Khởi tạo DataTable mới
            DataTable dtLich = new DataTable();

            // 2. Định nghĩa các cột cho bảng lịch làm việc
            dtLich.Columns.Add("MaLich", typeof(string));
            dtLich.Columns.Add("TenBacSi", typeof(string));
            dtLich.Columns.Add("NgayLamViec", typeof(string)); // Bạn có thể đổi thành typeof(DateTime) nếu cần
            dtLich.Columns.Add("CaLamViec", typeof(string));
            dtLich.Columns.Add("TrangThai", typeof(string));

            // 3. Thêm các dòng dữ liệu mẫu
            dtLich.Rows.Add("LLV001", "BS. Nguyễn Văn A", "04/06/2026", "Sáng (07:30 - 11:30)", "Đã xác nhận");
            dtLich.Rows.Add("LLV002", "BS. Trần Thị B", "04/06/2026", "Chiều (13:30 - 17:30)", "Đã xác nhận");
            dtLich.Rows.Add("LLV003", "BS. Lê Hoàng C", "05/06/2026", "Tối (18:00 - 21:00)", "Chờ duyệt");
            dtLich.Rows.Add("LLV004", "BS. Nguyễn Văn A", "05/06/2026", "Chiều (13:30 - 17:30)", "Đã hủy");

            // 4. Gán DataTable vào DataGridView dgvLichLamViec
            dgvLichLamViec.DataSource = dtLich;

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
        private void FrmLichLamViec_Load(object sender, EventArgs e)
        {

        }
    }
}
