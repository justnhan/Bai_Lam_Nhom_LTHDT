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
namespace Bai_Lam_Nhom_LTHDT.GUI
{
    public partial class V_QuanLySlotTong : Form
    {
        private LichTrucDAL lichTrucDAL = new LichTrucDAL();
        private BacSiDAL bacSiDAL = new BacSiDAL();
        private PhongKhamDAL phongDAL = new PhongKhamDAL();
        private bool isEdit = false;
        private bool isAdd = false;
        public V_QuanLySlotTong()
        {
            InitializeComponent();

            dgvLichTruc.AutoGenerateColumns = true;
            dgvLichTruc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichTruc.MultiSelect = false;
            dgvLichTruc.AllowUserToAddRows = false;
            dgvLichTruc.ReadOnly = true;
            dgvLichTruc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichTruc.RowHeadersVisible = false;
            dgvLichTruc.AllowUserToResizeRows = false;

            dgvLichTruc.CellClick += dgvLichTruc_CellClick;

            dtpBatDau.Format = DateTimePickerFormat.Time;
            dtpBatDau.ShowUpDown = true;

            dtpKetThuc.Format = DateTimePickerFormat.Time;
            dtpKetThuc.ShowUpDown = true;
            cbMaBS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadBacSi();
            LoadPhong();
            LoadLichTruc();
            ResetForm();
            KhoaDieuKhien();
        }
        private void LoadLichTruc()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã lịch");
            dt.Columns.Add("Mã bác sĩ");
            dt.Columns.Add("Mã phòng");
            dt.Columns.Add("Ngày trực");
            dt.Columns.Add("Giờ bắt đầu");
            dt.Columns.Add("Giờ kết thúc");
            dt.Columns.Add("Số BN tối đa");

            foreach (LichTruc lt in lichTrucDAL.GetAllLichTruc())
            {
                dt.Rows.Add(
                    lt.MaLich,
                    lt.MaBS,
                    lt.MaPhong,
                    lt.NgayTruc.ToShortDateString(),
                    lt.GioBatDau.ToString(@"hh\:mm"),
                    lt.GioKetThuc.ToString(@"hh\:mm"),
                    lt.SoLuongToiDa
                );
            }

            dgvLichTruc.DataSource = dt;
            dgvLichTruc.ClearSelection();
            txtMaLich.Enabled = true;
        }

