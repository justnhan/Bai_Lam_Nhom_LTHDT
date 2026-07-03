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
    public partial class Main_DangKy : Form
    {
        public Main_DangKy()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Nhập tài khoản");
                return;
            }

            if (txtMatKhau.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }

            MessageBox.Show("Đăng ký thành công");
        }

        private void txtNhapLai_TextChanged(object sender, EventArgs e)
        {
            txtNhapLai.PasswordChar = '*';
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            char c = chkHienMatKhau.Checked ? '\0' : '*';

            txtMatKhau.PasswordChar = c;
            txtNhapLai.PasswordChar = c;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
