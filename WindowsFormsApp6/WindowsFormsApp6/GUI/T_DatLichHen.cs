using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Bai_Lam_Nhom_LTHDT.DAL;
using Bai_Lam_Nhom_LTHDT.Entity;

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class T_DatLichHen : Form
    {
        // ====== BIẾN TOÀN CỤC ======
        private string maBenhNhanDangChon = "";
        private string maGioDangChon = "";
        private string maLichDangChon = "";

        private LichTrucDAL lichTrucDAL = new LichTrucDAL();
        private BenhNhanDAL benhNhanDAL = new BenhNhanDAL();
        private ChuyenKhoaDAL chuyenKhoaDAL = new ChuyenKhoaDAL();
        private BacSiDAL bacSiDAL = new BacSiDAL();
        private LichHenDAL lichHenDAL = new LichHenDAL();
        private KhungGioDAL khungGioDAL = new KhungGioDAL();

        // ====== CONSTRUCTOR ======
        public T_DatLichHen()
        {
            InitializeComponent();

            MauDGV(dgvChuyenKhoa);
            MauDGV(dgvLichTruc);
            MauDGV(dgvKhungGio);

            LoadChuyenKhoa();
        }

        // ====== STYLE DATAGRIDVIEW ======
        private void MauDGV(DataGridView dgv)
        {
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 136, 229);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 251, 255);

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.GridColor = Color.FromArgb(227, 242, 253);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
        }

        // ====== LOAD CHUYÊN KHOA ======
        private void LoadChuyenKhoa()
        {
            dgvChuyenKhoa.DataSource = chuyenKhoaDAL.GetAllChuyenKhoa();

            dgvChuyenKhoa.Columns["MaChuyenKhoa"].HeaderText = "Mã";
            dgvChuyenKhoa.Columns["TenChuyenKhoa"].HeaderText = "Chuyên khoa";
            dgvChuyenKhoa.Columns["MoTa"].Visible = false;
        }

        // ====== LOAD BÁC SĨ THEO CHUYÊN KHOA ======
        private void LoadBacSi(string maCK)
        {
            List<BacSi> ds = bacSiDAL.SearchByMaChuyenKhoa(maCK);

            if (ds == null || ds.Count == 0)
            {
                txtBacSi.Clear();
                txtPhongKham.Clear();
                dgvLichTruc.DataSource = null;
                dgvKhungGio.DataSource = null;
                return;
            }

            BacSi bs = ds[0];

            txtBacSi.Text = bs.HoTen;

            LoadLichTruc(bs.MaBS);
        }

        // ====== LOAD LỊCH TRỰC ======
        private void LoadLichTruc(string maBS)
        {
            dgvLichTruc.DataSource = lichTrucDAL.GetByMaBS(maBS);

            if (dgvLichTruc.Columns.Count == 0) return;

            dgvLichTruc.Columns["MaLich"].HeaderText = "Mã lịch";
            dgvLichTruc.Columns["NgayTruc"].HeaderText = "Ngày trực";
            dgvLichTruc.Columns["GioBatDau"].HeaderText = "Bắt đầu";
            dgvLichTruc.Columns["GioKetThuc"].HeaderText = "Kết thúc";
            dgvLichTruc.Columns["SoLuongToiDa"].HeaderText = "SL";

            dgvLichTruc.Columns["MaBS"].Visible = false;
            dgvLichTruc.Columns["MaPhong"].Visible = false;
        }

        // ====== LOAD KHUNG GIỜ ======
        private void LoadKhungGio(string maLich)
        {
            dgvKhungGio.DataSource = khungGioDAL.GetByMaLich(maLich);

            if (dgvKhungGio.Columns.Count == 0) return;

            dgvKhungGio.Columns["MaGio"].Visible = false;
            dgvKhungGio.Columns["MaLich"].Visible = false;

            dgvKhungGio.Columns["GioBatDau"].HeaderText = "Bắt đầu";
            dgvKhungGio.Columns["GioKetThuc"].HeaderText = "Kết thúc";
            dgvKhungGio.Columns["TrangThai"].HeaderText = "Trạng thái";
        }

        // ====== CLEAR FORM ======
        private void ClearForm()
        {
            maBenhNhanDangChon = "";
            maGioDangChon = "";
            maLichDangChon = "";

            txtTimBenhNhan.Clear();

            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();

            txtLyDoKham.Clear();
            txtGhiChu.Clear();

            txtBacSi.Clear();
            txtPhongKham.Clear();

            rdoNam.Checked = true;

            dtpNgaySinh.Value = DateTime.Today;
            dtpNgayHen.Value = DateTime.Today;

            nudGioHen.Value = nudGioHen.Minimum;

            dgvLichTruc.DataSource = null;
            dgvKhungGio.DataSource = null;

            LockPatientInfo(false);
        }
        // ================== TÌM BỆNH NHÂN ==================
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân hoặc số điện thoại!");
                return;
            }

            BenhNhan bn = benhNhanDAL.Search(txtTimBenhNhan.Text.Trim());

            if (bn == null)
            {
                MessageBox.Show("Không tìm thấy bệnh nhân!");
                return;
            }
            LockPatientInfo(true);
            maBenhNhanDangChon = bn.MaBN;

            txtHoVaTen.Text = bn.HoTen;
            txtSDT.Text = bn.Sdt;
            txtDiaChi.Text = bn.DiaChi;
            txtEmail.Text = bn.Email;
            dtpNgaySinh.Value = bn.NgaySinh;

            if (bn.GioiTinh == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;

            MessageBox.Show("Đã tìm thấy bệnh nhân!");
        }


        // ================== CHỌN CHUYÊN KHOA ==================
        private void dgvChuyenKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maCK = dgvChuyenKhoa.Rows[e.RowIndex]
                .Cells["MaChuyenKhoa"].Value.ToString();

            LoadBacSi(maCK);
        }


        // ================== CHỌN CHUYÊN KHOA (CLICK TEXT HIỂN THỊ) ==================
        private void dgvChuyenKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maCK = dgvChuyenKhoa.Rows[e.RowIndex]
                .Cells["MaChuyenKhoa"].Value.ToString();

            LoadBacSi(maCK);

            cboChuyenKhoa.Text = dgvChuyenKhoa.Rows[e.RowIndex]
                .Cells["TenChuyenKhoa"].Value.ToString();
        }


        // ================== CHỌN LỊCH TRỰC ==================
        private void dgvLichTruc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtPhongKham.Text = dgvLichTruc.Rows[e.RowIndex]
                .Cells["MaPhong"].Value.ToString();

            dtpNgayHen.Value = Convert.ToDateTime(
                dgvLichTruc.Rows[e.RowIndex].Cells["NgayTruc"].Value
            );

            TimeSpan gio = (TimeSpan)dgvLichTruc.Rows[e.RowIndex]
                .Cells["GioBatDau"].Value;

            nudGioHen.Value = gio.Hours;

            maLichDangChon = dgvLichTruc.Rows[e.RowIndex]
                .Cells["MaLich"].Value.ToString();

            LoadKhungGio(maLichDangChon);
        }


        // ================== CHỌN KHUNG GIỜ ==================
        private void dgvKhungGio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            maGioDangChon = dgvKhungGio.Rows[e.RowIndex]
                .Cells["MaGio"].Value.ToString();

            string gioBatDau = dgvKhungGio.Rows[e.RowIndex]
                .Cells["GioBatDau"].Value.ToString();

            nudGioHen.Value = Convert.ToDecimal(
                TimeSpan.Parse(gioBatDau).Hours
            );
        }


        // ================== ĐẶT LỊCH HẸN ==================
        private void btnDatLichHen_Click(object sender, EventArgs e)
        {
            // ===== CHECK BỆNH NHÂN =====
            if (maBenhNhanDangChon == "")
            {
                MessageBox.Show("Vui lòng tìm bệnh nhân!");
                return;
            }

            // ===== CHECK BÁC SĨ =====
            if (string.IsNullOrWhiteSpace(txtBacSi.Text))
            {
                MessageBox.Show("Vui lòng chọn bác sĩ!");
                return;
            }

            // ===== CHECK CHỌN KHUNG GIỜ =====
            if (maGioDangChon == "")
            {
                MessageBox.Show("Vui lòng chọn khung giờ!");
                return;
            }

            // ===== CHECK LÝ DO =====
            if (string.IsNullOrWhiteSpace(txtLyDoKham.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do khám!");
                return;
            }

            // ===== CHECK NGÀY =====
            if (dtpNgayHen.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày hẹn không hợp lệ!");
                return;
            }

            // ===== TẠO LỊCH HẸN =====
            LichHen lh = new LichHen();

            lh.MaHen = "LH" + DateTime.Now.ToString("yyMMddHHmmss");
            lh.MaBN = maBenhNhanDangChon;
            lh.NgayDat = dtpNgayHen.Value;
            lh.TrangThai = "Chờ khám";
            lh.LyDoKham = txtLyDoKham.Text;
            lh.GhiChu = txtGhiChu.Text;

            // ===== LƯU =====
            if (lichHenDAL.Add(lh))
            {
                MessageBox.Show("Đặt lịch thành công!");

                DialogResult rs = MessageBox.Show(
                    "Bạn có muốn đặt tiếp không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo);

                if (rs == DialogResult.Yes)
                {
                    ClearForm();
                    LoadChuyenKhoa();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(lichHenDAL.GetError());
            }
        }


        // ================== HỦY ==================
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn hủy?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (rs == DialogResult.Yes)
            {
                ClearForm();
            }
        }


        // ================== LÀM MỚI ==================
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadChuyenKhoa();
            txtTimBenhNhan.Focus();
        }
        private void LockPatientInfo(bool lockState)
        {
            txtHoVaTen.ReadOnly = lockState;
            txtSDT.ReadOnly = lockState;
            txtDiaChi.ReadOnly = lockState;
            txtEmail.ReadOnly = lockState;

            rdoNam.Enabled = !lockState;
            rdoNu.Enabled = !lockState;
            dtpNgaySinh.Enabled = !lockState;
        }
        private void dtpNgayHen_ValueChanged(object sender, EventArgs e)
        {
            if (dtpNgayHen.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Không được chọn ngày trong quá khứ!");
                dtpNgayHen.Value = DateTime.Today;
            }
        }
        private void txtTimBenhNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }

        private void txtTimBenhNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lưu tạm thông tin!");
        }
    }
}

