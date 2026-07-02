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
    public partial class V_TrangChuDieuPhoi : Form
    {
        public V_TrangChuDieuPhoi()
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
            V_QuanLySlot f = new V_QuanLySlot();
            f.ShowDialog();
        }

        private void btnDanhSachSlot_Click(object sender, EventArgs e)
        {
            V_DanhSachSlot f = new V_DanhSachSlot();
            f.ShowDialog();
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            V_QuanLyPhong f = new V_QuanLyPhong();
            f.ShowDialog();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            V_PhanCong f = new V_PhanCong();
            f.ShowDialog();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe f = new FrmThongKe();
            f.ShowDialog();
        }
    }
}