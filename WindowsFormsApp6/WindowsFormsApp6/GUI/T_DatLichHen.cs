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
    public partial class T_DatLichHen : Form
    {
        public T_DatLichHen()
        {
            InitializeComponent();
            giuLieuMau();
        }
        private void giuLieuMau()
        {
            txtDiaChi.Text = "SONHA001";
            txtEmail.Text = "example@example.com";
            txtGhiChu.Text = "Đau đầu";
            txtHoVaTen.Text = "Nguyen Van A";
            txtLyDoKham.Text = "Khám tổng quát";
            txtNhapSDT.Text = "0123456789";
            txtSDT.Text = "0123456789";
            txtBacSi.Text = "Dr. Nguyen Van B";
            txtPhongKham.Text = "Phòng khám 1";
            dtpNgayHen.Value = new DateTime(2026, 8, 1);
            dtpNgaySinh.Value = new DateTime(2006, 1, 1);
            nudGioHen.Value = 10;

        }
    }
}
