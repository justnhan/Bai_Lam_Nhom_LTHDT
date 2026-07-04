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
using System.Windows.Forms.DataVisualization.Charting;
using PdfFont = iTextSharp.text.Font;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class A_ThongKe : Form
    {
        public A_ThongKe()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            ResetMenuColor();
            btnDashboard.BackColor = Color.RoyalBlue;

            chartThongKeBS.Series[0].Color = Color.FromArgb(52, 152, 219);
            chartThongKeBS.Series[0].IsValueShownAsLabel = true;

            chartThongKeBS.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chartThongKeBS.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chartThongKeBS.ChartAreas[0].AxisY.Interval = 10;
            LoadThang();
            LoadNam();

            cboNamBC.SelectedItem = DateTime.Now.Year;
        }
        private void LoadNam()
        {
            cboNamBC.Items.Clear();

            for (int i = 2023; i <= DateTime.Now.Year + 2; i++)
            {
                cboNamBC.Items.Add(i);
            }
        }

        private BaoCaoDAL baoCaoDAL = new BaoCaoDAL();
        private void LoadChartBaoCao(int thang, int nam)
        {
            chartBaoCao.Series.Clear();

            Series s = new Series("Doanh thu");
            s.ChartType = SeriesChartType.Column;

            var data = baoCaoDAL.DoanhThuTheoNgay(thang, nam);

            foreach (var item in data)
            {
                s.Points.AddXY(item.Key, item.Value);
            }

            chartBaoCao.Series.Add(s);
        }
        private void LoadCard()
        {
            lblSoLichHen_BC.Text = baoCaoDAL.TongLichHen().ToString();

            lblTongSoBenhNhan_BC.Text = baoCaoDAL.TongBenhNhan().ToString();

            lblDoanhThu.Text =
                baoCaoDAL.TongDoanhThu().ToString("N0");
        }
        private void LoadBaoCao(int thang, int nam)
        {
            dgvBaoCao.Rows.Clear();

            

            var ds = baoCaoDAL.GetBaoCaoTheoThangNam(thang, nam);

            

            foreach (BaoCao item in ds)
            {
                dgvBaoCao.Rows.Add(
                item.STT,
                item.MaHoaDon,
                item.BenhNhan,
                
                item.BacSi,
          
                item.DichVu,
                item.ThanhTien.ToString("N0"),
                item.NgayKham.ToString("dd/MM/yyyy")
            );
            }


            LoadCard();
            LoadChartBaoCao(thang, nam);
        }
        private ThongKeKhoaDAL thongKeKhoaDAL = new ThongKeKhoaDAL();
        private void LoadCardThongKeKhoa()
        {
            lblNoiTongQuat.Text =
                thongKeKhoaDAL.TongNoiTongQuat().ToString();

            lblSoNhiKhoa.Text =
                thongKeKhoaDAL.TongNhiKhoa().ToString();

            lblTimMach.Text =
                thongKeKhoaDAL.TongTimMach().ToString();

            lblTongKhoa.Text =
                thongKeKhoaDAL.TongKhoa().ToString();
        }
        private void LoadChartThongKeKhoa()
        {
            chartThongKeKhoa.Series.Clear();

            var s = chartThongKeKhoa.Series.Add("Số bệnh nhân");

            s.ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            s.IsValueShownAsLabel = true;

            foreach (ThongKeKhoa item in thongKeKhoaDAL.GetThongKeKhoa())
            {
                s.Points.AddXY(item.TenKhoa, item.SoBenhNhan);
            }

            chartThongKeKhoa.ChartAreas[0].AxisX.Interval = 1;
            chartThongKeKhoa.Legends.Clear();
        }
        private void LoadThongKeKhoa()
        {
            dgvThongKeKhoa.Rows.Clear();

            int stt = 1;

            foreach (ThongKeKhoa item in thongKeKhoaDAL.GetThongKeKhoa())
            {
                dgvThongKeKhoa.Rows.Add(
                    stt++,
                    item.MaKhoa,
                    item.TenKhoa,
                    item.SoBacSi,
                    item.SoBenhNhan,
                    item.DoanhThu
                );
            }
        }
        private ThongKeBacSiDAL thongKeBacSiDAL = new ThongKeBacSiDAL();
        private void LoadThang()
        {
            cboThangBC.Items.Clear();

            for (int i = 1; i <= 12; i++)
            {
                cboThangBC.Items.Add(i);
            }

            cboThangBC.SelectedIndex = DateTime.Now.Month - 1;
        }
        private void LoadChartThongKeBacSi()
        {
            chartThongKeBS.Series.Clear();

            var series = chartThongKeBS.Series.Add("Số lịch hẹn");

            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            series.IsValueShownAsLabel = true;
            chartThongKeBS.ChartAreas[0].AxisX.Interval = 1;

            chartThongKeBS.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chartThongKeBS.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chartThongKeBS.Legends.Clear();

            foreach (ThongKeBacSi item in thongKeBacSiDAL.GetThongKeBacSi())
            {
                series.Points.AddXY(item.TenBacSi, item.SoLichHen);
            }
        }
        private void LoadThongKeBacSi()
        {
            dgvThongKeBS.Rows.Clear();

            int stt = 1;

            foreach (ThongKeBacSi item in thongKeBacSiDAL.GetThongKeBacSi())
            {
                dgvThongKeBS.Rows.Add(
                    stt++,
                    item.MaBS,
                    item.TenBacSi,
                    item.ChuyenKhoa,
                    item.SoLichHen,
                    item.DaKham,
                    item.Huy
                );
            }
        }
        private void LoadChartCanhBao()
        {
            chartCanhBao.Series.Clear();

            Series s = chartCanhBao.Series.Add("CanhBao");

            s.ChartType = SeriesChartType.Pie;

            s.IsValueShownAsLabel = true;

            s.Points.AddXY("Đang chờ",
                lichHenDAL.GetTongCanhBaoKhan());

            s.Points.AddXY("Quá giờ",
                lichHenDAL.GetTongQuaGio());

            s.Points.AddXY("Đã hủy",
                lichHenDAL.GetAllLichHen()
                          .Count(x => x.TrangThai == "Da huy"));
        }
        private void LoadQuaGio()
        {
            lblQuaGio.Text =
                lichHenDAL.GetTongQuaGio().ToString();
        }
        private void LoadCanhBaoKhan()
        {
            lblTongCanhBaoKhan.Text =
                lichHenDAL.GetTongCanhBaoKhan().ToString();
        }
        private void LoadChuaThanhToan()
        {
            lblSoChuaThanhToan.Text = "0";
        }
        private void LoadCanhBao()
        {
            dgvCanhBao.Rows.Clear();

            foreach (CanhBao cb in lichHenDAL.GetDanhSachCanhBao())
            {
                dgvCanhBao.Rows.Add(
                    cb.STT,
                    cb.LoaiCanhBao,
                    cb.NoiDung,
                    cb.MucDo,
                    cb.ThoiGian
                );
            }
        }
        private void LoadChart()
        {
            chartLichHen.Series.Clear();

            var series = chartLichHen.Series.Add("Lịch hẹn");

            series.ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            var data = lichHenDAL.GetThongKeTheoThu();

            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
        }
        private BenhNhanDAL benhNhanDAL = new BenhNhanDAL();
        private KhungGioDAL khungGioDAL = new KhungGioDAL();
        private void LoadDanhSachThongKe()
        {
            dgvLichHen.Rows.Clear();

            int stt = 1;

            foreach (ThongTinLichHen item in lichHenDAL.GetDanhSachThongKe())
            {
                dgvLichHen.Rows.Add(
                    stt++,
                    item.MaBN,
                    item.TenBenhNhan,
                    item.GioHen,
                    item.TenBacSi,
                    item.TrangThai
                );
            }
        }

        private void LoadDangCho()
        {
            List<LichHen> list = lichHenDAL.GetAllLichHen();

            int dem = 0;

            foreach (LichHen lh in list)
            {
                if (lh.TrangThai == "Cho kham")
                {
                    dem++;
                }
            }

            lblSoLuongCho.Text = dem.ToString();
        }
        private void LoadDaHuy()
        {
            List<LichHen> list = lichHenDAL.GetAllLichHen();

            int dem = 0;

            foreach (LichHen lh in list)
            {
                if (lh.TrangThai == "Da huy")
                {
                    dem++;
                }
            }

            lblSoLuongHuy.Text = dem.ToString();
        }
        private void LoadDaKham()
        {
            List<LichHen> list = lichHenDAL.GetAllLichHen();

            int dem = 0;

            foreach (LichHen lh in list)
            {
                if (lh.TrangThai == "Da xac nhan")   // hoặc "Đã khám" nếu CSDL của bạn dùng giá trị này
                {
                    dem++;
                }
            }

            lblSoLuongDaKham.Text = dem.ToString();
        }
        private LichHenDAL lichHenDAL = new LichHenDAL();
        private void LoadTongHen()
        {
            List<LichHen> list = lichHenDAL.GetAllLichHen();

            lblSoLuongHen.Text = list.Count.ToString();
        }

        //private void LoadDanhSachQuaGio()
        //{
        //    dgvLichHen.DataSource =
        //        lichHenDAL.GetDanhSachQuaGio();
        //}
        private void lblDashboardPhongKham_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCanhCao_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabCanhBao;
            ResetMenuColor();

            btnCanhBao.BackColor = Color.RoyalBlue;
        }

        private void pnlTongHen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSoLuongHen_Click(object sender, EventArgs e)
        {

        }

        private void pnlDaKham_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlDaHuy_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tblCards_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabDashboard;

            ResetMenuColor();

            btnDashboard.BackColor = Color.RoyalBlue;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKeBS_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabThongKeBS;
            ResetMenuColor();

            btnThongKeBS.BackColor = Color.RoyalBlue;
        }

        private void btnThongKeKhoa_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabThongKeKhoa;
            ResetMenuColor();

            btnThongKeKhoa.BackColor = Color.RoyalBlue;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabBaoCao;
            ResetMenuColor();

            btnBaoCao.BackColor = Color.RoyalBlue;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void ResetMenuColor()
        {
            btnDashboard.BackColor = Color.FromArgb(11, 42, 89);
            btnCanhBao.BackColor = Color.FromArgb(11, 42, 89);
            btnThongKeBS.BackColor = Color.FromArgb(11, 42, 89);
            btnThongKeKhoa.BackColor = Color.FromArgb(11, 42, 89);
            btnBaoCao.BackColor = Color.FromArgb(11, 42, 89);
            btnDangXuat.BackColor = Color.FromArgb(11, 42, 89);


            btnDashboard.ForeColor = Color.White;
            btnCanhBao.ForeColor = Color.White;
            btnThongKeBS.ForeColor = Color.White;
            btnThongKeKhoa.ForeColor = Color.White;
            btnBaoCao.ForeColor = Color.White;
            btnDangXuat.ForeColor = Color.White;
        }

        private void cboThangBS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXemThongKeBS_Click(object sender, EventArgs e)
        {

            int thang = Convert.ToInt32(cboThang.Text);

            dgvThongKeBS.Rows.Clear();
            chartThongKeBS.Series.Clear();

            var series = chartThongKeBS.Series.Add("Số lịch hẹn");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            int stt = 1;

            foreach (ThongKeBacSi item in thongKeBacSiDAL.GetThongKeBacSiTheoThang(thang))
            {
                dgvThongKeBS.Rows.Add(
                    stt++,
                    item.MaBS,
                    item.TenBacSi,
                    item.ChuyenKhoa,
                    item.SoLichHen,
                    item.DaKham,
                    item.Huy
                );

                series.Points.AddXY(item.TenBacSi, item.SoLichHen);
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void grpBieuDo_Enter(object sender, EventArgs e)
        {

        }

        private void pnlFilterBaoCao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMoTaDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chartBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void tabBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvCanhBao_ColumnHeadersHeightSizeModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {

        }

        private void lblCanhBaoGanDay_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpCanhBao_Enter(object sender, EventArgs e)
        {

        }

        private void grpThongKe_Enter(object sender, EventArgs e)
        {

        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (dgvCanhBao.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn cảnh báo!");
                return;
            }

            MessageBox.Show("Đã xử lý cảnh báo");

            dgvCanhBao.Rows.RemoveAt(
                dgvCanhBao.CurrentRow.Index);
        }

        private void btnRefreshCanhBao_Click(object sender, EventArgs e)
        {
            LoadDanhSachCanhBao();

            MessageBox.Show("Đã làm mới dữ liệu");
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboThangBC.Text) ||
                string.IsNullOrWhiteSpace(cboNamBC.Text))
            {
                MessageBox.Show("Vui lòng chọn tháng và năm.");
                return;
            }

            int thang = Convert.ToInt32(cboThangBC.Text);
            int nam = Convert.ToInt32(cboNamBC.Text);

            LoadBaoCao(thang, nam);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "PDF File|*.pdf";
            save.Title = "Lưu báo cáo";

            if (save.ShowDialog() != DialogResult.OK)
                return;

            Document document = new Document(PageSize.A4, 20, 20, 20, 20);

            PdfWriter.GetInstance(document,
                new FileStream(save.FileName, FileMode.Create));

            document.Open();

            Paragraph title = new Paragraph("BAO CAO PHONG KHAM");
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 15;

            document.Add(title);

            document.Add(new Paragraph("Ngay lap: " +
                DateTime.Now.ToString("dd/MM/yyyy")));

            document.Add(new Paragraph(" "));

            PdfPTable table =
                new PdfPTable(dgvBaoCao.Columns.Count);

            table.WidthPercentage = 100;

            foreach (DataGridViewColumn col in dgvBaoCao.Columns)
            {
                table.AddCell(col.HeaderText);
            }

            foreach (DataGridViewRow row in dgvBaoCao.Rows)
            {
                if (row.IsNewRow)
                    continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(cell.Value == null ? "" : cell.Value.ToString());
                }
            }

            document.Add(table);

            document.Add(new Paragraph(" "));

            document.Add(new Paragraph(
                "Tong doanh thu: "
                + lblDoanhThu.Text));

            document.Close();

            MessageBox.Show("Xuất PDF thành công!");
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Đang tạo báo cáo doanh thu tháng này!",
        "Báo cáo");
        }
        private void LoadThongKeBS(int thang)
        {
            MessageBox.Show("Thống kê bác sĩ tháng " + thang);
        }

        private void LoadDanhSachCanhBao()
        {
            MessageBox.Show("Làm mới cảnh báo");
        }


        private void ExportToExcel()
        {
            MessageBox.Show("Xuất Excel thành công");
        }

        private void ExportToPDF()
        {
            MessageBox.Show("Xuất PDF thành công");
        }

        private void cboThangBC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSoDangCho_Click(object sender, EventArgs e)
        {

        }
        private void SetupDashboard()
        {
            dgvLichHen.EnableHeadersVisualStyles = false;
            dgvLichHen.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 153);
            dgvLichHen.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLichHen.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            dgvLichHen.ColumnHeadersHeight = 45;
            dgvLichHen.RowTemplate.Height = 35;
            dgvLichHen.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10);
            dgvLichHen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichHen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichHen.RowHeadersVisible = false;
        }
        private void SetupCanhBao()
        {
            dgvCanhBao.EnableHeadersVisualStyles = false;
            dgvCanhBao.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvCanhBao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCanhBao.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);

            dgvCanhBao.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCanhBao.RowTemplate.Height = 35;

            dgvCanhBao.RowHeadersVisible = false;

            dgvCanhBao.AllowUserToAddRows = false;
        }
        private void SetupThongKeBS()
        {
            if (chartThongKeBS.Series.Count > 0)
            {
                chartThongKeBS.Series[0].Color = Color.RoyalBlue;
                chartThongKeBS.Series[0].IsValueShownAsLabel = true;
            }

            chartThongKeBS.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartThongKeBS.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            dgvThongKeBS.EnableHeadersVisualStyles = false;
            dgvThongKeBS.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvThongKeBS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void SetupBaoCao()
        {
            dgvBaoCao.EnableHeadersVisualStyles = false;

            dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;

            dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvBaoCao.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);

            dgvBaoCao.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 12);

            dgvBaoCao.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void SetupThongKeKhoa()
        {
            dgvThongKeKhoa.EnableHeadersVisualStyles = false;

            dgvThongKeKhoa.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;

            dgvThongKeKhoa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvThongKeKhoa.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);

            dgvThongKeKhoa.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 11);

            dgvThongKeKhoa.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void A_ThongKe_Load(object sender, EventArgs e)
        {
            LoadTongHen();
            LoadDangCho();
            LoadDaKham();
            LoadDaHuy();

            LoadDanhSachThongKe();
            LoadChart();

            LoadQuaGio();
            LoadCanhBaoKhan();
            LoadChuaThanhToan();
            LoadCanhBao();
            LoadChartCanhBao();

            LoadThongKeBacSi();
            LoadChartThongKeBacSi();

            LoadThongKeKhoa();
            LoadCardThongKeKhoa();
            LoadChartThongKeKhoa();

            LoadThang();

            LoadNam();

            cboThangBC.SelectedItem = DateTime.Now.Month;
            cboNamBC.SelectedItem = DateTime.Now.Year;

            LoadBaoCao(DateTime.Now.Month, DateTime.Now.Year);
        }
    }
}

