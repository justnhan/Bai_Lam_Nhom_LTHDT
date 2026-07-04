using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bai_Lam_Nhom_LTHDT.DAL;

namespace Bai_Lam_Nhom_LTHDT.GUI
{
    public partial class N_LichLamViec : Form
    {
        LichTrucDAL dal = new LichTrucDAL();
        public N_LichLamViec()
        {
            InitializeComponent();
            RefreshData();
            MauDGV(dgvLichLamViec);
        }
        private void RefreshData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã Lịch Trực");
            dt.Columns.Add("Mã Bác Sĩ");
            dt.Columns.Add("Mã Phòng");
            dt.Columns.Add("Ngày Trực");
            dt.Columns.Add("Giờ bắt đầu");
            dt.Columns.Add("Giờ kết thúc");
            dt.Columns.Add("Số lượng bệnh nhân");

            foreach (LichTruc lichTruc in dal.GetAllLichTruc())
            {
                dt.Rows.Add(
                    lichTruc.MaLich,
                    lichTruc.MaBS,
                    lichTruc.MaPhong,
                    lichTruc.NgayTruc.ToShortDateString(),
                    lichTruc.GioBatDau,
                    lichTruc.GioKetThuc,
                    lichTruc.SoLuongToiDa
                );
            }

            dgvLichLamViec.DataSource = dt;
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

        private void dgvLichLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
