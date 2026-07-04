using Bai_Lam_Nhom_LTHDT.DAL;
using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Bai_Lam_Nhom_LTHDT.GUI
{

    public partial class N_ChiTietLichHen : Form
    {
        LichHenDAL lichHenDAL = new LichHenDAL();
        ChuyenKhoaDAL chuyenKhoaDAL = new ChuyenKhoaDAL();
        BacSiDAL bacSiDAL = new BacSiDAL();
        private int currentRow = 0;
        public N_ChiTietLichHen()
        {
            InitializeComponent();
            RefereshData();

            MauDGV(dgvDanhSachBenhNhan);

            loadcboChuyenKhoa();
            cboChuyenKhoa.SelectedIndex = 0;
            loadcboBacSi();

        }
        

        private void RefereshData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã hẹn");
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Mã giờ");
            dt.Columns.Add("Ngay đặt");
            dt.Columns.Add("Trang thái");
            dt.Columns.Add("Lý do khám");
            dt.Columns.Add("Ghi chú");

            foreach (LichHen lh in lichHenDAL.GetAllLichHen())
            {
                dt.Rows.Add(lh.MaHen, lh.MaBN, lh.MaGio, lh.NgayDat, lh.TrangThai, lh.LyDoKham, lh.GhiChu);
            }

            dgvDanhSachBenhNhan.DataSource = dt;
        }
        private void RefereshDataByMaBS()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hẹn");
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Mã giờ");
            dt.Columns.Add("Ngay đặt");
            dt.Columns.Add("Trang thái");
            dt.Columns.Add("Lý do khám");
            dt.Columns.Add("Ghi chú");
            foreach (LichHen lh in lichHenDAL.SearchByMaBacSi(cboBacSi.SelectedValue.ToString().Trim()))
            {
                dt.Rows.Add(lh.MaHen, lh.MaBN, lh.MaGio, lh.NgayDat, lh.TrangThai, lh.LyDoKham, lh.GhiChu);
            }
            dgvDanhSachBenhNhan.DataSource = dt;
        }
        private void RefereshDataByMaChuyenKhoa()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hẹn");
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Mã giờ");
            dt.Columns.Add("Ngay đặt");
            dt.Columns.Add("Trang thái");
            dt.Columns.Add("Lý do khám");
            dt.Columns.Add("Ghi chú");
            foreach (LichHen lh in lichHenDAL.SearchByMaChuyenKhoa(cboChuyenKhoa.SelectedValue.ToString().Trim()))
            {
                dt.Rows.Add(lh.MaHen, lh.MaBN, lh.MaGio, lh.NgayDat, lh.TrangThai, lh.LyDoKham, lh.GhiChu);
            }
            dgvDanhSachBenhNhan.DataSource = dt;
        }

        private void loadcboChuyenKhoa()
        {
            List<ChuyenKhoa> list = chuyenKhoaDAL.GetAllChuyenKhoa();
            cboChuyenKhoa.DataSource = list;
            cboChuyenKhoa.DisplayMember = "TenChuyenKhoa"; // Hiển thị tên chuyên khoa
            cboChuyenKhoa.ValueMember = "MaChuyenKhoa"; // Giá trị là mã chuyên khoa
            cboChuyenKhoa.SelectedIndex = -1; // Không chọn mục nào mặc định
        }

        private void loadcboBacSi()
        {
            List<BacSi> list = bacSiDAL.SearchByMaChuyenKhoa(cboChuyenKhoa.SelectedValue.ToString().Trim());
            cboBacSi.DataSource = list;
            cboBacSi.DisplayMember = "HoTen"; // Hiển thị tên bác sĩ
            cboBacSi.ValueMember = "MaBS"; // Giá trị là mã bác sĩ
            cboBacSi.SelectedIndex = -1; // Không chọn mục nào mặc định
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

        private void N_ChiTietLichHen_Load(object sender, EventArgs e)
        {

        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            if (cboBacSi.SelectedValue != null)
            {
                RefereshDataByMaBS();
            }
            if (cboBacSi.SelectedValue == null)
            {
                RefereshDataByMaChuyenKhoa();
            }
        }


        private string maHen;
        private string maBN;
        private string maGio;
        private string ngayDat;
        private string trangThai;
        private string lyDo;
        private string ghiChu;

        private string chuyenKhoa;
        private string bacSi;

        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBenhNhan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn!");
                return;
            }

            DataGridViewRow row = dgvDanhSachBenhNhan.CurrentRow;

            maHen = row.Cells[0].Value.ToString();
            maBN = row.Cells[1].Value.ToString();
            maGio = row.Cells[2].Value.ToString();
            ngayDat = row.Cells[3].Value.ToString();
            trangThai = row.Cells[4].Value.ToString();
            lyDo = row.Cells[5].Value.ToString();
            ghiChu = row.Cells[6].Value.ToString();

            chuyenKhoa = cboChuyenKhoa.Text;
            bacSi = cboBacSi.Text;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font title = new Font("Arial", 18, FontStyle.Bold);
            Font normal = new Font("Arial", 11);

            int y = 60;

            g.DrawString("PHIẾU LỊCH HẸN KHÁM", title, Brushes.Black, 180, y);

            y += 60;

            g.DrawString("Mã hẹn: " + maHen, normal, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("Mã bệnh nhân: " + maBN, normal, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("Chuyên khoa: " + chuyenKhoa, normal, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("Bác sĩ: " + bacSi, normal, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("Ngày đặt: " + ngayDat, normal, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("Mã giờ: " + maGio, normal, Brushes.Black, 50, y);
            y += 30;

            g.DrawString("Trạng thái: " + trangThai, normal, Brushes.Black, 50, y);
            y += 40;

            g.DrawString("Lý do khám:", normal, Brushes.Black, 50, y);
            y += 25;

            g.DrawString(lyDo, normal, Brushes.Black, 80, y);
            y += 40;

            g.DrawString("Ghi chú:", normal, Brushes.Black, 50, y);
            y += 25;

            g.DrawString(ghiChu, normal, Brushes.Black, 80, y);

            y += 50;

            g.DrawString("Ngày in: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                         normal,
                         Brushes.Black,
                         50,
                         y);
        }
    }
}
