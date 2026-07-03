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
    public partial class Main_TrangChu : Form
    {
        public Main_TrangChu()
        {
            InitializeComponent();
            cboNhanVat.SelectedIndex = 0;
            cboNhanVat.SelectionStart = 0;
            cboNhanVat.SelectionLength = 0;
            this.ActiveControl = btnMainDangNhap;
        }

        private void Main_TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = btnMainDangNhap;
        }
    }
}
