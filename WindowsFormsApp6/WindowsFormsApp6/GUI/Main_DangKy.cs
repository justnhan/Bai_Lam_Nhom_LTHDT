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

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class Main_DangKy : Form
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();
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

            TaiKhoan tk = new TaiKhoan(
                txtTaiKhoan.Text.Trim(),
                Security.Hash(txtMatKhau.Text),
                cboQuyen.SelectedValue.ToString(),
                "Hoat dong"
            );

            if (taiKhoanDAL.Add(tk))
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show(taiKhoanDAL.GetError());
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
