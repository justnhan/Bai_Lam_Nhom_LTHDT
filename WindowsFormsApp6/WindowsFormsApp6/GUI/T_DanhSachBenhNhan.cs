using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Spire.Xls;
using System.Drawing.Printing;
using Bai_Lam_Nhom_LTHDT.DAL;
using Bai_Lam_Nhom_LTHDT.Entity;

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class T_DanhSachBenhNhan : Form
    {
        private BenhNhanDAL benhNhanDAL = new BenhNhanDAL();
        private PrintDocument printDocument = new PrintDocument();
        public T_DanhSachBenhNhan()
        {
            InitializeComponent();

            MauDGV(dgvBenhNhan);

            printDocument.PrintPage += PrintDocument_PrintPage;
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
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font titleFont = new Font("Times New Roman", 20, FontStyle.Bold);
            Font headerFont = new Font("Times New Roman", 12, FontStyle.Bold);
            Font normalFont = new Font("Times New Roman", 11);

            int x = 40;
            int y = 30;

            // ===== TIÊU ĐỀ =====

            g.DrawString("PHÒNG KHÁM ĐA KHOA ABC",
                headerFont, Brushes.Black, 220, y);

            y += 30;

            g.DrawString("DANH SÁCH BỆNH NHÂN",
                titleFont, Brushes.Black, 180, y);

            y += 50;

            g.DrawString("Ngày in: " +
                DateTime.Now.ToString("dd/MM/yyyy"),
                normalFont,
                Brushes.Black,
                x,
                y);

            g.DrawString("Người in: Tiếp tân",
                normalFont,
                Brushes.Black,
                500,
                y);

            y += 30;

            g.DrawLine(Pens.Black, 30, y, 770, y);

            y += 20;

            // Header bảng

            g.DrawString("STT", headerFont, Brushes.Black, 40, y);
            g.DrawString("Mã BN", headerFont, Brushes.Black, 90, y);
            g.DrawString("Họ tên", headerFont, Brushes.Black, 180, y);
            g.DrawString("Giới tính", headerFont, Brushes.Black, 420, y);
            g.DrawString("SĐT", headerFont, Brushes.Black, 540, y);

            y += 25;

            g.DrawLine(Pens.Black, 30, y, 770, y);

            y += 10;

            int stt = 1;

            foreach (DataGridViewRow row in dgvBenhNhan.Rows)
            {
                if (row.IsNewRow)
                    continue;

                g.DrawString(stt.ToString(),
                    normalFont,
                    Brushes.Black,
                    45,
                    y);

                g.DrawString(row.Cells["MaBN"].Value.ToString(),
                    normalFont,
                    Brushes.Black,
                    90,
                    y);

                g.DrawString(row.Cells["HoTen"].Value.ToString(),
                    normalFont,
                    Brushes.Black,
                    180,
                    y);

                g.DrawString(row.Cells["GioiTinh"].Value.ToString(),
                    normalFont,
                    Brushes.Black,
                    430,
                    y);

                g.DrawString(row.Cells["SDT"].Value.ToString(),
                    normalFont,
                    Brushes.Black,
                    540,
                    y);

                y += 25;

                g.DrawLine(Pens.LightGray, 30, y, 770, y);

                stt++;
            }

            y += 30;

            g.DrawString("Tổng số bệnh nhân: " + (stt - 1),
                headerFont,
                Brushes.Black,
                40,
                y);

            y += 60;

            g.DrawString(
                "Huế, ngày " +
                DateTime.Now.Day +
                " tháng " +
                DateTime.Now.Month +
                " năm " +
                DateTime.Now.Year,
                normalFont,
                Brushes.Black,
                500,
                y);

            y += 25;

            g.DrawString("Người lập danh sách",
                headerFont,
                Brushes.Black,
                560,
                y);

            y += 80;

            g.DrawString("(Ký và ghi rõ họ tên)",
                normalFont,
                Brushes.Black,
                550,
                y);
        }
        private void LoadDanhSachBenhNhan()
        {
            dgvBenhNhan.DataSource = benhNhanDAL.GetAllBenhNhan();

            dgvBenhNhan.Columns["MaBN"].HeaderText = "Mã BN";
            dgvBenhNhan.Columns["HoTen"].HeaderText = "Họ và tên";
            dgvBenhNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvBenhNhan.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvBenhNhan.Columns["Sdt"].HeaderText = "Số điện thoại";
            dgvBenhNhan.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvBenhNhan.Columns["Email"].HeaderText = "Email";

            dgvBenhNhan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void btnKinhLup_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(txtTuKhoa.Text))
            {
                LoadDanhSachBenhNhan();
                return;
            }
            string cot = "";

            switch (cboLoai.Text)
            {
                case "Mã bệnh nhân":
                    cot = "MaBN";
                    break;

                case "Họ và tên":
                    cot = "HoTen";
                    break;

                case "Số điện thoại":
                    cot = "SDT";
                    break;

                case "Email":
                    cot = "Email";
                    break;
            }

            dgvBenhNhan.DataSource = benhNhanDAL.TimKiem(cot, txtTuKhoa.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DanhSachBenhNhan_Load(object sender, EventArgs e)
        {
            LoadDanhSachBenhNhan();

            cboLoai.Items.Add("Mã bệnh nhân");
            cboLoai.Items.Add("Họ và tên");
            cboLoai.Items.Add("Số điện thoại");
            cboLoai.Items.Add("Email");

            cboLoai.SelectedIndex = 0;
        }
        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(txtMaBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần sửa!");
                return;
            }
            BenhNhan bn = new BenhNhan();

            bn.MaBN = txtMaBenhNhan.Text;
            bn.HoTen = txtHoVaTen.Text;
            bn.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            bn.NgaySinh = dtpNgaySinh.Value;
            bn.Sdt = txtSDT.Text;
            bn.DiaChi = txtDiaChi.Text;
            bn.Email = txtEmail.Text;
            DialogResult rs = MessageBox.Show(
            "Bạn có chắc muốn cập nhật thông tin?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (rs == DialogResult.No)
                return;
            if (benhNhanDAL.Update(bn))
            {
                MessageBox.Show("Cập nhật thành công!");

                LoadDanhSachBenhNhan();

                ClearForm();
            }
            else
            {
                MessageBox.Show(benhNhanDAL.GetError());
            }
            
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaBenhNhan_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(txtMaBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần xóa!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc muốn xóa bệnh nhân này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rs == DialogResult.No)
                return;

            if (benhNhanDAL.DeleteByMaBN(txtMaBenhNhan.Text))
            {
                MessageBox.Show("Xóa bệnh nhân thành công!");

                LoadDanhSachBenhNhan();

                ClearForm();
            }
            else
            {
                MessageBox.Show(benhNhanDAL.GetError());
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgvBenhNhan.Rows[e.RowIndex];

            txtMaBenhNhan.Text = row.Cells["MaBN"].Value.ToString();
            txtHoVaTen.Text = row.Cells["HoTen"].Value.ToString();

            if (row.Cells["GioiTinh"].Value.ToString() == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;

            dtpNgaySinh.Value =
                Convert.ToDateTime(row.Cells["NgaySinh"].Value);

            txtSDT.Text =
                row.Cells["Sdt"].Value.ToString();

            txtDiaChi.Text =
                row.Cells["DiaChi"].Value.ToString();

            txtEmail.Text =
                row.Cells["Email"].Value.ToString();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (Validator.IsEmpty(txtMaBenhNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập mã bệnh nhân!");
                txtMaBenhNhan.Focus();
                return;
            }

            if (Validator.IsEmpty(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtHoVaTen.Focus();
                return;
            }

            if (!Validator.IsPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                txtSDT.Focus();
                return;
            }

            if (!Validator.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ!");
                txtEmail.Focus();
                return;
            }

            if (benhNhanDAL.ExistsMaBN(txtMaBenhNhan.Text))
            {
                MessageBox.Show("Mã bệnh nhân đã tồn tại!");
                return;
            }

            if (benhNhanDAL.ExistsSDT(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!");
                return;
            }

            if (benhNhanDAL.ExistsEmail(txtEmail.Text))
            {
                MessageBox.Show("Email đã tồn tại!");
                return;
            }

            BenhNhan bn = new BenhNhan();

            bn.MaBN = txtMaBenhNhan.Text;
            bn.HoTen = txtHoVaTen.Text;
            bn.GioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
            bn.NgaySinh = dtpNgaySinh.Value;
            bn.Sdt = txtSDT.Text;
            bn.DiaChi = txtDiaChi.Text;
            bn.Email = txtEmail.Text;

            if (benhNhanDAL.Add(bn))
            {
                MessageBox.Show("Thêm bệnh nhân thành công!");

                LoadDanhSachBenhNhan();

                ClearForm();
            }
            else
            {
                MessageBox.Show(benhNhanDAL.GetError());
            }
        }
        private void ClearForm()
        {
            txtMaBenhNhan.Clear();
            txtHoVaTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtNgheNghiep.Clear();
            txtGhiChu.Clear();

            rdoNam.Checked = true;

            dtpNgaySinh.Value = DateTime.Today;
            dtpNgayDangKy.Value = DateTime.Today;

            txtMaBenhNhan.Focus();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvBenhNhan.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Excel File (*.xlsx)|*.xlsx";

            save.FileName = "DanhSachBenhNhan.xlsx";

            if (save.ShowDialog() != DialogResult.OK)
                return;

            Workbook wb = new Workbook();

            Worksheet sheet = wb.Worksheets[0];

            sheet.Name = "DanhSachBenhNhan";

            // Tiêu đề
            for (int i = 0; i < dgvBenhNhan.Columns.Count; i++)
            {
                sheet.Range[1, i + 1].Text =
                    dgvBenhNhan.Columns[i].HeaderText;
            }

            // Dữ liệu
            for (int i = 0; i < dgvBenhNhan.Rows.Count; i++)
            {
                if (dgvBenhNhan.Rows[i].IsNewRow)
                    continue;

                for (int j = 0; j < dgvBenhNhan.Columns.Count; j++)
                {
                    sheet.Range[i + 2, j + 1].Text =
                        dgvBenhNhan.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Tự giãn cột
            sheet.AllocatedRange.AutoFitColumns();

            wb.SaveToFile(save.FileName, FileFormat.Version2013);

            MessageBox.Show("Xuất Excel thành công!");
        }
        private void btnInDanhSach_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();

            preview.Document = printDocument;

            preview.WindowState = FormWindowState.Maximized;

            preview.PrintPreviewControl.Zoom = 1.2;

            preview.ShowDialog();
        }
    }
}