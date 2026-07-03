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
    public partial class V_QuanLySlotTong : Form
    {
        public V_QuanLySlotTong()
        {
            InitializeComponent();
            LoadQuanLySlot();
        }
        private void LoadQuanLySlot()
        {
            // Form tạo slot
            V_QuanLySlot frm1 = new V_QuanLySlot();

            frm1.TopLevel = false;
            frm1.FormBorderStyle = FormBorderStyle.None;
            frm1.Dock = DockStyle.Fill;

            tabPage1.Controls.Clear();
            tabPage1.Controls.Add(frm1);

            frm1.Show();


            // Form danh sách
            V_DanhSachSlot frm2 = new V_DanhSachSlot();

            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;

            tabPage2.Controls.Clear();
            tabPage2.Controls.Add(frm2);

            frm2.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
                
        }
    }
}
