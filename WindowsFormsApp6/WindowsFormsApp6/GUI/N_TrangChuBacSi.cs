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
    public partial class N_TrangChuBacSi : Form
    {
        public N_TrangChuBacSi()
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

            N_QuanLyBacSi f1 = new N_QuanLyBacSi();
            f1.ShowDialog();

        }

        private void lbSoBacSi_Click(object sender, EventArgs e)
        {

        }

        private void btnQLChuyenKhoa_Click(object sender, EventArgs e)
        {
            N_QuanLyChuyenKhoa f1 = new N_QuanLyChuyenKhoa();
            f1.ShowDialog();
        }

        private void btnLichLamViec_Click(object sender, EventArgs e)
        {
            N_LichLamViec f1 = new N_LichLamViec();
            f1.ShowDialog();
        }

        private void btnChiTietLich_Click(object sender, EventArgs e)
        {
            N_ChiTietLichHen f1 = new N_ChiTietLichHen();
            f1.ShowDialog();
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
