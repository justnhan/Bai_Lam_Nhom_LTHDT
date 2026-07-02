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

            cboLocBacSi.Items.Clear();
            cboLocBacSi.Items.Add("Tất cả");
            cboLocBacSi.Items.Add("BS. Nguyễn Văn A");
            cboLocBacSi.Items.Add("BS. Trần Thị B");
            cboLocBacSi.Items.Add("BS. Lê Văn C");
            cboLocBacSi.Items.Add("BS. Phạm Thị D");

            DuLieuSlot.TaoDuLieuMau();

            cboLocBacSi.SelectedIndex = 0;
            LoadDuLieuSlot("Tất cả");
        }

        private void LoadDuLieuSlot(string bacSi)
        {
            dgvSlot.Rows.Clear();

            foreach (SlotInfo slot in DuLieuSlot.DanhSachSlot)
            {
                if (bacSi == "Tất cả" || slot.BacSi == bacSi)
                {
                    dgvSlot.Rows.Add(
                        slot.STT,
                        slot.GioBatDau,
                        slot.GioKetThuc,
                        slot.BacSi,
                        slot.Phong,
                        slot.TrangThai,
                        slot.BenhNhan
                    );
                }
            }
        }

        private void cboLocBacSi_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDuLieuSlot(cboLocBacSi.Text);
        }
    }
}

