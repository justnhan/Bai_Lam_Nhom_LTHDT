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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

            UiHelper.StyleForm(this);
            pnlMenu.BackColor = UiHelper.MenuTrai;

            UiHelper.StyleButton(btnTaoSlot, UiHelper.MenuTrai);
            UiHelper.StyleButton(btnDanhSachSlot, UiHelper.MenuTrai);
            UiHelper.StyleButton(btnQuanLyPhong, UiHelper.MenuTrai);
            UiHelper.StyleButton(btnPhanCong, UiHelper.MenuTrai);
            UiHelper.StyleButton(btnThongKe, UiHelper.MenuTrai);
        }

        private void ChinhButtonMenu(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(11, 42, 74);
            btn.ForeColor = Color.White;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void btnTaoSlot_Click(object sender, EventArgs e)
        {
            FrmQuanLySlot f = new FrmQuanLySlot();
            f.Show();
        }

        private void btnDanhSachSlot_Click(object sender, EventArgs e)
        {
            FrmDanhSachSlot f = new FrmDanhSachSlot();
            f.Show();
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            FrmQuanLyPhong f = new FrmQuanLyPhong();
            f.Show();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            FrmPhanCong f = new FrmPhanCong();
            f.Show();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            f.Show();
        }
    }
}