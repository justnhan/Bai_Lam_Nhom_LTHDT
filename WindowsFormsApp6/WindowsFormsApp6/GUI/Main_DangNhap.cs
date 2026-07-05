using Bai_Lam_Nhom_LTHDT;
using Bai_Lam_Nhom_LTHDT.DAL;
using Bai_Lam_Nhom_LTHDT.Entity;
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
    public partial class Main_DangNhap : Form
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
        
        public Main_DangNhap()
        {
            InitializeComponent();

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!");
                txtTaiKhoan.Focus();
                return;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                txtMatKhau.Focus();
                return;
            }

            TaiKhoan tk = taiKhoanDAL.Login(
                txtTaiKhoan.Text.Trim(),
                Security.Hash(txtMatKhau.Text.Trim())
            );

            if (tk == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                return;
            }

            this.Hide();

            switch (tk.MaQuyen)
            {
                case "Q001":
                    new AdminHomeForm().ShowDialog();
                    break;

                case "Q002":
                    new N_TrangChuBacSi().ShowDialog();
                    break;

                case "Q003":
                    new T_TrangChuTiepNhan().ShowDialog();
                    break;

                case "Q004":
                    new V_TrangChuDieuPhoi().ShowDialog();
                    break;

                default:
                    MessageBox.Show("Tài khoản chưa được phân quyền!");
                    break;
            }

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Main_DangKy dk = new Main_DangKy();

            dk.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar =
            chkHienMatKhau.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N_TrangChuBacSi f = new N_TrangChuBacSi();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T_TrangChuTiepNhan f = new T_TrangChuTiepNhan();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            V_TrangChuDieuPhoi f = new V_TrangChuDieuPhoi();
            f.ShowDialog();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            A_ThongKe f = new A_ThongKe();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Main_TrangChu f = new Main_TrangChu();
            f.ShowDialog();
        }
    }
}
