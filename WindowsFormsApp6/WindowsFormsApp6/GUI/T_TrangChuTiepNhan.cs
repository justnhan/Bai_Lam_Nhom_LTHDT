using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class T_TrangChuTiepNhan : Form
    {
        public T_TrangChuTiepNhan()
        {
            InitializeComponent();
            giuLieuMau();
            MauDGV(dgvLichHen);
        }
        private void giuLieuMau()
        {
            txtDiaChi.Text = "SONHA001";
            txtHoVaTen.Text = "Nguyen Van A";
            txtGhiChu.Text = "Đau đầu";
            txtSDT.Text = "0123456789";
            txtBacSi.Text = "Dr. Nguyen Van B";
            dtpNgayHen.Value = DateTime.Now;
            dtpNgaySinh.Value = new DateTime(1990, 1, 1);
            cboTrangThai.Items.Add("Đang chờ");
            cboTrangThai.Items.Add("Đã khám");
            cboTrangThai.Items.Add("Hủy");
            cboTrangThai.SelectedIndex = 0;
            nudGioHen.Value = 10;
            dgvLichHen.Rows.Add("08:00", "LH001", "Nguyễn Văn An", "0905123456", "BS. Trần Minh", "Đã xác nhận");
            dgvLichHen.Rows.Add("08:30", "LH002", "Lê Thị Hoa", "0912345678", "BS. Nguyễn Hải", "Chờ khám");
            dgvLichHen.Rows.Add("09:00", "LH003", "Phạm Quốc Bảo", "0987654321", "BS. Trần Minh", "Đang khám");
            dgvLichHen.Rows.Add("09:30", "LH004", "Trần Thị Lan", "0978123456", "BS. Võ Anh", "Đã xác nhận");
            dgvLichHen.Rows.Add("10:00", "LH005", "Nguyễn Minh Khang", "0934567890", "BS. Nguyễn Hải", "Chờ khám");
            dgvLichHen.Rows.Add("10:30", "LH006", "Đặng Thu Hà", "0965123789", "BS. Võ Anh", "Đã hoàn thành");
            dgvLichHen.Rows.Add("11:00", "LH007", "Phan Đức Tài", "0945678123", "BS. Trần Minh", "Đã xác nhận");
            dgvLichHen.Rows.Add("13:30", "LH008", "Hoàng Ngọc Mai", "0923456789", "BS. Nguyễn Hải", "Chờ khám");
            dgvLichHen.Rows.Add("14:00", "LH009", "Lê Quốc Huy", "0911223344", "BS. Võ Anh", "Đã xác nhận");
            dgvLichHen.Rows.Add("15:00", "LH010", "Nguyễn Thị Yến", "0988112233", "BS. Trần Minh", "Đã hủy");
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
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDatLichHen_Click(object sender, EventArgs e)
        {
            T_DatLichHen f1 = new T_DatLichHen();
            f1.ShowDialog();

        }

        private void btnDsBenhNhan_Click(object sender, EventArgs e)
        {
            T_DanhSachBenhNhan f2 = new T_DanhSachBenhNhan();
            f2.ShowDialog();

        }
    }
}
