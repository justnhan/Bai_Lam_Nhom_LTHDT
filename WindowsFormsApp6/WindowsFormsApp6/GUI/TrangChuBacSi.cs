using Bai_Lam_Nhom_LTHDT.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai_Lam_Nhom_LTHDT
{
    public partial class FrmTrangChuBacSi : Form
    {
        public FrmTrangChuBacSi()
        {
            InitializeComponent();
            DuLieuMau();
        }

        private void DuLieuMau()
        {
            lbSoBacSi.Text = " 10";
            lbSoCaDaKham.Text = " 50";
            lbSoChuyenKhoa.Text = " 5";
            lbSoLichHen.Text = " 20";


        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmQuanLyBacSi f1 = new FrmQuanLyBacSi();
            f1.Show();

        }

        private void lbSoBacSi_Click(object sender, EventArgs e)
        {

        }

        private void btnQLChuyenKhoa_Click(object sender, EventArgs e)
        {
            QuanLyChuyenKhoa f1 = new QuanLyChuyenKhoa();
            f1.Show();
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            FrmLichLamViec f1 = new FrmLichLamViec();
            f1.Show();
        }

        private void btnChiTietLich_Click(object sender, EventArgs e)
        {
            ChiTietLichHen f1 = new ChiTietLichHen();
            f1.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
