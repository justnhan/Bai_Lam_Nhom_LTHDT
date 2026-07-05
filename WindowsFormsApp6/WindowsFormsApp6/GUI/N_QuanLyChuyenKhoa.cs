using Bai_Lam_Nhom_LTHDT.DAL;
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
        ChuyenKhoaDAL chuyenKhoaDAL = new ChuyenKhoaDAL();
        BacSiDAL bacSiDAL = new BacSiDAL();
        PhongKhamDAL phongKhamDAL = new PhongKhamDAL();

        bool isAdding = false;
        bool isEditing = false;
        public N_QuanLyChuyenKhoa()
        {
            InitializeComponent();
            RefreshData();
            MauDGV(dgvBSThuocKhoa);
            MauDGV(dgvDanhSachChuyenKhoa);
            MauDGV(dgvDanhSachPhongKham);
        }

        private bool ValidateInputs()
        {
            if (Validator.IsEmpty(txtMaKhoa.Text))
            {
                MessageBox.Show("Mã chuyên khoa không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Validator.IsEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Tên chuyên khoa không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        
        private void RefreshData()
        {
            DataTable dtck = new DataTable();
            

            dtck.Columns.Add("Mã Chuyên Khoa");
            dtck.Columns.Add("Tên Chuyên Khoa");

            

            foreach (ChuyenKhoa ck in chuyenKhoaDAL.GetAllChuyenKhoa())
            {
                dtck.Rows.Add(ck.MaChuyenKhoa, ck.TenChuyenKhoa);
            }
            
            
            dgvDanhSachChuyenKhoa.DataSource = dtck;


        }

        private void RefreshDataBacSi_Phong()
        {
            DataTable dtbs = new DataTable();
            DataTable dtpk = new DataTable();

            dtbs.Columns.Add("Mã BS");
            dtbs.Columns.Add("Họ tên");
            dtbs.Columns.Add("Giới tính");
            dtbs.Columns.Add("SĐT");
            dtbs.Columns.Add("Email");
            dtbs.Columns.Add("Mã CK");
            dtbs.Columns.Add("Ngày sinh");

            dtpk.Columns.Add("Mã Phòng");
            dtpk.Columns.Add("Tên Phòng");
            dtpk.Columns.Add("Trạng Thái");
            dtpk.Columns.Add("Ghi Chú");
            dtpk.Columns.Add("Mã CK");

            foreach (BacSi bs in bacSiDAL.SearchByMaChuyenKhoa(txtMaKhoa.Text.Trim()))
            {
                dtbs.Rows.Add(bs.MaBS, bs.HoTen, bs.GioiTinh, bs.Sdt, bs.Email, bs.MaChuyenKhoa, bs.NgaySinh);
            }
            foreach (PhongKham pk in phongKhamDAL.GetByMaChuyenKhoa(txtMaKhoa.Text.Trim()))
            {
                dtpk.Rows.Add(pk.MaPhong, pk.TenPhong, pk.TrangThai, pk.GhiChu, pk.MaChuyenKhoa);
            }

            dgvBSThuocKhoa.DataSource = dtbs;
            dgvDanhSachPhongKham.DataSource = dtpk;
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

        private void Khoa()
        {
            txtMaKhoa.ReadOnly = true;
            txtTenKhoa.ReadOnly = true;
        }
        private void Mo()
        {
            txtMaKhoa.ReadOnly = false;
            txtTenKhoa.ReadOnly = false;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvDanhSachChuyenKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvDanhSachChuyenKhoa.Rows[e.RowIndex];
            txtMaKhoa.Text = row.Cells["Mã Chuyên Khoa"].Value.ToString();
            txtTenKhoa.Text = row.Cells["Tên Chuyên Khoa"].Value.ToString();
            nudSoLuongBS.Value = chuyenKhoaDAL.GetCountBacSiByMaCK(txtMaKhoa.Text.Trim());
            nudSoLuongPK.Value = chuyenKhoaDAL.GetCountPhongKhamByMaCK(txtMaKhoa.Text.Trim());  
            RefreshDataBacSi_Phong();

            Khoa();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            isAdding = true;
            Mo();

            txtMaKhoa.Clear();
            txtTenKhoa.Clear();

            txtMaKhoa.Focus();  
            

        }
        


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }
            isEditing = true;
            Mo();

            txtMaKhoa.Enabled = false; // Mã chuyên khoa không được sửa
            txtTenKhoa.Focus(); // Chỉ cho phép sửa tên chuyên khoa)

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bacSiDAL.ExistsByMaChuyenKhoa(txtMaKhoa.Text.Trim()) || phongKhamDAL.ExistsByMaChuyenKhoa(txtMaKhoa.Text.Trim()))
            {
                MessageBox.Show("Không thể xóa chuyên khoa này vì có bác sĩ hoặc phòng khám thuộc chuyên khoa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Validator.IsEmpty(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa cần xóa.");
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa chuyên khoa này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maCK = txtMaKhoa.Text;
                if (chuyenKhoaDAL.DeleteByMaCK(maCK))
                {
                    MessageBox.Show("Xóa chuyên khoa thành công.");
                    RefreshData();
                    // Xóa dữ liệu trong các TextBox và ComboBox
                    txtMaKhoa.Clear();
                    txtTenKhoa.Clear();
                    nudSoLuongBS.Value = 0;
                    nudSoLuongPK.Value = 0;
                }
                else
                {
                    MessageBox.Show(chuyenKhoaDAL.GetError(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            ChuyenKhoa ck = new ChuyenKhoa
            {
                MaChuyenKhoa = txtMaKhoa.Text.Trim(),
                TenChuyenKhoa = txtTenKhoa.Text.Trim()
            };
            if (isAdding)
            {
                if (chuyenKhoaDAL.ExistsMaCK(ck.MaChuyenKhoa))
                {
                    MessageBox.Show(chuyenKhoaDAL.GetError(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (chuyenKhoaDAL.Add(ck))
                {
                    MessageBox.Show("Thêm chuyên khoa thành công.");
                    RefreshData();
                    isAdding = false;
                }
                else
                {
                    MessageBox.Show("Thêm chuyên khoa thất bại.");
                }
            }
            else if (isEditing)
            {
                if (chuyenKhoaDAL.Update(ck))
                {
                    MessageBox.Show("Cập nhật chuyên khoa thành công.");
                    RefreshData();
                    isEditing = false;
                }
                else
                {
                    MessageBox.Show(chuyenKhoaDAL.GetError(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