        private void LoadBacSi()
        {
            cbMaBS.DataSource = bacSiDAL.GetAllBacSi();

            cbMaBS.DisplayMember = "MaBS";

            cbMaBS.ValueMember = "MaBS";
        }
        private void LoadPhong()
        {
            List<PhongKham> list = phongDAL.GetAllPhongKham();

            cbPhong.DataSource = null;
            cbPhong.DataSource = list;
            cbPhong.DisplayMember = "TenPhong";
            cbPhong.ValueMember = "MaPhong";
        }
        private void ResetForm()
        {
            txtMaLich.Clear();

            if (cbMaBS.Items.Count > 0)
                cbMaBS.SelectedIndex = -1;

            txtTenBS.Clear();

            if (cbPhong.Items.Count > 0)
                cbPhong.SelectedIndex = -1;

            dtpNgay.Value = DateTime.Today;

            dtpBatDau.Value = DateTime.Today.AddHours(7);

            dtpKetThuc.Value = DateTime.Today.AddHours(11);

            nudSoLuong.Value = 20;
        }
        private void LoadRow()
        {
            if (dgvLichTruc.CurrentRow == null)
                return;

            DataGridViewRow row = dgvLichTruc.CurrentRow;

            txtMaLich.Text = row.Cells[0].Value.ToString();

            cbMaBS.SelectedValue = row.Cells[1].Value.ToString();

            cbPhong.SelectedValue = row.Cells[2].Value.ToString();

            dtpNgay.Value =
                DateTime.Parse(row.Cells[3].Value.ToString());

            dtpBatDau.Value =
                DateTime.Today +
                TimeSpan.Parse(row.Cells[4].Value.ToString());

            dtpKetThuc.Value =
                DateTime.Today +
                TimeSpan.Parse(row.Cells[5].Value.ToString());

            nudSoLuong.Value =
                Convert.ToDecimal(row.Cells[6].Value);

            txtMaLich.ReadOnly = true;
        }
        private bool KiemTraDuLieu()
        {
            if (string.IsNullOrWhiteSpace(txtMaLich.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lịch.");
                txtMaLich.Focus();
                return false;
            }

            // Chỉ kiểm tra trùng mã khi thêm mới
            if (isAdd && lichTrucDAL.existMaLich(txtMaLich.Text.Trim()))
            {
                MessageBox.Show("Mã lịch đã tồn tại.");
                txtMaLich.Focus();
                return false;
            }

            // Kiểm tra bác sĩ
            if (cbMaBS.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ.");
                cbMaBS.Focus();
                return false;
            }

            // Kiểm tra phòng
            if (cbPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn phòng khám.");
                cbPhong.Focus();
                return false;
            }

            // Kiểm tra số lượng
            if (nudSoLuong.Value <= 0)
            {
                MessageBox.Show("Số bệnh nhân tối đa phải lớn hơn 0.");
                nudSoLuong.Focus();
                return false;
            }

            // Kiểm tra thời gian
            if (dtpBatDau.Value >= dtpKetThuc.Value)
            {
                MessageBox.Show("Giờ bắt đầu phải nhỏ hơn giờ kết thúc.");
                dtpBatDau.Focus();
                return false;
            }

            // ==========================
            // THÊM MỚI
            // ==========================
            if (isAdd)
            {
                if (lichTrucDAL.ExistsDoctorSchedule(
                    cbMaBS.SelectedValue.ToString(),
                    dtpNgay.Value.Date,
                    dtpBatDau.Value.TimeOfDay,
                    dtpKetThuc.Value.TimeOfDay))
                {
                    MessageBox.Show("Bác sĩ đã có lịch trực trong khoảng thời gian này.");
                    return false;
                }

                if (lichTrucDAL.ExistsRoomSchedule(
                    cbPhong.SelectedValue.ToString(),
                    dtpNgay.Value.Date,
                    dtpBatDau.Value.TimeOfDay,
                    dtpKetThuc.Value.TimeOfDay))
                {
                    MessageBox.Show("Phòng khám đã được sử dụng trong khoảng thời gian này.");
                    return false;
                }
            }

            // ==========================
            // CHỈNH SỬA
            // ==========================
            if (isEdit)
            {
                if (lichTrucDAL.ExistsDoctorScheduleExcept(
                    txtMaLich.Text.Trim(),
                    cbMaBS.SelectedValue.ToString(),
                    dtpNgay.Value.Date,
                    dtpBatDau.Value.TimeOfDay,
                    dtpKetThuc.Value.TimeOfDay))
                {
                    MessageBox.Show("Bác sĩ đã có lịch trực trong khoảng thời gian này.");
                    return false;
                }

                if (lichTrucDAL.ExistsRoomScheduleExcept(
                    txtMaLich.Text.Trim(),
                    cbPhong.SelectedValue.ToString(),
                    dtpNgay.Value.Date,
                    dtpBatDau.Value.TimeOfDay,
                    dtpKetThuc.Value.TimeOfDay))
                {
                    MessageBox.Show("Phòng khám đã được sử dụng trong khoảng thời gian này.");
                    return false;
                }
            }

            return true;
        }
        private void dgvLichTruc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Không xử lý khi click vào tiêu đề cột
            if (e.RowIndex < 0)
                return;

            dgvLichTruc.CurrentCell = dgvLichTruc.Rows[e.RowIndex].Cells[0];



            LoadRow();


        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if (!KiemTraDuLieu())
                return;

            LichTruc lt = new LichTruc();

            lt.MaLich = txtMaLich.Text.Trim();
            lt.MaBS = cbMaBS.SelectedValue.ToString();
            lt.MaPhong = cbPhong.SelectedValue.ToString();
            lt.NgayTruc = dtpNgay.Value.Date;
            lt.GioBatDau = dtpBatDau.Value.TimeOfDay;
            lt.GioKetThuc = dtpKetThuc.Value.TimeOfDay;
            lt.SoLuongToiDa = (int)nudSoLuong.Value;

            //----------------------------------
            // THÊM
            //----------------------------------

            if (isAdd)
            {
                if (lichTrucDAL.Add(lt))
                {
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    MessageBox.Show(lichTrucDAL.GetError());
                    return;
                }
            }

            //----------------------------------
            // SỬA
            //----------------------------------

            if (isEdit)
            {
                if (lichTrucDAL.Update(lt))
                {
                    MessageBox.Show("Cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show(lichTrucDAL.GetError());
                    return;
                }
            }

            LoadLichTruc();

            ResetForm();

            KhoaDieuKhien();

            isAdd = false;
            isEdit = false;
            btnThem.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvLichTruc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch cần sửa.");
                return;
            }

            isEdit = true;
            isAdd = false;

            MoDieuKhien();

            LoadRow();
            txtMaLich.ReadOnly = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLichTruc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lịch cần xóa.");
                return;
            }

            string maLich =
                dgvLichTruc.CurrentRow.Cells[0].Value.ToString();

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                if (lichTrucDAL.DeleteByMaLT(maLich))
                {
                    MessageBox.Show("Đã xóa.");

                    LoadLichTruc();

                    ResetForm();

                    KhoaDieuKhien();
                }
                else
                {
                    MessageBox.Show(lichTrucDAL.GetError());
                }
            }
        }
        private void V_QuanLySlotTong_Load(object sender, EventArgs e)
        {
            btnLamMoi.PerformClick();
        }
        private void KhoaDieuKhien()
        {
            txtMaLich.Enabled = false;
            txtMaLich.ReadOnly = true;
            cbMaBS.Enabled = false;
            txtTenBS.Enabled = false;
            cbPhong.Enabled = false;
            dtpNgay.Enabled = false;
            dtpBatDau.Enabled = false;
            dtpKetThuc.Enabled = false;
            nudSoLuong.Enabled = false;
        }
        private void MoDieuKhien()
        {
            txtMaLich.Enabled = true;
            txtMaLich.ReadOnly = true;
            cbMaBS.Enabled = true;
            txtTenBS.Enabled = false;
            cbPhong.Enabled = true;
            dtpNgay.Enabled = true;
            dtpBatDau.Enabled = true;
            dtpKetThuc.Enabled = true;
            nudSoLuong.Enabled = true;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            isAdd = true;
            isEdit = false;

            MoDieuKhien();

            txtMaLich.Text = lichTrucDAL.TaoMaLichMoi();
            txtMaLich.ReadOnly = true;

            cbMaBS.SelectedIndex = -1;
            txtTenBS.Clear();
            cbPhong.SelectedIndex = -1;

            dtpNgay.Value = DateTime.Today;
            dtpBatDau.Value = DateTime.Today.AddHours(7);
            dtpKetThuc.Value = DateTime.Today.AddHours(11);
            nudSoLuong.Value = 20;
        }

        private void cbMaBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaBS.SelectedItem == null)
                return;

            BacSi bs = (BacSi)cbMaBS.SelectedItem;

            txtTenBS.Text = bs.HoTen;
        }
    }
}
