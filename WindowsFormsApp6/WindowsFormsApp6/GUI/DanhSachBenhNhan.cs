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
    public partial class DanhSachBenhNhan : Form
    {
        public DanhSachBenhNhan()
        {
            InitializeComponent();
            giuLieuMau();
            MauDGV(dgvBenhNhan);
        }
        private void giuLieuMau()
        {
            txtDiaChi.Text = "SONHA001";
            txtEmail.Text = "example@example.com";
            txtGhiChu.Text = "Đau đầu";
            txtHoVaTen.Text = "Nguyen Van A";
            txtMaBenhNhan.Text = "BN001";
            txtNgheNghiep.Text = "Kỹ sư";
            txtSDT.Text = "0123456789";
            txtTuKhoa.Text = "Nguyễn";
            dtpNgayDangKy.Value = new DateTime(2023, 8, 1);
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            cboLoai.Items.Add("Họ Và Tên");
            cboLoai.Items.Add("Mã Bệnh Nhân");
            cboLoai.Items.Add("Số Điện Thoại");
            dgvBenhNhan.Rows.Add(1, "BN001", "Nguyễn Văn An", "Nam", "15/03/2000", "0905123456", "Huế", "01/06/2026", "");
            dgvBenhNhan.Rows.Add(2, "BN002", "Lê Thị Hoa", "Nữ", "22/07/1998", "0912345678", "Đà Nẵng", "01/06/2026", "Tái khám");
            dgvBenhNhan.Rows.Add(3, "BN003", "Phạm Quốc Bảo", "Nam", "10/12/1985", "0987654321", "Quảng Trị", "01/06/2026", "");
            dgvBenhNhan.Rows.Add(4, "BN004", "Trần Thị Lan", "Nữ", "05/05/1995", "0978123456", "Huế", "02/06/2026", "Dị ứng thuốc");
            dgvBenhNhan.Rows.Add(5, "BN005", "Nguyễn Minh Khang", "Nam", "18/09/2003", "0934567890", "Quảng Nam", "02/06/2026", "");
            dgvBenhNhan.Rows.Add(6, "BN006", "Đặng Thu Hà", "Nữ", "25/01/1992", "0965123789", "Huế", "02/06/2026", "Khám định kỳ");
            dgvBenhNhan.Rows.Add(7, "BN007", "Phan Đức Tài", "Nam", "14/08/1988", "0945678123", "Đà Nẵng", "03/06/2026", "");
            dgvBenhNhan.Rows.Add(8, "BN008", "Hoàng Ngọc Mai", "Nữ", "30/11/2001", "0923456789", "Quảng Bình", "03/06/2026", "");
            dgvBenhNhan.Rows.Add(9, "BN009", "Lê Quốc Huy", "Nam", "07/04/1997", "0911223344", "Huế", "03/06/2026", "Tái khám");
            dgvBenhNhan.Rows.Add(10, "BN010", "Nguyễn Thị Yến", "Nữ", "19/06/1999", "0988112233", "Đà Nẵng", "03/06/2026", "");
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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DanhSachBenhNhan_Load(object sender, EventArgs e)
        {

        }
    }
}
