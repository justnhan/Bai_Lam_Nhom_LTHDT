using Bai_Lam_Nhom_LTHDT.DAL;
using Bai_Lam_Nhom_LTHDT.Entity;
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
        LichHenDAL lichHenDAL = new LichHenDAL();
        BenhNhanDAL benhNhanDAL = new BenhNhanDAL();
        KhungGioDAL khungGioDAL = new KhungGioDAL();


        public T_TrangChuTiepNhan()
        {
            InitializeComponent();
            MauDGV(dgvLichHen);
            RefereshData();
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

            dgvLichHen.DataSource = dt;
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

        private void dgvLichHen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maHen = dgvLichHen.Rows[e.RowIndex].Cells["Mã hẹn"].Value.ToString();

            txtMaHen.Text = maHen;

            // Lấy đối tượng Lịch hẹn
            LichHen lh = lichHenDAL.GetByMaHen(maHen);

            if (lh == null) return;

            // ===== Thông tin lịch hẹn =====
            txtGhiChu.Text = lh.GhiChu;
            dtpNgayHen.Value = lh.NgayDat;
            cboTrangThai.SelectedItem = lh.TrangThai;

            // Nếu giờ hẹn lưu dưới dạng MaGio thì đổi sang giờ
            txtGioHen.Text = khungGioDAL.GetByMaGio(lh.MaGio).GioBatDau;

            // ===== Thông tin bệnh nhân =====
            txtHoVaTen.Text = benhNhanDAL.GetHoTenByMaHen(maHen);
            txtSDT.Text = benhNhanDAL.GetSDTByMaHen(maHen);
            dtpNgaySinh.Value = Convert.ToDateTime(benhNhanDAL.GetNgaySinhByMaHen(maHen));
            txtDiaChi.Text = benhNhanDAL.GetDiaChiByMaHen(maHen);

            // ===== Thông tin bác sĩ =====
            txtBacSi.Text = lichHenDAL.GetHoTenBSByMaHen(maHen);
        }
    }
}
