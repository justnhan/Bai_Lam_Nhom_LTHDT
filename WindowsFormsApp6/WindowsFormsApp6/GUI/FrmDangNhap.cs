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

namespace WindowsFormsApp6
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
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
                FrmThongKe f = new FrmThongKe();

                f.Show();


            }
            else if (txtTaiKhoan.Text == "bacsi" && txtMatKhau.Text == "456")
            {
                FrmTrangChuBacSi f = new FrmTrangChuBacSi();

                f.Show();


            }

            else if(txtTaiKhoan.Text == "lich" && txtMatKhau.Text == "789")
            {
                FormMenu f = new FormMenu();
                f.Show();

            }

            else if (txtTaiKhoan.Text == "letan" && txtMatKhau.Text == "000")
            {
                FrmTiepNhan f = new FrmTiepNhan();
                f.Show();

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
            FrmDangKy dk = new FrmDangKy();

            dk.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar =
            chkHienMatKhau.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTrangChuBacSi f = new FrmTrangChuBacSi();
            f.Show();
        }
    }
}
