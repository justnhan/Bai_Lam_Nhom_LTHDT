using Bai_Lam_Nhom_LTHDT;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Bai_Lam_Nhom_LTHDT
{
    public partial class Main_DangNhap : Form
    {
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
            if (txtTaiKhoan.Text == "admin"
        && txtMatKhau.Text == "123")
            {
                this.Hide();
                A_ThongKe f = new A_ThongKe();
                f.ShowDialog();
                this.Close();


            }
            else if (txtTaiKhoan.Text == "bacsi" && txtMatKhau.Text == "456")
            {
                this.Hide();
                N_TrangChuBacSi f = new N_TrangChuBacSi();
                f.ShowDialog();
                this.Close();


            }

            else if(txtTaiKhoan.Text == "lich" && txtMatKhau.Text == "789")
            {
                this.Hide();
                V_TrangChuDieuPhoi f = new V_TrangChuDieuPhoi();
                f.ShowDialog();
                this.Close();
            }

            else if (txtTaiKhoan.Text == "letan" && txtMatKhau.Text == "000")
            {
                this.Hide();
                T_TrangChuTiepNhan f = new T_TrangChuTiepNhan();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Sai tài khoản hoặc mật khẩu");
            }
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
    }
}
