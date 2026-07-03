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
    public partial class V_DanhSachSlot : Form
    {
        public V_DanhSachSlot()
        {
            InitializeComponent();

            UiHelper.StyleForm(this);
            UiHelper.StyleTitle(lblTitle);
            UiHelper.StyleLabel(lblLoc);
            UiHelper.StyleGrid(dgvSlot);
            TopLevel = false;
            Dock = DockStyle.Fill;


        }


        private void cboLocBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

