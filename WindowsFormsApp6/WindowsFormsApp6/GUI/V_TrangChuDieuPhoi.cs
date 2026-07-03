using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai_Lam_Nhom_LTHDT.GUI;

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
            UiHelper.StyleButton(btnQuanLyPhong, UiHelper.MenuTrai);
            UiHelper.StyleButton(btnPhanCong, UiHelper.MenuTrai);
        }
        private void MoForm(Form frm)
        {
            pnlNoiDung.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            pnlNoiDung.Controls.Add(frm);
            frm.Show();
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
            MoForm(new V_QuanLySlotTong());
        }


        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            MoForm(new V_QuanLyPhong());
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            MoForm(new V_PhanCong());
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            MoForm(new FrmThongKe());
        }
    }
}