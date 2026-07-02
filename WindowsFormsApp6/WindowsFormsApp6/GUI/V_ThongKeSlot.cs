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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
            UiHelper.StyleForm(this);
            UiHelper.StyleTitle(lblTitle);

            gbTongSlot.BackColor = UiHelper.PanelNhat;
            gbSlotTrong.BackColor = UiHelper.PanelNhat;
            gbDaDat.BackColor = UiHelper.PanelNhat;
            gbDaHuy.BackColor = UiHelper.PanelNhat;

            gbTongSlot.ForeColor = UiHelper.ChuThuong;
            gbSlotTrong.ForeColor = UiHelper.ChuThuong;
            gbDaDat.ForeColor = UiHelper.ChuThuong;
            gbDaHuy.ForeColor = UiHelper.ChuThuong;

            lblTongSlot.Text = "9";
            lblDaDat.Text = "2";
            lblSlotTrong.Text = "1";
            lblDaHuy.Text = "1";

            lblTongSlot.ForeColor = Color.White;
            lblDaDat.ForeColor = Color.DodgerBlue;
            lblSlotTrong.ForeColor = Color.Orange;
            lblDaHuy.ForeColor = Color.Red;
        }

        private void gbTongSlot_Enter(object sender, EventArgs e)
        {

        }
    }
}
