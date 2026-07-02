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
    public partial class N_QuanLyBacSi : Form
    {
        List<BacSi> dsbs = new List<BacSi>();
   
        public N_QuanLyBacSi()
        {
            InitializeComponent();
            DuLieuMau();
            MauDGV(dgvDanhSachBacSi);

        }
        private void DuLieuMau()
        {
            txtMaBS.Text = "BS01";
            txtHoTenBS.Text = "Bác sĩ 1";
            txtSDT.Text = "0123456789";
            txtEmail.Text = "bacsi1@example.com";
            dtpNgaySinh.Value = new DateTime(1990, 1, 1);
            cboChucVu.Items.AddRange(new string[] { "Bác sĩ", "Y tá", "Nhân viên" });
            cboChuyenKhoa.Items.AddRange(new string[] { "Đa khoa", "Nhi khoa", "Răng Hàm Mặt" });
            cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });
            cboLoai.Items.AddRange(new string[] { "Mã", "Họ và tên", "sdt" });
            
            dgvDanhSachBacSi.DataSource = new List<BacSi>
            {
                new BacSi { MaBS = "BS01",GioiTinh="Nam", HoTenBS = "Bác sĩ 1", Sdt = "0123456789", Email = "bacsi1@example.com",MaChuyenKhoa="CK01" },
                new BacSi { MaBS = "BS02",GioiTinh="Nữ", HoTenBS = "Bác sĩ 2", Sdt = "0123456789", Email = "bacsi2@example.com",MaChuyenKhoa="CK02" },
                new BacSi { MaBS = "BS03",GioiTinh="Nam", HoTenBS = "Bác sĩ 3", Sdt = "0123456789", Email = "bacsi3@example.com",MaChuyenKhoa="CK03" }
            };
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
            BacSi bs = new BacSi();
            bs.MaBS = txtMaBS.Text;
            bs.HoTenBS = txtHoTenBS.Text;
            bs.Sdt = txtSDT.Text;
            bs.Email = txtEmail.Text;
            bs.GioiTinh = cboGioiTinh.Text;
            bs.MaChuyenKhoa = cboChuyenKhoa.Text;

            dsbs.Add(bs);

            dgvDanhSachBacSi.DataSource = null;
            dgvDanhSachBacSi.DataSource = dsbs;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBacSi.CurrentRow == null) return;

            int index = dgvDanhSachBacSi.CurrentRow.Index;

            dsbs[index].MaBS = txtMaBS.Text;
            dsbs[index].HoTenBS = txtHoTenBS.Text;
            dsbs[index].Sdt = txtSDT.Text;
            dsbs[index].Email = txtEmail.Text;
            dsbs[index].GioiTinh = cboGioiTinh.Text;
            dsbs[index].MaChuyenKhoa = cboChuyenKhoa.Text;

            dgvDanhSachBacSi.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachBacSi.CurrentRow == null) return;

            int index = dgvDanhSachBacSi.CurrentRow.Index;
            dsbs.RemoveAt(index);

            dgvDanhSachBacSi.DataSource = null;
            dgvDanhSachBacSi.DataSource = dsbs;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaBS.Clear();
            txtHoTenBS.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            cboGioiTinh.SelectedIndex = -1;
            cboChuyenKhoa.SelectedIndex = -1;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtKey.Text.Trim().ToLower();
            string loai = cboLoai.Text;

            if (string.IsNullOrEmpty(loai))
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm");
                return;
            }

            List<BacSi> ketQua = new List<BacSi>();

            foreach (BacSi bs in dsbs)
            {
                if (loai == "Mã")
                {
                    if (bs.MaBS != null && bs.MaBS.ToLower().Contains(keyword))
                        ketQua.Add(bs);
                }
                else if (loai == "Họ và tên")
                {
                    if (bs.HoTenBS != null && bs.HoTenBS.ToLower().Contains(keyword))
                        ketQua.Add(bs);
                }
                else if (loai == "sdt")
                {
                    if (bs.Sdt != null && bs.Sdt.Contains(keyword))
                        ketQua.Add(bs);
                }
            }

            dgvDanhSachBacSi.DataSource = null;
            dgvDanhSachBacSi.DataSource = ketQua;
        }
    }
}
