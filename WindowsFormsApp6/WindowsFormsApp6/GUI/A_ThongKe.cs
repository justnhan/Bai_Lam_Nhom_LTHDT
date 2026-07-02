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

namespace WindowsFormsApp6
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
        }

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

        private void Form1_Load(object sender, EventArgs e)
            { 
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            dgvLichHen.Rows.Add("1", "BN001", "Nguyễn Văn An", "08:00", "BS Nam", "Quá giờ");
            dgvLichHen.Rows.Add("2", "BN002", "Trần Thị Bình", "08:30", "BS Lan", "Quá giờ");
            dgvLichHen.Rows.Add("3", "BN003", "Lê Minh Hoàng", "09:00", "BS Hùng", "Quá giờ");
            dgvLichHen.Rows.Add("4", "BN004", "Phạm Thu Hà", "09:15", "BS Nam", "Quá giờ");
            dgvLichHen.Rows.Add("5", "BN005", "Võ Quốc Khánh", "09:30", "BS Mai", "Quá giờ");
            dgvLichHen.Rows.Add("6", "BN006", "Đặng Thị Ly", "10:00", "BS Lan", "Quá giờ");
            dgvLichHen.Rows.Add("7", "BN007", "Bùi Thanh Tùng", "10:15", "BS Hùng", "Quá giờ");
            dgvLichHen.Rows.Add("8", "BN008", "Nguyễn Thả", "10:30", "BS Nam", "Quá giờ");

            foreach (DataGridViewRow row in dgvLichHen.Rows)
            {
                if (row.Cells["clnTrangThai"].Value?.ToString() == "Quá giờ")
                {
                    row.Cells["clnTrangThai"].Style.BackColor = Color.Red;
                    row.Cells["clnTrangThai"].Style.ForeColor = Color.White;
                    row.Cells["clnTrangThai"].Style.Font =
                        new Font("Segoe UI", 12, FontStyle.Bold);
                }
            }

            dgvLichHen.EnableHeadersVisualStyles = false;
            dgvLichHen.ColumnHeadersDefaultCellStyle.BackColor =Color.FromArgb(0, 0, 153);
            dgvLichHen.ColumnHeadersDefaultCellStyle.ForeColor =Color.White;
            dgvLichHen.ColumnHeadersDefaultCellStyle.Font =new Font("Segoe UI", 12, FontStyle.Bold);
            dgvLichHen.ColumnHeadersHeight = 45;
            dgvLichHen.ColumnHeadersHeightSizeMode =DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLichHen.RowTemplate.Height = 35;
            dgvLichHen.DefaultCellStyle.Font =new Font("Segoe UI", 10);
            dgvLichHen.AlternatingRowsDefaultCellStyle.BackColor =Color.FromArgb(240, 245, 250);
            dgvLichHen.BorderStyle = BorderStyle.None;
            dgvLichHen.CellBorderStyle =DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLichHen.AutoSizeColumnsMode =DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichHen.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dgvLichHen.MultiSelect = false;
            dgvLichHen.RowHeadersVisible = false;
            dgvLichHen.Columns["clnSTT"].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleCenter;
            dgvLichHen.Columns["clnGioHen"].DefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleCenter;
            chartLichHen.Series.Clear();

            chartLichHen.Series.Add("Lịch hẹn");

            chartLichHen.Series["Lịch hẹn"].Points.AddXY("T2", 15);
            chartLichHen.Series["Lịch hẹn"].Points.AddXY("T3", 20);
            chartLichHen.Series["Lịch hẹn"].Points.AddXY("T4", 30);
            chartLichHen.Series["Lịch hẹn"].Points.AddXY("T5", 25);
            chartLichHen.Series["Lịch hẹn"].Points.AddXY("T6", 35);
            chartLichHen.Series["Lịch hẹn"].Points.AddXY("T7", 18);

            chartLichHen.Series["Lịch hẹn"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chartThongKeBS.Series.Clear();

            chartThongKeBS.Series.Add("Số lịch hẹn");

            chartThongKeBS.Series[0].Points.AddXY("BS Nam", 45);
            chartThongKeBS.Series[0].Points.AddXY("BS Hùng", 30);
            chartThongKeBS.Series[0].Points.AddXY("BS Minh", 25);
            chartThongKeBS.Series[0].Points.AddXY("BS Lan", 40);
            chartThongKeBS.ChartAreas[0].AxisY.Minimum = 0;
            chartThongKeBS.ChartAreas[0].AxisY.Maximum = 50;
            chartThongKeBS.Series[0]["PointWidth"] = "0.4";
            chartThongKeBS.ChartAreas[0].AxisX.Interval = 1;
            chartThongKeBS.Series[0].IsValueShownAsLabel = true;
            chartThongKeBS.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chartThongKeBS.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chartThongKeBS.ChartAreas[0].BackColor = Color.White;

            chartThongKeBS.BackColor = Color.White;

            chartThongKeBS.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;

            chartThongKeBS.Series[0].Font =
                new Font("Segoe UI", 12, FontStyle.Bold);

            chartThongKeBS.ChartAreas[0].AxisX.LabelStyle.Font =
                new Font("Segoe UI", 12);

            chartThongKeBS.ChartAreas[0].AxisY.LabelStyle.Font =
                new Font("Segoe UI", 12);

            dgvThongKeBS.Rows.Add(1, "BS01", "Nguyễn Văn Nam", "Nội khoa", 45, 40, 5);
            dgvThongKeBS.Rows.Add(2, "BS02", "Trần Minh Hùng", "Ngoại khoa", 30, 28, 2);
            dgvThongKeBS.Rows.Add(3, "BS03", "Lê Thị Lan", "Nhi khoa", 25, 22, 3);

            dgvThongKeBS.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvThongKeBS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvThongKeBS.EnableHeadersVisualStyles = false;

            chartBaoCao.Series.Clear();

            chartBaoCao.Series.Add("Doanh thu");

            chartBaoCao.Series[0].Points.AddXY("T1", 120);
            chartBaoCao.Series[0].Points.AddXY("T2", 150);
            chartBaoCao.Series[0].Points.AddXY("T3", 180);
            chartBaoCao.Series[0].Points.AddXY("T4", 210);

            chartBaoCao.Series[0].ChartType = SeriesChartType.Spline;
            chartBaoCao.Series[0].BorderWidth = 4;
            chartBaoCao.Series[0].IsValueShownAsLabel = true;
            chartBaoCao.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartBaoCao.Height = 350;
            chartBaoCao.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            chartBaoCao.BackColor = Color.White;

            chartBaoCao.ChartAreas[0].BackColor = Color.White;

            chartBaoCao.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chartBaoCao.ChartAreas[0].AxisY.MajorGrid.LineColor =
                Color.Gainsboro;

            chartBaoCao.Series[0].BorderWidth = 5;

            chartBaoCao.Series[0].MarkerStyle =
                MarkerStyle.Circle;

            chartBaoCao.Series[0].MarkerSize = 10;
            chartBaoCao.Titles.Clear();

            chartBaoCao.Titles.Add("BIỂU ĐỒ DOANH THU");

            chartBaoCao.Titles[0].Font =
                new Font("Segoe UI", 16, FontStyle.Bold);

            chartBaoCao.Titles[0].ForeColor = Color.Navy;
            chartBaoCao.Series[0].MarkerColor = Color.RoyalBlue;
            chartBaoCao.Series[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);

            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.BackgroundColor = Color.White;
            dgvBaoCao.BorderStyle = BorderStyle.None;
            dgvBaoCao.EnableHeadersVisualStyles = false;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBaoCao.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvBaoCao.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvBaoCao.RowTemplate.Height = 32;
            dgvBaoCao.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvBaoCao.Rows.Add(1, "HD01", "Nguyễn Văn A", "BS Nam", "Khám tổng quát", "500000", "28/05/2026");
            dgvBaoCao.Rows.Add(2, "HD02", "Trần Thị B", "BS Lan", "Nha khoa", "1200000", "28/05/2026");

            dgvCanhBao.Rows.Add(1, "Lịch hẹn", "BN Nguyễn Văn A trễ 30 phút", "Cao", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            dgvCanhBao.Rows.Add(2, "Thanh toán", "HD02 chưa thanh toán", "Trung bình", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            dgvCanhBao.Rows.Add(3, "Kho thuốc", "Paracetamol sắp hết", "Thấp", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            dgvCanhBao.EnableHeadersVisualStyles = false;
            dgvCanhBao.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvCanhBao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCanhBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCanhBao.RowTemplate.Height = 35;
            dgvCanhBao.ColumnHeadersHeight = 40;
            dgvCanhBao.RowTemplate.Height = 35;
            dgvCanhBao.BorderStyle = BorderStyle.None;
            dgvCanhBao.BackgroundColor = Color.White;
            dgvCanhBao.GridColor = Color.LightGray;
            dgvCanhBao.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgvCanhBao.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvCanhBao.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 51, 102);
            dgvCanhBao.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCanhBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCanhBao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCanhBao.MultiSelect = false;
            dgvCanhBao.RowHeadersVisible = false;
            dgvCanhBao.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvCanhBao.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCanhBao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCanhBao.AllowUserToAddRows = false;

            foreach (DataGridViewRow row in dgvCanhBao.Rows)
            {
                if (row.Cells[3].Value == null)
                    continue;

                string mucDo = row.Cells[3].Value.ToString();

                if (mucDo == "Cao")
                {
                    row.Cells[3].Style.BackColor = Color.Red;
                    row.Cells[3].Style.ForeColor = Color.White;
                }
                else if (mucDo == "Trung bình")
                {
                    row.Cells[3].Style.BackColor = Color.Orange;
                }
                else
                {
                    row.Cells[3].Style.BackColor = Color.LightGreen;
                }
            }

            chartCanhBao.Series.Clear();
            chartCanhBao.Series.Add("CanhBao");
            chartCanhBao.Series["CanhBao"].Points.AddXY("Quá giờ", 12);
            chartCanhBao.Series["CanhBao"].Points.AddXY("Thanh toán", 5);
            chartCanhBao.Series["CanhBao"].Points.AddXY("Khẩn", 2);
            chartCanhBao.Series["CanhBao"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartCanhBao.Series["CanhBao"].IsValueShownAsLabel = true;

            chartCanhBao.Series["CanhBao"].Points[0].Color = Color.Red;
            chartCanhBao.Series["CanhBao"].Points[1].Color = Color.Orange;
            chartCanhBao.Series["CanhBao"].Points[2].Color = Color.Purple;
            chartCanhBao.ChartAreas[0].BackColor = Color.White;
            chartCanhBao.Legends[0].Docking = Docking.Bottom;


            chartKhoa.Series.Clear();
            Series s = new Series("Số bệnh nhân");
            s.ChartType = SeriesChartType.Column;
            s.Points.AddXY("Nội khoa", 120);
            s.Points.AddXY("Ngoại khoa", 80);
            s.Points.AddXY("Nhi khoa", 150);
            s.Points.AddXY("Da liễu", 60);
            chartKhoa.Series.Add(s);
            chartKhoa.ChartAreas[0].AxisY.Minimum = 0;
            chartKhoa.ChartAreas[0].AxisY.Maximum = 200;
            chartKhoa.ChartAreas[0].AxisX.Interval = 1;
            chartKhoa.Series[0].IsValueShownAsLabel = true;
            chartKhoa.Series[0]["PointWidth"] = "0.45";
            chartKhoa.Series[0].Color = Color.RoyalBlue;

            chartKhoa.Titles.Clear();
            chartKhoa.Titles.Add("BIỂU ĐỒ THỐNG KÊ KHOA");
            chartKhoa.Titles[0].Font = new Font("Segoe UI", 16, FontStyle.Bold);
            chartKhoa.Titles[0].ForeColor = Color.DarkBlue;
            chartKhoa.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartKhoa.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartKhoa.BorderlineColor = Color.Silver;
            chartKhoa.BorderlineDashStyle = ChartDashStyle.Solid;
            chartKhoa.BorderlineWidth = 1;

            dgvKhoa.Rows.Add(1, "K01", "Nội khoa", 5, 120, "50 triệu");
            dgvKhoa.Rows.Add(2, "K02", "Ngoại khoa", 3, 80, "35 triệu");
            dgvKhoa.Rows.Add(3, "K03", "Nhi khoa", 4, 150, "70 triệu");
            dgvKhoa.EnableHeadersVisualStyles = false;
            dgvKhoa.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dgvKhoa.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhoa.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvKhoa.ColumnHeadersHeight = 40;
            dgvKhoa.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvKhoa.RowTemplate.Height = 35;
            dgvKhoa.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvKhoa.ColumnHeadersDefaultCellStyle.Alignment =DataGridViewContentAlignment.MiddleCenter;

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
            btnDangXuat.ForeColor =Color.White;
        }

        private void cboThangBS_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }

        private void btnXemThongKeBS_Click(object sender, EventArgs e)
        {

            int thang;

            if (int.TryParse(cboThangBS.Text, out thang))
            {
                LoadThongKeBS(thang);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tháng");
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
            LoadBaoCao(
                cboThangBC.Text,
                cboNamBC.Text);

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportToPDF();
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

        private void LoadBaoCao(string thang, string nam)
        {
            MessageBox.Show("Báo cáo tháng " + thang + "/" + nam);
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
    }
    }

