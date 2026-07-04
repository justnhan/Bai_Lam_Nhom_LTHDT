using Bai_Lam_Nhom_LTHDT.DAL;
using Bai_Lam_Nhom_LTHDT.Entity;
using System;
using System.Collections;
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
        ChuyenKhoaDAL dalck = new ChuyenKhoaDAL();
        private bool isAdding = false;
        private bool isEditing = false;
        public N_QuanLyBacSi()
        {
            InitializeComponent();
            RefreshData();
            MauDGV(dgvDanhSachBacSi);
            LoadCboChuyenKhoa();
        }

        // Hàm trung gian
        private bool ValidateInput()
        {

            // Họ tên
            if (Validator.IsEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên bác sĩ không được để trống.");
                txtHoTen.Focus();
                return false;
            }

            if (!Validator.IsLetter(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên chỉ được chứa chữ cái.");
                txtHoTen.Focus();
                return false;
            }

            // Giới tính
            if (cboGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính.");
                cboGioiTinh.Focus();
                return false;
            }

            // Số điện thoại
            if (Validator.IsEmpty(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.");
                txtSDT.Focus();
                return false;
            }

            if (!Validator.IsPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ.");
                txtSDT.Focus();
                return false;
            }

            // Email
            if (Validator.IsEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống.");
                txtEmail.Focus();
                return false;
            }

            if (!Validator.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ.");
                txtEmail.Focus();
                return false;
            }

            // Chuyên khoa
            if (cboChuyenKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa.");
                cboChuyenKhoa.Focus();
                return false;
            }

            // Ngày sinh
            if (dtpNgaySinh.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại.");
                dtpNgaySinh.Focus();
                return false;
            }

            return true;
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

        private void LoadCboChuyenKhoa()
        {
            List<ChuyenKhoa> dt = dalck.GetAllChuyenKhoa();
            cboChuyenKhoa.DataSource = dt;
            cboChuyenKhoa.DisplayMember = "TenChuyenKhoa"; // Hiển thị tên chuyên khoa
            cboChuyenKhoa.ValueMember = "MaChuyenKhoa"; // Giá trị là mã chuyên khoa
            cboChuyenKhoa.SelectedIndex = -1; // Không chọn mục nào mặc định

        }
        
        private void Khoa()
        {
            txtMaBS.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            cboGioiTinh.Enabled = false;
            txtSDT.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cboChuyenKhoa.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }
        private void Mo()
        {
            txtMaBS.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            cboGioiTinh.Enabled = true;
            txtSDT.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cboChuyenKhoa.Enabled = true;
            dtpNgaySinh.Enabled = true;
        }


        // CRUD
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            Mo();


            isAdding = true;
            txtMaBS.Text = dal.MaBSGenerator();
            txtMaBS.Enabled = false;

            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();

            cboGioiTinh.SelectedIndex = -1;
            cboChuyenKhoa.SelectedIndex = -1;

            dtpNgaySinh.Value = DateTime.Today;

            txtHoTen.Focus();



        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (Validator.IsEmpty(txtMaBS.Text))
            {
                MessageBox.Show("Vui lòng chọn bác sĩ cần sửa.");
                return;
            }
            if (!ValidateInput())
            {
                return;
            }
            Mo();
            isEditing = true;
            txtMaBS.Enabled = false;

            txtHoTen.Focus();


        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
            if (Validator.IsEmpty(txtMaBS.Text))
            {
                MessageBox.Show("Vui lòng chọn bác sĩ cần xóa.");
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa bác sĩ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maBS = txtMaBS.Text;
                if (dal.DeleteByMaBS(maBS))
                {
                    MessageBox.Show("Xóa bác sĩ thành công.");
                    RefreshData();
                    // Xóa dữ liệu trong các TextBox và ComboBox
                    txtMaBS.Clear();
                    txtHoTen.Clear();
                    cboGioiTinh.SelectedIndex = -1;
                    txtSDT.Clear();
                    txtEmail.Clear();
                    cboChuyenKhoa.SelectedIndex = -1;
                    dtpNgaySinh.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("Xóa bác sĩ thất bại.");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            BacSi bs = new BacSi(
                txtMaBS.Text,
                txtHoTen.Text,
                cboGioiTinh.Text,
                txtSDT.Text,
                txtEmail.Text,
                cboChuyenKhoa.SelectedValue.ToString(),
                dtpNgaySinh.Value
            );

            if (isAdding)
            {
                if (dal.Add(bs))
                {
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    MessageBox.Show(dal.GetError());
                }
            }
            else if (isEditing)
            {
                if (dal.Update(bs))
                {
                    MessageBox.Show("Cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show(dal.GetError());
                }
            }

            RefreshData();

            Mo();
            isEditing = false;
            isAdding = false;
        }
        

        //Tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboLoai.Text == "Mã")
            {
                BacSi bs = dal.GetByMaBS(txtKey.Text.Trim());
                dgvDanhSachBacSi.DataSource = bs;
                if (bs != null)
                {
                    dgvDanhSachBacSi.DataSource = new List<BacSi> { bs };
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bác sĩ.");
                    RefreshData();
                }
            }
            else if (cboLoai.Text == "Tên")
            {
                List<BacSi> list = dal.SearchByHoTen(txtKey.Text.Trim());
                
                if (list.Count > 0)
                {
                    dgvDanhSachBacSi.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bác sĩ.");
                    RefreshData();
                }
            }
            else if (cboLoai.Text == "Chuyên khoa")
            {
                List<BacSi> list = dal.SearchByMaChuyenKhoa(txtKey.Text.Trim());
                if (list.Count > 0)
                {
                    dgvDanhSachBacSi.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bác sĩ.");
                    RefreshData();
                }
            }
            else
            {
                BacSi bs = dal.GetBySdt(txtKey.Text.Trim());
                dgvDanhSachBacSi.DataSource = bs;
                if (bs != null)
                {
                    dgvDanhSachBacSi.DataSource = new List<BacSi> { bs };
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bác sĩ.");
                    RefreshData();
                }

            }

        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        // Chọn đổ dư liệu ra control
        private void dgvDanhSachBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvDanhSachBacSi.Rows[e.RowIndex];

            txtMaBS.Text = row.Cells["Mã BS"].Value?.ToString();
            txtHoTen.Text = row.Cells["Họ tên"].Value?.ToString();
            cboGioiTinh.Text = row.Cells["Giới tính"].Value?.ToString();
            txtSDT.Text = row.Cells["SĐT"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();

            // Nếu ComboBox của bạn đang bind DataSource
            cboChuyenKhoa.SelectedValue = row.Cells["Chuyên khoa"].Value;

            // Nếu ComboBox chỉ thêm Items thì dùng:
            // cboChuyenKhoa.Text = row.Cells["Chuyên khoa"].Value?.ToString();

            if (row.Cells["Ngày sinh"].Value != null)
            {
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["Ngày sinh"].Value);
            }

            Khoa();
        }




        // bấm nhầm
        private void FrmQuanLyBacSi_Load(object sender, EventArgs e)
        {

        }
        private void dgvDanhSachBacSi_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

    }
}
