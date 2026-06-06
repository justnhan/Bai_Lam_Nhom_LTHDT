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
    public partial class FrmQuanLyPhong : Form
    {
        public FrmQuanLyPhong()
        {
            InitializeComponent();
            UiHelper.StyleForm(this);
            UiHelper.StyleTitle(lblTitle);
            UiHelper.StyleGrid(dgvPhong);

            UiHelper.StyleButton(btnThem, UiHelper.Them);
            UiHelper.StyleButton(btnSua, UiHelper.Sua);
            UiHelper.StyleButton(btnXoa, UiHelper.Xoa);
            UiHelper.StyleButton(btnLamMoi, UiHelper.Refresh);

            dgvPhong.Rows.Add("P101", "Phòng 101", "1", "Đang hoạt động");
            dgvPhong.Rows.Add("P102", "Phòng 102", "1", "Đang hoạt động");
            dgvPhong.Rows.Add("P103", "Phòng 103", "1", "Đang hoạt động");
            dgvPhong.Rows.Add("P104", "Phòng 104", "1", "Đang hoạt động");
            dgvPhong.Rows.Add("P105", "Phòng 105", "1", "Bảo trì");
        }
    }
}
