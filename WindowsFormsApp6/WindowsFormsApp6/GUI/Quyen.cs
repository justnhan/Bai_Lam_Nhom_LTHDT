using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT.GUI
{
    public partial class Quyen : Form
    {
        public Quyen()
        {
            InitializeComponent();
            txtQuyen.PasswordChar = '*';
        }

        private void btnKtr_Click(object sender, EventArgs e)
        {
            if (txtQuyen.Text == "admin123")
            {
                MessageBox.Show("Bạn đã nhập đúng quyền quản trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main_DangKy f = new Main_DangKy();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai quyền quản trị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
