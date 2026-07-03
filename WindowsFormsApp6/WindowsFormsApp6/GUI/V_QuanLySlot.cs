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

            cboBacSi.SelectedIndex = 0;
            cboPhong.SelectedIndex = 0;

            dtGioBatDau.Format = DateTimePickerFormat.Time;
            dtGioBatDau.ShowUpDown = true;

            dtGioKetThuc.Format = DateTimePickerFormat.Time;
            dtGioKetThuc.ShowUpDown = true;

            numThoiLuong.Value = 20;
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
    }
}
