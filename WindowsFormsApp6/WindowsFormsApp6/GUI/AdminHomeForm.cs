using System;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT.GUI
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();

            // Card Tiếp tân
            pictureBox1.Click += panelReception_click;
            label1.Click += panelReception_click;
            label2.Click += panelReception_click;
            label3.Click += panelReception_click;
            panelReception.Click += panelReception_click;

            // Card Bác sĩ
            pictureBox2.Click += panel1_Click;
            label4.Click += panel1_Click;
            label5.Click += panel1_Click;
            label6.Click += panel1_Click;
            panel1.Click += panel1_Click;

            // Card Điều phối
            pictureBox3.Click += panel2_Click;
            label7.Click += panel2_Click;
            label8.Click += panel2_Click;
            label9.Click += panel2_Click;
            panel2.Click += panel2_Click;

            // Card Thống kê
            pictureBox4.Click += panel3_Click;
            label10.Click += panel3_Click;
            label11.Click += panel3_Click;
            label12.Click += panel3_Click;
            panel3.Click += panel3_Click;
        }

        // =======================
        // Điều hướng các phân hệ
        // =======================

        private void panelReception_click(object sender, EventArgs e)
        {
            this.Hide();
            T_TrangChuTiepNhan frm = new T_TrangChuTiepNhan();
            frm.ShowDialog();
            this.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            N_TrangChuBacSi frm = new N_TrangChuBacSi();
            frm.ShowDialog();
            this.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_TrangChuDieuPhoi frm = new V_TrangChuDieuPhoi();
            frm.ShowDialog();
            this.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            A_ThongKe frm = new A_ThongKe();
            frm.ShowDialog();
            this.Show();
        }

        // =======================
        // Đăng xuất
        // =======================

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Main_DangNhap frm = new Main_DangNhap();
            frm.Show();
            this.Close();
        }

        // =======================
        // Các sự kiện Designer
        // =======================

        private void AdminHomeForm_Load(object sender, EventArgs e) { }
        private void pnlBottom_Paint(object sender, PaintEventArgs e) { }
        private void pnlInfo_Paint(object sender, PaintEventArgs e) { }
        private void panelReception_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void panel8_Paint(object sender, PaintEventArgs e) { }
        private void lblDate_Click(object sender, EventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
    }
}