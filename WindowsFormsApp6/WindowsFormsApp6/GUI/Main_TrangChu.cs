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

        private void btnMainDangNhap_Click(object sender, EventArgs e)
        {
            string chon = cboNhanVat.SelectedItem.ToString();
            if (chon == "Tiếp tân")
            {
                // Handle the case when "Tiếp tân" is selected
            }
            if (chon == "Bác sĩ trưởng")
            {
                // Handle the case when "Bác sĩ" is selected
            }
            if (chon == "Điều phối viên")
            {
                // Handle the case when "Điều phối" is selected
            }
            if (chon == "Quản lý")
            {
                // Handle the case when "Quản trị" is selected
            }
        }
    }
    
}
