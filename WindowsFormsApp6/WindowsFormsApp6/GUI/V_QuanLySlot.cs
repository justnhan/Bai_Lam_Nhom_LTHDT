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
    public partial class V_QuanLySlot : Form
    {
        public V_QuanLySlot()
        {
            InitializeComponent();
            UiHelper.StyleForm(this);
            UiHelper.StyleTitle(lblTitle);

            UiHelper.StyleLabel(lblBacSi);
            UiHelper.StyleLabel(lblNgay);
            UiHelper.StyleLabel(lblBatDau);
            UiHelper.StyleLabel(lblKetThuc);
            UiHelper.StyleLabel(lblThoiLuong);
            UiHelper.StyleLabel(lblPhong);

            UiHelper.StyleButton(btnTaoSlot, UiHelper.Luu);



            dtGioBatDau.Format = DateTimePickerFormat.Time;
            dtGioBatDau.ShowUpDown = true;

            dtGioKetThuc.Format = DateTimePickerFormat.Time;
            dtGioKetThuc.ShowUpDown = true;

            numThoiLuong.Value = 20;
            TopLevel = false;
            Dock = DockStyle.Fill;
        }

        private void btnTaoSlot_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmQuanLySlot_Load(object sender, EventArgs e)
        {

        }

        private void lblBacSi_Click(object sender, EventArgs e)
        {

        }

        private void lblNgay_Click(object sender, EventArgs e)
        {

        }

        private void lblBatDau_Click(object sender, EventArgs e)
        {

        }

        private void lblKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void lblThoiLuong_Click(object sender, EventArgs e)
        {

        }

        private void lblPhong_Click(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numThoiLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblBatDau_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPhong_Click_1(object sender, EventArgs e)
        {

        }

        private void lblThoiLuong_Click_1(object sender, EventArgs e)
        {

        }

        private void lblKetThuc_Click_1(object sender, EventArgs e)
        {

        }

        private void lblNgay_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBacSi_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoSlot_Click_1(object sender, EventArgs e)
        {

        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtNgayLamViec_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtGioKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtGioBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
