using Bai_Lam_Nhom_LTHDT.Entity;
using Bai_Lam_Nhom_LTHDT.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Bai_Lam_Nhom_LTHDT.GUI
{
    public partial class N_QuanLyBacSi : Form
    {

        BacSiDAL dal = new BacSiDAL();
        public N_QuanLyBacSi()
        {
            InitializeComponent();
            RefreshData();
            MauDGV(dgvDanhSachBacSi);

        }

        private void RefreshData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã BS");
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("SĐT");
            dt.Columns.Add("Email");
            dt.Columns.Add("Chuyên khoa");
            dt.Columns.Add("Ngày sinh");

            foreach (BacSi bs in dal.GetAllBacSi())
            {
                dt.Rows.Add(
                    bs.MaBS,
                    bs.HoTen,
                    bs.GioiTinh,
                    bs.Sdt,
                    bs.Email,
                    bs.MaChuyenKhoa,
                    bs.NgaySinh.ToShortDateString()
                );
            }

            dgvDanhSachBacSi.DataSource = dt;
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuanLyBacSi_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmQuanLyBacSi_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
