using Bai_Lam_Nhom_LTHDT.DAL;
using Bai_Lam_Nhom_LTHDT.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class V_TrangChuDieuPhoi : Form
    {
        LichTrucDAL lichTrucDAL = new LichTrucDAL();
        public V_TrangChuDieuPhoi()
        {
            InitializeComponent();

            UiHelper.StyleForm(this);
            pnlMenu.BackColor = UiHelper.MenuTrai;

            UiHelper.StyleButton(btnTaoSlot, UiHelper.MenuTrai);
            UiHelper.StyleButton(btnQuanLyPhong, UiHelper.MenuTrai);
            LoadLichTruc();
            MauDGV(dgvDashboard);

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

            dgvDashboard.DataSource = dt;
            dgvDashboard.ClearSelection();

        }
        private void MoForm(Form frm)
        {
            pnlNoiDung.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);
            frm.Show();
        }
        private void ChinhButtonMenu(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(11, 42, 74);
            btn.ForeColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void btnTaoSlot_Click(object sender, EventArgs e)
        {
            MoForm(new V_QuanLySlotTong());
        }


        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            MoForm(new V_QuanLyPhong());
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pnlNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblIconPhong_Click(object sender, EventArgs e)
        {

        }

        private void dgvDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}