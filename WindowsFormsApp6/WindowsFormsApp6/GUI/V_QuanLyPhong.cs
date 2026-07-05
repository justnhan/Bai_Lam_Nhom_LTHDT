using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai_Lam_Nhom_LTHDT.DAL;
using Bai_Lam_Nhom_LTHDT.Entity;

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class V_QuanLyPhong : Form
    {
        PhongKhamDAL phongKhamDAL = new PhongKhamDAL();
        ChuyenKhoaDAL ch = new ChuyenKhoaDAL();
        private bool isAdding = false;
        private bool isEditing = false;
        public V_QuanLyPhong()
        {
            InitializeComponent();
            dgvQuanLyPhong.AutoGenerateColumns = true;
            dgvQuanLyPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuanLyPhong.MultiSelect = false;
            dgvQuanLyPhong.AllowUserToAddRows = false;
            dgvQuanLyPhong.ReadOnly = true;
            
            dgvQuanLyPhong.RowHeadersVisible = false;
            dgvQuanLyPhong.AllowUserToResizeRows = false;

            LoadPhong();
            LoadcboMaChuyenKhoa();
            KhoaControl();
            UiHelper.StyleForm(this);
            UiHelper.StyleTitle(lblTitle);
            UiHelper.StyleGrid(dgvQuanLyPhong);

            UiHelper.StyleButton(btnThem, UiHelper.Them);
            UiHelper.StyleButton(btnSua, UiHelper.Sua);
            UiHelper.StyleButton(btnXoa, UiHelper.Xoa);
            UiHelper.StyleButton(btnLamMoi, UiHelper.Refresh);

            dgvQuanLyPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuanLyPhong.MultiSelect = false;
            dgvQuanLyPhong.AllowUserToAddRows = false;
            dgvQuanLyPhong.RowHeadersVisible = false;
            dgvQuanLyPhong.ReadOnly = true;
            dgvQuanLyPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuanLyPhong.CellClick += dgvPhong_CellClick;

            MauDGV(dgvQuanLyPhong);


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
        private void LoadPhong()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã phòng");
            dt.Columns.Add("Tên phòng");
            dt.Columns.Add("Trạng thái");
            dt.Columns.Add("Ghi chú");
            dt.Columns.Add("Mã chuyên khoa");

            foreach (PhongKham pk in phongKhamDAL.GetAllPhongKham())
            {
                dt.Rows.Add(
                    pk.MaPhong,
                    pk.TenPhong,
                    pk.TrangThai,
                    pk.GhiChu,
                    pk.MaChuyenKhoa
                );
            }

            dgvQuanLyPhong.DataSource = dt;
            dgvQuanLyPhong.ClearSelection();
        }
        //==========================
        // Hiển thị dữ liệu khi click
        //==========================
        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvQuanLyPhong.Rows[e.RowIndex];

            txtMaPhong.Text = row.Cells[0].Value.ToString();

            txtTenPhong.Text = row.Cells[1].Value.ToString();

            cboTrangThai.Text = row.Cells[2].Value.ToString();

            cboMaChuyenKhoa.Text = row.Cells[4].Value.ToString();

            KhoaControl();


        }

        private void LoadcboMaChuyenKhoa()
        {
            List<ChuyenKhoa> maChuyenKhoaList = ch.GetAllChuyenKhoa();
            cboMaChuyenKhoa.DataSource = maChuyenKhoaList;
            cboMaChuyenKhoa.DisplayMember = "TenChuyenKhoa";
            cboMaChuyenKhoa.ValueMember = "MaChuyenKhoa";

        }

        //==========================
        // Kiểm tra dữ liệu
        //==========================
        private bool KiemTraDuLieu()
        {
            if (txtMaPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng.");
                txtMaPhong.Focus();
                return false;
            }

            if (txtTenPhong.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng.");
                txtTenPhong.Focus();
                return false;
            }




            return true;
        }

        //==========================
        // Kiểm tra mã phòng trùng
        //==========================
        private bool KiemTraTrungMa()
        {
            foreach (DataGridViewRow row in dgvQuanLyPhong.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[0].Value.ToString() == txtMaPhong.Text.Trim())
                    return true;
            }

            return false;
        }

        //==========================
        // Thêm
        //==========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;


            MoControl();

            

            txtMaPhong.ReadOnly = true;
            txtMaPhong.Text = phongKhamDAL.MaPhongGenerator();

            txtTenPhong.Clear();
            txtGhiChu.Clear();

            cboTrangThai.SelectedIndex = 0;
        }

        //==========================
        // Sửa
        //==========================
        private void btnSua_Click(object sender, EventArgs e)
        {

            if (dgvQuanLyPhong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            if (!KiemTraDuLieu())
                return;
            MoControl();

            isEditing = true;

            txtMaPhong.ReadOnly = true;


        }

        //==========================
        // Xóa
        //==========================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvQuanLyPhong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa.");
                return;
            }

            DialogResult rs = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa phòng này?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                dgvQuanLyPhong.Rows.Remove(dgvQuanLyPhong.CurrentRow);

                MessageBox.Show("Đã xóa.");

                btnLamMoi.PerformClick();
            }
        }

        //==========================
        // Làm mới
        //==========================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();

            txtTimKiem.Clear();
            cboTrangThai.SelectedIndex = 0;

            dgvQuanLyPhong.ClearSelection();

            txtMaPhong.Focus();
        }

        //==========================
        // Chỉ nhập số
        //==========================
        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void V_QuanLyPhong_Load(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            



        }

        private void KhoaControl()
        {
            txtMaPhong.ReadOnly = true;
            txtTenPhong.ReadOnly = true;
            txtGhiChu.ReadOnly = true;

            cboTrangThai.Enabled = false;
            cboMaChuyenKhoa.Enabled = false;
        }
        private void MoControl()
        {
            txtTenPhong.ReadOnly = false;
            txtGhiChu.ReadOnly = false;
            cboTrangThai.Enabled = true;
            cboMaChuyenKhoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;
            if (isAdding)
            {
                if (KiemTraTrungMa())
                {
                    MessageBox.Show("Mã phòng đã tồn tại!");
                    return;
                }
                PhongKham newPhong = new PhongKham
                {
                    MaPhong = txtMaPhong.Text.Trim(),
                    TenPhong = txtTenPhong.Text.Trim(),
                    TrangThai = cboTrangThai.Text,
                    GhiChu = txtGhiChu.Text.Trim(),
                    MaChuyenKhoa = cboMaChuyenKhoa.Text
                };
                phongKhamDAL.Add(newPhong);
                LoadPhong();
                MessageBox.Show("Thêm phòng thành công!");
            }
            else if (isEditing)
            {
                PhongKham updatedPhong = new PhongKham
                {
                    MaPhong = txtMaPhong.Text.Trim(),
                    TenPhong = txtTenPhong.Text.Trim(),
                    TrangThai = cboTrangThai.Text,
                    GhiChu = txtGhiChu.Text.Trim(),
                    MaChuyenKhoa = cboMaChuyenKhoa.Text
                };
                phongKhamDAL.Update(updatedPhong);
                LoadPhong();
                MessageBox.Show("Cập nhật phòng thành công!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            List<PhongKham> ds = phongKhamDAL.SearchByTenPhong(keyword);

            DataTable dt = new DataTable();

            dt.Columns.Add("Mã phòng");
            dt.Columns.Add("Tên phòng");
            dt.Columns.Add("Trạng thái");
            dt.Columns.Add("Ghi chú");
            dt.Columns.Add("Mã chuyên khoa");

            foreach (PhongKham pk in ds)
            {
                dt.Rows.Add(
                    pk.MaPhong,
                    pk.TenPhong,
                    pk.TrangThai,
                    pk.GhiChu,
                    pk.MaChuyenKhoa
                );
            }

            dgvQuanLyPhong.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng phù hợp.");
            }


        }
    }
}